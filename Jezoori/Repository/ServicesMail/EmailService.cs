using Microsoft.Extensions.Options;
using MimeKit;

namespace Jezoori.Repository.ServicesMail
{
    using MailKit.Net.Smtp;
    using MimeKit;
    using Microsoft.Extensions.Options;

    public class EmailService
    {
        private readonly IOptions<EmailSettings> _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings;
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Your Name", _emailSettings.Value.SmtpUsername));
            emailMessage.To.Add(new MailboxAddress("", toEmail));
            emailMessage.Subject = subject;

            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = body
            };

            emailMessage.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                try
                {
                    // Disable certificate validation (not recommended for production)
                    client.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                    // Set a timeout for the connection
                    client.Timeout = 10000; // Timeout in milliseconds

                    // Connect and authenticate
                    await client.ConnectAsync("smtp.gmail.com", 587, false); // Use false for TLS
                    await client.AuthenticateAsync(_emailSettings.Value.SmtpUsername.ToString(), _emailSettings.Value.SmtpPassword.ToString());

                    // Send the email
                    await client.SendAsync(emailMessage);
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error sending email: {ex.Message}");
                }
            }
        }
    }

}
