using System.Net.Mail;
using System.Windows.Forms;

namespace WelshWanderers.Functions
{
    public static class SendEmail
    {
        private static SmtpClient smtpServer = null;    //sets the variable for if the smtp server has been set up

        private static void SetUpServer()
        {
            if (smtpServer == null) //checks if sever has been set up already
            {   //sets up server if not set up yet
                //details for setting up the email server
                smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587;                                     //email address to be used   //password for that email account
                smtpServer.Credentials = new System.Net.NetworkCredential("WelshWanderersTest@gmail.com", "TestPassword1!");
                smtpServer.EnableSsl = true;
            }
        }
        
        public static void Email(string subject, string body, string[] recipients)
        {
            try
            {
                SetUpServer();  //calls on function to set up server

                MailMessage email = new MailMessage();  //creates new email
                email.From = new MailAddress("WelshWanderersTest@gmail.com");   //sets 'From' for email
                foreach (string emailAddress in recipients) //loops for each recipient in array
                {
                    if (null != emailAddress)   //checks if email address is not empty
                    {
                        email.To.Add(emailAddress); //adds email address to 'To'
                    }
                }
                email.Subject = subject;    //sets subject for email
                email.Body = body;      //sets body for email
                smtpServer.Send(email); //sends email
            }
            catch(SmtpException e)  //catches potential error
            {   //Message box displaying the error taht has been caught
                //Retry & Cancel buttons asking if they want to retry sending the email
                if (MessageBox.Show("ERROR SENDING EMAIL.\n\n" + e + "\n\nPlease see system administrator.\n\nWould you like to retry sending the email?", "Error sending email", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    Email(subject, body, recipients);   //attempts to send the same email again
            }
        }
    }
}
