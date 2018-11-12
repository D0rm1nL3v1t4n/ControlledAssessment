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

        private void NavCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Training will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToHome();
            }
        }

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)
            {
                SaveData();
                SendEmail();
                MessageBox.Show("Training saveed & email sent.");
                NavToHome();
            }
        }

        private void SaveData()
        {
            int trainingID = Functions.FileSearch.GetNextId("trainingDetails");
            string line = trainingID.ToString() + "|" + InputTeam.Text + "|" + InputTimeH.Text + "|" + InputTimeM.Text + "|" + InputDate.Text + "|";
            Functions.FileWrite.WriteData("trainingDetails", line);
        }

        private void SendEmail()
        {
            string[] emails = GetPlayerEmails();
            string body = "New" + InputTeam.Text + "'s training:\n\nDate: " + InputDate.Text + "\nStart time: " + InputTimeH.Text + ":" + InputTimeM.Text + "\nLength: " + InputDuration.Text + "\n\nThanks,\nWelsh Wanderers";
            Functions.SendEmail.Email("Training information", body, emails);
        }

        private string[] GetPlayerEmails()
        {
            string[] playerIDs = Functions.FileSearch.ReturnSegment("userAccountDetails", InputTeam.Text, 4, 0, true).Split('|');
            string[] emails = new string[playerIDs.Length];
            for (int i = 0; i < playerIDs.Length; ++i)
                emails[i] = Functions.FileSearch.ReturnSegment("userPersonalDetails", playerIDs[i], 0, 5, false);   //Quicker method?
            return emails;
        }

        private bool ValidInputs()
        {
            if (ValidTeam() == true && ValidTime() == true && ValidDuration() == true && ValidDate() == true)
                return true;
            else
                return false;
        }

        private bool ValidDate()
        {
            if (InputDate.Value <= DateTime.Now)
                return false;
            else
            {
                MessageBox.Show("Hey Doc, pretty sure we ain't time travelling yet - Marty.");
                return true;
            }
        }

        private bool ValidDuration()
        {
            int duration = System.Convert.ToInt16(InputDuration.Text);
            if (duration > 0 && duration < 240)
                return true;
            else
            {
                MessageBox.Show("Duration entered must be a valid duration.");
                return false;
            }
        }

        private bool ValidTime()
        {
            int hour = System.Convert.ToInt16(InputTimeH.Text);
            int min = System.Convert.ToInt16(InputTimeM.Text);
            if (hour >= 0 && hour <= 23)
            {
                if (min >= 0 && min <= 59)
                    return true;
                else
                    return false;
            }
            else
            {
                MessageBox.Show("Time entered must be a valid time.");
                return false;
            }  
        }
        
        private bool ValidTeam()
        {
            if (InputTeam.Text == "Clinic" || InputTeam.Text == "Junior" ||
                InputTeam.Text == "Men" || InputTeam.Text == "Women")
                return true;
            else
            {
                MessageBox.Show("Selected a training type in the drop down box.");
                return false;
            }
        }
    }
}
