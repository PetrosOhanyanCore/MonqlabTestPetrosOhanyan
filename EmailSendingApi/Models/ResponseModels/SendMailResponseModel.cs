namespace EmailSendingApi.Models.ResponseModels;

public class SendMailResponseModel
{
    /// <summary>
    /// Email response result
    /// </summary>
    public SendEmailResult Result { get; set; }

    /// <summary>
    /// Email response failed message
    /// </summary>
    public string FailedMessage { get; set; }
}