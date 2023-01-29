using SendGrid;
using SendGrid.Helpers.Mail;

namespace CPW221_Project_eCom.Models
{
    public interface IEmailProvider
    {
        Task SendEmailAsync(string toEmail, string fromEmail, string subject, 
            string content, string htmlContent);

    }
    public class EmailProviderSendGrid : IEmailProvider
    {
        private readonly IConfiguration _config;
        public EmailProviderSendGrid(IConfiguration config)
        {
            _config = config;
        }
        public async Task SendEmailAsync(string toEmail, string fromEmail, string subject,
            string content, string htmlContent)
        {
            var apiKey = _config.GetSection("SENDGRID_KEY").Value;
            var client = new SendGridClient(apiKey);
            
            SendGridMessage msg = new SendGridMessage()
            {
                From = new EmailAddress("lehman5247@students.cptc.edu", "Joe's Discount Computers"),
                Subject = subject,
                PlainTextContent = content,
                HtmlContent = htmlContent
            };
            msg.AddTo(new EmailAddress("joejr65@live.com", "Joe Lehman"));
            // await client.SendEmailAsync(msg);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
