using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;

namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    public partial class AddTrainingForm : Form
    {
        public AddTrainingForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Training will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReturnHome();
            }
        }

        private void ReturnHome()
        {
            new Forms.coachHomeForm().Show();
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool validTime = CheckValidTimes();
                if (validTime == true)
                {
                    SendEmail();
                    MessageBox.Show("Email Sent!");
                    SaveTrainingData();
                    MessageBox.Show("Training added.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CheckValidTimes()
        {
            if (txtStartHours.Text.Length != 2 || txtStartMin.Text.Length != 2
                || txtFinishHours.Text.Length != 2 || txtFinishMin.Text.Length != 2)
            {
                MessageBox.Show("All times entered must be 2 characters long.");
                return false;
            }
            return true;

        }

        private void SendEmail()
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("WelshWanderersTest@gmail.com");
            mail.Subject = "Training Info";

            StreamReader playerStatsFile = new StreamReader("userAccountDetails.txt");
            string line = playerStatsFile.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');
                if (section[3] == "Player")
                {
                    mail.To.Add(GetPlayerEmail(section[0]));
                }
                line = playerStatsFile.ReadLine();
            }

            string body = "Hello all,\n\nInformation regarding upcoming " +
                CmbTrainingType.Text.ToLower() + " training.\n\nStart: " +
                txtStartHours.Text + ":" + txtStartMin.Text + "\nFinish: " +
                txtFinishHours.Text + ":" + txtFinishMin.Text + "\nDate: " +
                TrainingDate.Text + "\n\nThanks,\n" + UserData.firstName +
                " " + UserData.lastName + "\nWelsh Wanderers";
            mail.Body = body;

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("WelshWanderersTest@gmail.com", "TestPassword1!");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }


        private string GetPlayerEmail(string playerID)
        {
            StreamReader userPersonalDetailsFile = new StreamReader("userPersonalDetails.txt");
            string line = userPersonalDetailsFile.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');
                if (playerID == section[0])
                {
                    return section[5];
                }
                line = userPersonalDetailsFile.ReadLine();
            }
            return null;
        }


        private void SaveTrainingData()
        {
            string trainingID = FindTrainingID();
            using (System.IO.StreamWriter trainingDetailsFile =
                    new System.IO.StreamWriter("trainingDetails.txt", true))
            {
                trainingDetailsFile.WriteLine(
                    trainingID + "|" + CmbTrainingType.Text + "|" +
                    txtStartHours.Text + "|" + txtStartMin.Text + "|" +
                    txtFinishHours.Text + "|" + txtFinishMin.Text + "|" +
                    TrainingDate.Text + "|");
            }
        }

        private string FindTrainingID()
        {
            if (File.ReadLines("trainingDetails.txt").Count() == 0)
            {
                return "0";
            }

            StreamReader trainingDetails = new StreamReader("trainingDetails.txt");
            string line = trainingDetails.ReadLine();
            string previousID = "";
            while (null != line)
            {
                string[] section = line.Split('|');
                previousID = section[0];
                line = trainingDetails.ReadLine();
            }
            trainingDetails.Close();
            int newTrainingID = System.Convert.ToInt16(previousID);
            ++newTrainingID;
            return newTrainingID.ToString();
        }
    }
}
