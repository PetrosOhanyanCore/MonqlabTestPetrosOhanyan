namespace EmailSendingApi.Models;

public class SendEmailResultModel
{
    /// <summary>
    /// Email send success
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// Failed Email Message
    /// </summary>
    public string FailedMessage { get; set; }
}