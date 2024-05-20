using Restaurant.Core.Application.Dtos.Email;
using Restaurant.Core.Domain.Settings;

namespace Restaurant.Core.Application.Interfaces.Services
{
    public interface IEmailService
    {
        public MailSettings MailSettings { get; }
        Task SendAsync(EmailRequest request);
    }
}
