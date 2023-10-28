using System;
using System.Net;
using System.Net.Mail;

public class EmailSender
{
    private readonly string smtpServer;
    private readonly int smtpPort;
    private readonly string senderEmail;
    private readonly string senderPassword;

    public EmailSender(string smtpServer, int smtpPort, string senderEmail, string senderPassword)
    {
        this.smtpServer = smtpServer;
        this.smtpPort = smtpPort;
        this.senderEmail = senderEmail;
        this.senderPassword = senderPassword;
    }

    public void SendEmail(string recipientEmail, string subject, string body)
    {
        using (SmtpClient smtpClient = new SmtpClient(smtpServer))
        {
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;
            smtpClient.Port = smtpPort;

            using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body))
            {
                try
                {
                    smtpClient.Send(mailMessage);
                    Console.WriteLine("Email sent successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to send email. Error: {ex.Message}");
                }
            }
        }
    }

    // Additional methods for handling attachments, HTML emails, etc., can be added here
}
