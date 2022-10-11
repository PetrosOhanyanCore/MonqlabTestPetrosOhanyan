namespace EmailSendingApi.Services.Interfaces;

public interface IMailSendingService : IBaseService
{
    Task<SendEmailResultModel> Send(SendEmailModel sendEmailModel);
}