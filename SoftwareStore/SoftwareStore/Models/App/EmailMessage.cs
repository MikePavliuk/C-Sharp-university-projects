using System.Net.Mail;

namespace SoftwareStore.Models.App
{
    public class EmailMessage
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string EmailTo { get; set; }
        public bool IsBodyHtml { get; set; }

        public AttachmentCollection Attachments { get; set; }
    }
}
