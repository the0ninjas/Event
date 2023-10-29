using EventManagementSystem.Models;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
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

    public string getBodyEmailSignup(string firstName)
    {
        string body = string.Empty;

        body = "Dear " + firstName + ",\n\nThank you for signing up!\n\nWe're excited to have you on board. If you have any questions or need assistance, feel free to reach out.\n\n" +
                "Best regards,\nYour EventHub Team";

        return body;
    }

    public string getBodyEmailEventJoined(string firstName, Event eventJoined)
    {
        string body = string.Empty;

        body = "Dear " + firstName + ",\n\nYou have successfully joined the event. We look forward to seeing you there!\n\n" +
                "Event Details:\n\nName: " + eventJoined.title + "\nDate: " + eventJoined.time.ToShortDateString() + "\nTime: " + eventJoined.time.ToString("hh:mm tt") + "\nLocation: " + eventJoined.location + "\n\n" +
                "If you have any further questions, feel free to contact us.\n\n" +
                "Best regards,\nYour EventHub Team";

        return body;
    }

    public string getBodyEmailEventCreated(string firstName, Event eventCreated)
    {
        string body = string.Empty;

        body = "Dear " + firstName + ",\n\nYou have successfully created the event with the following details:\n\n" +
                "Name: " + eventCreated.title + "\nDate: " + eventCreated.time.ToShortDateString() + "\nTime: " + eventCreated.time.ToString("hh:mm tt") + "\nLocation: " + eventCreated.location + "\n\n" +
                "If you have any further questions, feel free to contact us.\n\n" +
                "Best regards,\nYour EventHub Team";

        return body;
    }

    internal string getBodyEmailEventLeft(string firstName, Event leftEvent)
    {
        string body = string.Empty;

        body = "Dear " + firstName + ",\n\nYou have successfully left the event with the following details:\n\n" +
                "Name: " + leftEvent.title + "\nDate: " + leftEvent.time.ToShortDateString() + "\nTime: " + leftEvent.time.ToString("hh:mm tt") + "\nLocation: " + leftEvent.location + "\n\n" +
                "If you have any further questions, feel free to contact us.\n\n" +
                "Best regards,\nYour EventHub Team";

        return body;
    }

    internal string getBodyEmailEventDeleted(string firstName, Event deletedEvent)
    {
        string body = string.Empty;

        body = "Dear " + firstName + ",\n\nYou have successfully deleted the event with the following details:\n\n" +
                "Name: " + deletedEvent.title + "\nDate: " + deletedEvent.time.ToShortDateString() + "\nTime: " + deletedEvent.time.ToString("hh:mm tt") + "\nLocation: " + deletedEvent.location + "\n\n" +
                "If you have any further questions, feel free to contact us.\n\n" +
                "Best regards,\nYour EventHub Team";

        return body;
    }

}
