namespace EmailSendingApi.Mediatr.Handlers;

public class SendMailsCommandHandler : IRequestHandler<SendMailsCommand, IResult>
{
    private readonly IMailSendingService _mailSendingService;
    private readonly EmailDbContext _db;

    public SendMailsCommandHandler(IMailSendingService mailSendingService, EmailDbContext db)
    {
        _mailSendingService = mailSendingService;
        _db = db;
    }

    /// <summary>
    /// Handle for send email command
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<IResult> Handle(SendMailsCommand request, CancellationToken cancellationToken)
    {
        // send mail
        var mailResult = await _mailSendingService.Send(new SendEmailModel
        {
            Body = request.Body,
            Recipients = request.Recipients,
            Subject = request.Subject
        });

        // log to db
        await _db.Emails.AddAsync(new Email
        {
            Body = request.Body,
            Status = mailResult.IsSuccess ? SendEmailResult.Ok.ToString() : SendEmailResult.Failed.ToString(),
            Subject = request.Subject,
            Recipients = request.Recipients.Select(x => new Recipient { Email = x }).ToList(),
            FailedMessage = mailResult.FailedMessage
        }, cancellationToken);

        await _db.SaveChangesAsync(cancellationToken);

        var response = new SendMailResponseModel
        {
            FailedMessage = mailResult.FailedMessage
        };

        if (!mailResult.IsSuccess)
            return Results.BadRequest(response);

        response.Result = SendEmailResult.Ok;
        return Results.Ok(response);
    }
}