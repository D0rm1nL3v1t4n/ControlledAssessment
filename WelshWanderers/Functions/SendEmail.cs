using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace WelshWanderers.Functions
{
    static class SendEmail
    {
        private static SmtpClient smtpServer = null;

        private static void SetUpServer()
        {
            if (smtpServer == null)
            {
                smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("WelshWanderersTest@gmail.com", "TestPassword1!");
                smtpServer.EnableSsl = true;
            }
        }
        
        public static void Email(string subject, string body, string[] recipients)
        {
            SetUpServer();

            MailMessage email = new MailMessage();
            email.From = new MailAddress("WelshWanderersTest@gmail.com");
            foreach (string emailAddress in recipients)
            {
                email.To.Add(emailAddress);
            }
            email.Subject = subject;
            email.Body = body;
            smtpServer.Send(email);           
        }
    }
}
