using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelshWanderers.Views
{
    public partial class PreviewEmail : Form
    {
        public PreviewEmail()
        {
            InitializeComponent();
            LoadEmailPreview();
        }

        private void LoadEmailPreview()
        {
            InputTo.ReadOnly = true;
            InputBody.Text = Database.EmailData.body.Replace("\n", Environment.NewLine);
            InputSubject.Text = Database.EmailData.subject;
            string emails = "";
            foreach (string email in Database.EmailData.recipients)
            {
                emails += email + ", ";
            }
            InputTo.Text = emails;
        }
        
        private void EventSendEmail_Click(object sender, EventArgs e)
        {
            Database.EmailData.body = InputBody.Text;
            Database.EmailData.subject = InputSubject.Text;
            SendMatchEmail();
        }

        private void SendMatchEmail()
        {
            Functions.SendEmail.Email(Database.EmailData.subject, Database.EmailData.body, Database.EmailData.recipients);
            MessageBox.Show("Email sent!");
            Close();
        }

    }
}
