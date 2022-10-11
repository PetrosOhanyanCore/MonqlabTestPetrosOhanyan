namespace EmailSendingApi.Services;

public class MailSendingService : IMailSendingService
{
    private readonly IConfiguration _configuration;

    public MailSendingService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// Send Email message to recipients
    /// </summary>
    /// <param name="sendEmailModel"></param>
    /// <returns>SendEmailResultModel</returns>
    public async Task<SendEmailResultModel> Send(SendEmailModel sendEmailModel)
    {
        try
        {
            var msg = new MailMessage
            {
                Body = sendEmailModel.Body,
                Subject = sendEmailModel.Subject,
                From = new MailAddress(_configuration["EmailSettings:From"])
            };
            
            foreach (var recipient in sendEmailModel.Recipients)
            {
                msg.To.Add(recipient);
            }

            var credentials = new NetworkCredential(_configuration["EmailSettings:Username"], _configuration["EmailSettings:Password"]);
            
            var sc = new SmtpClient
            {
                Port = _configuration.GetValue<int>("EmailSettings:Port"),
                Host = _configuration["EmailSettings:Host"],
                Credentials = credentials,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false
            };
            
             await sc.SendMailAsync(msg);

            return new SendEmailResultModel
            {
                IsSuccess = true
            };
        }
        catch (Exception e)
        {
            return new SendEmailResultModel
            {
                FailedMessage = e.Message,
                IsSuccess = false
            };
        }
    }
}