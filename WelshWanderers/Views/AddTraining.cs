using System;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class AddTraining : Form
    {
        public AddTraining()
        {
            InitializeComponent();
            emailSent = false;
        }

        private static bool emailSent;  //Boolean variable to see if email has been sent

        private void NavCancel_Click(object sender, EventArgs e)
        {
            //Message box with Yes No buttons checking if user wants to navigate to Home form even though there are unsaved changes
            if (MessageBox.Show("Are you sure? Training will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToHome();    //Navigates to the Home form
            }
        }

        private void NavToHome()
        {
            new Home().Show();  //Shows the Home form
            Close();    //hides this form
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ValidTeam() == true && ValidTime() == true && ValidDuration() == true && ValidDate() == true)   //Checks validation for inputs
            {
                SaveData(); //Saves the data for the trainign session
                if (emailSent)  //Checks if email has been sent
                {
                    NavToHome();    //Navigates to Home form
                }
                else
                {   //Checks if user wants to send an email
                    if (MessageBox.Show("Would you like to send an email before exiting?", "Email not sent.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        NavToPreviewEmail();    //Navigates to the Preview Email form
                    else
                        NavToHome();    //Navigates to Home form
                }
            }
        }

        private void SaveData()
        {
            int trainingID = Functions.FileSearch.GetNextId("trainingDetails"); //gets a value for the id for this training
            string line = trainingID.ToString() + "|" + InputTeam.Text + "|" + InputTimeH.Text + "|" + InputTimeM.Text + "|" + InputDuration.Text + "|" + InputDate.Text + "|";
            Functions.FileWrite.WriteData("trainingDetails", line); //saves record to file
            MessageBox.Show("Training saved.");
        }

        private string[] GetPlayerEmails()
        {
            //puts the id for all the players in the team for the training session in an array
            string[] playerIDs = Functions.FileSearch.ReturnSegment("userAccountDetails", InputTeam.Text, 4, 0, true).Split('|');
            string[] emails = new string[playerIDs.Length];
            for (int i = 0; i < playerIDs.Length; ++i)  //loops through for the number of items in the playerIDs array above
                //searched for the players email address based on their id and adds it to array
                emails[i] = Functions.FileSearch.ReturnSegment("userPersonalDetails", playerIDs[i], 0, 5, false);
            return emails;
        }

        private bool ValidDate()
        {
            if (InputDate.Value > DateTime.Now) //checks date in input is after todays date
                return true;    //returns true if validation passes
            MessageBox.Show("Enter a date after today.");
            return false;   //returns false if validation fails
        }

        private bool ValidDuration()
        {
            int duration = System.Convert.ToInt16(InputDuration.Text);  //Converts duration from string to integer
            if (duration > 0 && duration < 240) //range check
                return true;    //returns true if validation passes
            MessageBox.Show("Duration entered must be a valid duration.");
            return false;   //returns false if validation fails

        }

        private bool ValidTime()
        {
            int hour = System.Convert.ToInt16(InputTimeH.Text); //Converts hours and minutes from
            int min = System.Convert.ToInt16(InputTimeM.Text);   // strings to integers
            if (hour >= 0 && hour <= 23 && min >= 0 && min <= 59)   //Range check
                return true;    //returns true if validation passes
            MessageBox.Show("Time entered must be a valid time.");
            return false;   //returns false if validation fails
        }
        
        private bool ValidTeam()
        {
            if (InputTeam.Text.Length > 0)  //Presence check
                return true;    //returns true if validation passes
            MessageBox.Show("Selected a training type in the drop down box.");
            return false;   //returns false if validation fails
        }

        private void InputPreviewEmail_Click(object sender, EventArgs e)
        {
            NavToPreviewEmail();    //Navigates to Preview Email form
        }

        private void NavToPreviewEmail()
        {
            if (ValidTeam() && ValidTime() && ValidDuration() && ValidDate())   //checks valdation for the inputs
            {
                Database.EmailData.recipients = GetPlayerEmails();  //gets the email addresses for all the players
                //sets the body for the email address
                Database.EmailData.body = "Upcoming " + InputTeam.Text.ToLower() + " training session:\n\nDate: " + InputDate.Text + "\nStart time: " + InputTimeH.Text + ":" + InputTimeM.Text + "\nDuration: " + InputDuration.Text + " minutes.\n\nThanks,\nWelsh Wanderers"; ;
                Database.EmailData.subject = "Training information";    //sets the subject for the email
                StaticDetails();    //sets input boxes to uneditable
                emailSent = true;
                new Views.PreviewEmail().Show();    //Shows the Preview Email form
                EventPreviewEmail.Hide();   //hides the email button
            }
        }

        private void StaticDetails()
        {
            //sets all the input boxes so they can't be edited
            InputTeam.Enabled = false;
            InputTimeH.ReadOnly = true;
            InputTimeM.ReadOnly = true;
            InputDuration.ReadOnly = true;
            InputDate.Enabled = true;
        }
    }
}
