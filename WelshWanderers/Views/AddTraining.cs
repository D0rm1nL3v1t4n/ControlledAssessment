using System;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class AddTraining : Form
    {
        public AddTraining()
        {
            InitializeComponent();
        }

        private static bool emailSent = false;

        private void NavCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Training will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToHome();
            }
        }

        private void NavToHome()
        {
            new Home().Show();
            Hide();
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ValidTeam() && ValidTime() && ValidDuration() && ValidDate())
            {
                SaveData();
                if (emailSent)
                {
                    NavToHome();
                }
                else
                {
                    if (MessageBox.Show("Would you like to send an email before exiting?", "Email not sent.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        NavToPreviewEmail();
                    else
                        NavToHome();
                }
            }
        }

        private void SaveData()
        {
            int trainingID = Functions.FileSearch.GetNextId("trainingDetails");
            string line = trainingID.ToString() + "|" + InputTeam.Text + "|" + InputTimeH.Text + "|" + InputTimeM.Text + "|" + InputDuration.Text + "|" + InputDate.Text + "|";
            Functions.FileWrite.WriteData("trainingDetails", line);
            MessageBox.Show("Training saved.");
        }

        private string[] GetPlayerEmails()
        {
            string[] playerIDs = Functions.FileSearch.ReturnSegment("userAccountDetails", InputTeam.Text, 4, 0, true).Split('|');
            string[] emails = new string[playerIDs.Length];
            for (int i = 0; i < playerIDs.Length; ++i)
                emails[i] = Functions.FileSearch.ReturnSegment("userPersonalDetails", playerIDs[i], 0, 5, false);   //Quicker method?
            return emails;
        }

        private bool ValidDate()
        {
            if (InputDate.Value > DateTime.Now)
                return true;
            MessageBox.Show("Enter a date after today.");
            return false;
        }

        private bool ValidDuration()
        {
            int duration = System.Convert.ToInt16(InputDuration.Text);
            if (duration > 0 && duration < 240)
                return true;
            MessageBox.Show("Duration entered must be a valid duration.");
            return false;
            
        }

        private bool ValidTime()
        {
            int hour = System.Convert.ToInt16(InputTimeH.Text);
            int min = System.Convert.ToInt16(InputTimeM.Text);
            if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59)
                return true;
            MessageBox.Show("Time entered must be a valid time.");
            return false;
        }
        
        private bool ValidTeam()
        {
            if (InputTeam.Text != null)
                return true;
            MessageBox.Show("Selected a training type in the drop down box.");
            return false;
        }

        private void InputPreviewEmail_Click(object sender, EventArgs e)
        {
            NavToPreviewEmail();
        }

        private void NavToPreviewEmail()
        {
            //if (ValidTeam() && ValidTime() && ValidDuration() && ValidDate())
            //{
            //Database.EmailData.recipients = GetPlayerEmails();
            //Database.EmailData.body = "Upcoming " + InputTeam.Text.ToLower() + " training session:\n\nDate: " + InputDate.Text + "\nStart time: " + InputTimeH.Text + ":" + InputTimeM.Text + "\nDuration: " + InputDuration.Text + " minutes.\n\nThanks,\nWelsh Wanderers"; ;
            //Database.EmailData.subject = "Training information";
            //StaticDetails();
            //emailSent = true;
            new Views.PreviewEmail().Show();
            //EventPreviewEmail.Hide();
            //}
        }

        private void StaticDetials()
        {
            InputTeam.Enabled = false;
            InputTimeH.ReadOnly = true;
            InputTimeM.ReadOnly = true;
            InputDuration.ReadOnly = true;
            InputDate.Enabled = true;
        }
    }
}
