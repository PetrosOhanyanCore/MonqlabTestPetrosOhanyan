namespace EmailSendingApi.Mediatr.Commands;

public class SendMailsCommand : IRequest<IResult>
{
    /// <summary>
    /// Email send subject for Mediatr
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Email send body for Mediatr
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Email recipients for Mediatr
    /// </summary>
    public IEnumerable<string> Recipients { get; set; }
}