namespace EmailSendingApi.Data;

public class Email
{
    /// <summary>
    /// Email Id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Email subject
    /// </summary>
    public string Subject { get; set; }

    /// <summary>
    /// Email body
    /// </summary>
    public string Body { get; set; }

    /// <summary>
    /// Email sended date and time
    /// </summary>
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    /// <summary>
    /// Email send status
    /// </summary>
    public string Status { get; set; }

    /// <summary>
    /// Email send failed message
    /// </summary>
    public string? FailedMessage { get; set; }

    /// <summary>
    /// Email recipients
    /// </summary>
    public ICollection<Recipient> Recipients { get; set; }
}