namespace EmailSendingApi.Mediatr.Handlers;

public class GetAllEmailsQueryHandler : IRequestHandler<GetAllEmailsQuery, IEnumerable<Email>>
{
    private readonly EmailDbContext _db;

    public GetAllEmailsQueryHandler(EmailDbContext db)
    {
        _db = db;
    }

    /// <summary>
    /// Get all emails from database
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns>List<Email></returns>
    public async Task<IEnumerable<Email>> Handle(GetAllEmailsQuery request, CancellationToken cancellationToken)
    {
        var emails = await _db.Emails.Include(x => x.Recipients).ToListAsync(cancellationToken);
        return emails;
    }
}