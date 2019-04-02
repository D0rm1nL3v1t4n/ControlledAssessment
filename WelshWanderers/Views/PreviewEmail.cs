using System;
using System.Windows.Forms;

namespace WelshWanderers.Views
{
    public partial class PreviewEmail : Form
    {
        public PreviewEmail()
        {
            InitializeComponent();
            LoadEmailPreview(); //loads the preview for the email
        }

        private void LoadEmailPreview()
        {
            InputTo.ReadOnly = true;    //sets the text box labelled 'To' as readonly
            InputBody.Text = Database.EmailData.body.Replace("\n", Environment.NewLine);    //sets each return character (\n) as a newline in the body
            InputSubject.Text = Database.EmailData.subject; //sets the subject
            string emails = "";
            foreach (string email in Database.EmailData.recipients) //loops through all the email addresses to be sent to 
            {
                emails += email + ", "; 
            }
            InputTo.Text = emails;  //adds the email address to the text box
        }
        
        private void EventSendEmail_Click(object sender, EventArgs e)
        {
            Database.EmailData.body = InputBody.Text;   //sets the body for the email
            Database.EmailData.subject = InputSubject.Text; //sets the subject for the email
            SendMatchEmail();   //calls on function to send email
        }

        private void SendMatchEmail()
        {
            //calls on function to send email
            Functions.SendEmail.Email(Database.EmailData.subject, Database.EmailData.body, Database.EmailData.recipients);
            MessageBox.Show("Email sent!");
            Close();    //closes this form
        }

    }
}
