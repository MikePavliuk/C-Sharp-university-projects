using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using SoftwareStore.Infrastructure.Config;
using SoftwareStore.Models.App;

namespace SoftwareStore.Infrastructure
{
    public class ServiceEmail
    {
        public async Task SendEmailMessageAsync(EmailMessage message)
        {
            try
            {
                ProjectConfiguration config = ProjectConfiguration.Current;

                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                mail.From = new MailAddress(config.Smtp.UserName, config.Company.CompanyName);
                mail.To.Add(message.EmailTo);
                mail.Subject = message.Title;
                mail.Body = message.Body;
                if (message.Attachments?.Any() == true)
                {
                    foreach (Attachment attachment in message.Attachments)
                        mail.Attachments.Add(attachment);
                }
                mail.SubjectEncoding = Encoding.GetEncoding("utf-8");
                SmtpClient SmtpServer = new SmtpClient(config.Smtp.ServerName)
                {
                    Credentials = new NetworkCredential(config.Smtp.UserName, config.Smtp.UserPassword),
                    Port = Convert.ToInt32(config.Smtp.ServerPort),
                    EnableSsl = Convert.ToBoolean(config.Smtp.UseSsl)
                };

                await SmtpServer.SendMailAsync(mail);
            }
            catch (Exception e)
            {
                
            }
        }
    }
}