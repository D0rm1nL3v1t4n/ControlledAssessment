using System;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class ViewUser : Form
    {
        private static string userID = "-1";
        private static string password = "";
        private static string accessLevel = "";
        private static string team = "";

        private class Changes
        {   //boolean variables for if the original data has been changed and the count for the changes made
            public static int count = 0;
            public static bool accessLevel = false;
            public static bool team = false;

            public static void ResetChanges()
            {   //resets variables to original values
                count = 0;
                accessLevel = false;
                team = false;
            }
        }

        public ViewUser(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            LoadUserData(); //calls on function to load the user's data into the form
            EditOff();  //calls on function to change the editability of the form off
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if changes have been made
            {   //Message box with Yes No buttons asking the user if they are sure they want to exit the form even though they have some unsaved changes
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    NavToManageUsers(); //navigation to Users form
                return;
            }
            NavToManageUsers(); //navigation to Users form
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if changes have been made
            {
                ChangeData();   //calls on function to change the data for the user

                SendEmail();    //calls on function to send email to user informing them of the changes made
                MessageBox.Show("User details have been updated.");
                EditOff();  //calls on function to turn the editability of the form off
            }
            else
            {
                MessageBox.Show("You have not made any changes.");
            }
        }

        private void SendEmail()
        {
            string changedDetails = "";
            if (InputAccessLevel.Text != accessLevel)   //checks if the user's access level has been changed
                changedDetails += "Previous access level: " + accessLevel + ".\nNew access level: " + InputAccessLevel.Text + ".\n";
            //data for the body of the email
            if (InputTeam.Text != team) //checks if team has changed
            {
                if (InputTeam.Text == "")   //checks if user has a team when they didnt before
                    changedDetails += "Previous team: " + team + ".\nNew team: None.";
                else if (team == "")    //checks if user no longer has a team when they did before
                    changedDetails += "Previous team: None.\nNew team: " + InputTeam.Text + ".";
                else
                    changedDetails += "Previous team: " + team + ".\nNew team: " + InputTeam.Text + ".";
            }
            string[] email = { InputEmailAddress.Text };    //sets the email address to be sent to
            //sends email informing user of the changes made to their account
            Functions.SendEmail.Email("Details have been changed.", "Your account details have been changed by an admin.\nYour following details have been updated:\n\n" + changedDetails + "\n\n\nWelsh Wanderers.", email);
        }

        private void ChangeData()
        {
            string newTeam = InputTeam.Text;
            if (accessLevel == "Player" && accessLevel != InputAccessLevel.Text)    //value check
                newTeam = "";
            string[] data = { InputUsername.Text, password, InputAccessLevel.Text, newTeam };
            int[] searchIndex = { 0 };
            string[] searchData = { userID };
            //edits the user's data in the file
            Functions.FileEdit.EditLine("userAccountDetails", 5, data, searchIndex, searchData);
        }

        private void NavToManageUsers()
        {
            new ManageUsers().Show();   //shows the Users form
            Close();    //closes this form
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if changes have been made
            {   //Message box with Yes No buttons asking the user if they want to continue as changes have not been saved
                if (MessageBox.Show("You have unsaved changes, are you sure you want to continue?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    EditOff();  //calls on function to turn the editability of the form off
                return;
            }
            EditOff();  //calls on function to turn the editability of the form off
        }

        private void EventEdit_Click(object sender, EventArgs e)
        {
            EditOn();   //calls on function to turn the editability of the form on
        }

        private void LoadUserData()
        {
            string[] data = GetData();  //calls on function to get the user's data
            ShowData(data); //calls on function to show the user's data in the form
        }

        private string[] GetData()
        {
            string personalDetails = Functions.FileSearch.ReturnLine("userPersonalDetails", userID, 0); //loads user's personal details
            string accountDetails = Functions.FileSearch.ReturnLine("userAccountDetails", userID, 0);   //loads user's account details
            string dataLine = personalDetails + accountDetails; //concatenates the data for personal details and account details together
            string[] data = dataLine.Split('|');    //splits data into individual components based on the delimiter
            return data;
        }

        private void ShowData(string[] data)
        {   //loads data into the table and stores data which isn't loaded into the table as variables
            InputId.Text = data[0];
            InputTitle.Text = data[1];
            InputFirstName.Text = data[2];
            InputLastName.Text = data[3];
            InputDateOfBirth.Text = data[4];
            InputEmailAddress.Text = data[5];
            InputTelephoneNumber.Text = data[6];
            InputPostcode.Text = data[7];
            InputUsername.Text = data[9];
            InputAccessLevel.Text = data[11];
            InputTeam.Text = data[12];
            password = data[10];
            accessLevel = data[11];
            team = data[12];
        }

        private void ReloadData()
        {   //sets the data in teh access level and team text boxes to the original data
            InputAccessLevel.Text = accessLevel;
            InputTeam.Text = team;
        }

        private void EditOn()
        {   //changes the enabled state of the access level and team drop down boxes so they can be edited
            InputAccessLevel.Enabled = true;
            InputTeam.Enabled = true;
            EventEdit.Hide();   //hides the edit button
            //shows the changes made label and the save & cancel edit button
            EventCancelEdit.Show();
            EventSave.Show();
            LabelChangesMade.Show();
            LabelChangesMade.Text = "0 changes\nmade."; //sets the text in the changes made label
        }

        private void EditOff()
        {   //changes the enabled state of the access level and team drop down boxes so they cant be edited
            InputAccessLevel.Enabled = false;
            InputTeam.Enabled = false;
            EventEdit.Show();     //shows the edit button
            //hides the cancel edit & save button and the changes made label
            EventCancelEdit.Hide();
            EventSave.Hide();
            LabelChangesMade.Hide();
            ReloadData();   //calls on function to load the original data back into the form
            Changes.ResetChanges(); //calls on function to reset variables
        }

        private void ShowChangesMade()
        {   //label showing the changes made to the data
            LabelChangesMade.Text = Changes.count + " change(s)\nmade.";
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {   //checks if data has been changed from the original data
            if (inputData != databaseValue && changedVal == false)
            {
                ++Changes.count;    //incraments count by 1
                ShowChangesMade();  //calls on function to show the changes made
                return true;
            }
            //checks if data has been changed back to original data
            else if (inputData == databaseValue && changedVal == true)
            {
                --Changes.count;    //decreases count by 1
                ShowChangesMade();  //calls on function to show the changes made
                return false;
            }
            return changedVal;
        }

        private void InputAccessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {   //checks if the data for access level has been changed
            Changes.accessLevel = DetailsChanged(InputAccessLevel.Text, accessLevel, Changes.accessLevel);
        }

        private void InputTeam_SelectedIndexChanged(object sender, EventArgs e)
        {   //checks if the data for the team has been changed
            Changes.team = DetailsChanged(InputTeam.Text, team, Changes.team);
        }
    }
}
