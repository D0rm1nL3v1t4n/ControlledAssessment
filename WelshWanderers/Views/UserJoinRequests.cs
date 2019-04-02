using System;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class UserJoinRequests : Form
    {
        public UserJoinRequests() 
        { 
            InitializeComponent();
        }

        private static string password = "";
        private static string team = "";

        private void UserJoinRequests_Load(object sender, EventArgs e)
        {
            InputDateOfBirth.Value = DateTime.Today.Date;   //sets the date value in the date time picker to be todays date
            LoadNextUser(); //calls on function to load the next user join request
            MakeReadOnly(); //calls on function to make the input boxes read only and uneditable
        }

        private void MakeReadOnly()
        {   //changes the read only state of the text boxes to true so they can't be edited
            InputFirstName.ReadOnly = true;
            InputLastName.ReadOnly = true;
            InputEmailAddress.ReadOnly = true;
            InputTelephoneNumber.ReadOnly = true;
            InputPostcode.ReadOnly = true;
            InputUsername.ReadOnly = true;
        }

        private void LoadNextUser()
        {
            InputAccessLevel.Text = "";
            string line = Functions.FileSearch.ReturnLine("userJoinRequests", "0", 0);  //gets the first line in the userJoinRequests file
            if (null != line)   //checks if line is empty
            {
                string[] section = line.Split('|'); //splits the line into individual components 
                //enters the data into the text boxes
                InputTitle.Text = section[1];
                InputFirstName.Text = section[2];
                InputLastName.Text = section[3];
                InputDateOfBirth.Text = section[4];
                InputEmailAddress.Text = section[5];
                InputTelephoneNumber.Text = section[6];
                InputPostcode.Text = section[7];
                InputUsername.Text = section[8];
                password = section[9];
                InputTeam.Text = section[10];
                team = section[10];
            }
            else
            {
                MessageBox.Show("No more user registration requests.");
                NavToHome();    //navigation to Home form
            }
        }

        private void EventAcceptUser_Click(object sender, EventArgs e)
        {
            if (InputAccessLevel.Text == "Player" && "" == InputTeam.Text)  //checks if a team has been enterd if the user has an access level 'player'
            {
                MessageBox.Show("Please select a team for this player.\nAll players must be assigned to a team.");
                return;
            }

            if (null != InputAccessLevel.Text)  //checks an access level has been selected for the user
            {
                WriteData(Functions.FileSearch.GetNextId("userPersonalDetails").ToString());    //gets the id to be used for that user
                DeleteRequest();    //calls on function to deletes their user request
                EmailAcceptUser();  //calls on function to send automatic email to inform the user they have had their request accepeted
                MessageBox.Show("User has been accepted.");
                LoadNextUser(); //calls on function to load the next user request
            }
            else
            {
                MessageBox.Show("Select a user access level (and a team if required) if you wish to accept this user.");
            }
        }

        private void WriteData(string id)
        {
            string personalDetailsData = id + "|" + InputTitle.Text + "|" + InputFirstName.Text + "|" + InputLastName.Text + "|" + InputDateOfBirth.Text + "|" + 
                InputEmailAddress.Text + "|" + InputTelephoneNumber.Text + "|" + InputPostcode.Text + "|";
            string accountDetailsData = id + "|" + InputUsername.Text + "|" + password + "|" + InputAccessLevel.Text + "|" + InputTeam.Text + "|";
            Functions.FileWrite.WriteData("userPersonalDetails", personalDetailsData);  //writes a record to the file for the user's personal details
            Functions.FileWrite.WriteData("userAccountDetails", accountDetailsData);    //writes a record to the file for the user's account details
        }

        private void EventRejectUser_Click(object sender, EventArgs e)
        {
            DeleteRequest();    //calls on function to delete the user's join request
            EmailRejectUser();  //calls on function to send automatic email address to inform user they have been rejected
            MessageBox.Show("User has been rejected.");
            LoadNextUser();     //calls on function to load the next user
        }

        private void DeleteRequest()
        {
            Functions.FileDelete.RemoveLine("userJoinRequests", 11, 1); //removes the line for the user's join request
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();    //navigation to Home form
        }

        private void NavToHome()
        {
            new Home().Show();  //shows the Home from
            Close();    //hides this form
        }

        private void EventHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Team' is the team within the club that the user plays for. This is only applicable to players.\n'Access Level' is required if a user is accepted. This defines what access they have to which functions and features. Not required if a user is rejected.");
        }

        private void InputAccessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputAccessLevel.Text == "Player")  //checks if user has access level 'player'
            {
                if (team != "") //checks if team is not empty
                {
                    InputTeam.Text = team;
                }
                else
                {
                    InputTeam.Enabled = true;   //allows the team text box to be edited
                    MessageBox.Show("Please select a team for this player.\nAll players must be assigned to a team.");
                }
            }
            else
            {
                InputTeam.Enabled = false;  //prevents the team text box from being edited
                InputTeam.Text = "";
            }
        }

        private void EmailAcceptUser()
        {
            string body = "This is an email to inform you that your registration request has been processed.\n\nWe are glad to inform you that your request has been accepted.\nYou may now access the system with your username: " + InputUsername.Text + ", and your password.\n\n\nThanks,\nWelsh Wanderers";
            string[] recipient = { InputEmailAddress.Text };
            Functions.SendEmail.Email("Registration Request Update", body, recipient);  //sends email informing user they have been accepted
        }

        private void EmailRejectUser()
        {
            string body = "This is an email to inform you that your registration request has been processed.\n\nUnfortunatly your request has been rejected.\nAlthough you may make another request, we cannot garantee that any request is accepted.\n\n\nThanks,\nWelsh Wanderers";
            string[] recipient = { InputEmailAddress.Text };
            Functions.SendEmail.Email("Registration Request Update", body, recipient);  //sends email informing user they have been rejected
        }
    }
}
