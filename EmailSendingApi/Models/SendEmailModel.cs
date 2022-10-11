namespace EmailSendingApi.Models;

public class SendEmailModel
{
    /// <summary>
    /// Email send body
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Email send subject
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Email recipients
    /// </summary>
    public IEnumerable<string> Recipients { get; set; }
}