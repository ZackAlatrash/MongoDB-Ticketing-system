using System;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Service
{
    public class MailingService
    {
        private readonly string smtpHost;
        private readonly int smtpPort;
        private readonly bool smtpEnableSsl;
        private readonly string smtpUsername;
        private readonly string smtpPassword;

        public MailingService()
        {
            smtpHost = ConfigurationManager.AppSettings["SmtpHost"];
            smtpPort = int.Parse(ConfigurationManager.AppSettings["SmtpPort"]);
            smtpEnableSsl = bool.Parse(ConfigurationManager.AppSettings["SmtpEnableSsl"]);
            smtpUsername = ConfigurationManager.AppSettings["SmtpUsername"];
            smtpPassword = ConfigurationManager.AppSettings["SmtpPassword"];
        }

        // Updated to send the token and username
        public void SendPasswordResetEmail(string toEmail, string resetLink, string token)
        {
            try
            {
                using (var client = new SmtpClient(smtpHost, smtpPort))
                {
                    client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    client.EnableSsl = smtpEnableSsl;

                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(smtpUsername);
                    mailMessage.To.Add(toEmail);  // Send to the recovery email address
                    mailMessage.Subject = "Password Reset Request";

                    // Updated email with copy-paste instructions
                    mailMessage.Body = $@"
                <h1>Password Reset Request</h1>
                <p>Hi,</p>
                <p>You requested to reset your password. Please follow the instructions below:</p>
                <p>1. Open the application.</p>
                <p>2. Copy the token below.</p>
                <p>3. paste the following token into the token popup:</p>
                <p><strong>{token}</strong></p>
                <p>If you did not request this, please ignore this email.</p>
                <p>Thanks!</p>
            ";
                    mailMessage.IsBodyHtml = true;  // Set the email body to HTML

                    client.Send(mailMessage);
                    Console.WriteLine("Email sent successfully.");
                }
            }
            catch (SmtpException ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
            }
        }


    }
}
