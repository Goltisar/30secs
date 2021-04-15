using System.Threading.Tasks;

namespace WebApp.Mailing
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
