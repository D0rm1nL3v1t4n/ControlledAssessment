using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            LoadNextUser();
            MakeReadOnly();
        }

        private void MakeReadOnly()
        {
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
            string line = Functions.FileSearch.ReturnLine("userJoinRequests", "0", 0);
            if (null != line)
            {
                string[] section = line.Split('|');
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
                NavToHome();
            }
        }

        private void EventAcceptUser_Click(object sender, EventArgs e)
        {
            if (InputAccessLevel.Text == "Player" && null == InputTeam.Text)
            {
                MessageBox.Show("Please select a team for this player.\nAll players must be assigned to a team.");
                return;
            }

            if (null != InputAccessLevel.Text)
            {
                WriteData(Functions.FileSearch.GetNextId("userPersonalDetails").ToString());
                DeleteRequest();
                EmailAcceptUser();
                MessageBox.Show("User has been accepted.");
                LoadNextUser();
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
            string accountDetailsData = id + "|" + InputUsername.Text.ToLower() + "|" + Functions.HashAlgorithm.HashPassword(password) + "|" + InputAccessLevel.Text + "|" + InputTeam.Text + "|";
            Functions.FileWrite.WriteData("userPersonalDetails", personalDetailsData);
            Functions.FileWrite.WriteData("userAccountDetails", accountDetailsData);
        }

        private void EventRejectUser_Click(object sender, EventArgs e)
        {
            DeleteRequest();
            EmailRejectUser();
            MessageBox.Show("User has been rejected.");
            LoadNextUser();
        }

        private void DeleteRequest()
        {
            Functions.FileDelete.RemoveLine("userJoinRequests", 11, 1);
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new Home().Show();
            Hide();
        }

        private void EventHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("'Team' is the team within the club that the user plays for. This is only applicable to players.\n'Access Level' is required if a user is accepted. This defines what access they have to which functions and features. Not required if a user is rejected.");
        }

        private void InputAccessLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputAccessLevel.Text == "Player")
            {
                if (team != "")
                {
                    InputTeam.Text = team;
                }
                else
                {
                    InputTeam.Enabled = true;
                    MessageBox.Show("Please select a team for this player.\nAll players must be assigned to a team.");
                }
            }
            else
            {
                InputTeam.Enabled = false;
                InputTeam.Text = "";
            }
        }

        private void EmailAcceptUser()
        {
            string body = "This is an email to inform you that your registration request has been processed.\n\nWe are glad to inform you that your request has been accepted.\nYou may now access the system with your username: " + InputUsername.Text + ", and your password for your account.\n\n\nThanks,\nWelsh Wanderers";
            string[] recipient = { InputEmailAddress.Text };
            Functions.SendEmail.Email("Registration Request Update", body, recipient);
        }

        private void EmailRejectUser()
        {
            string body = "This is an email to inform you that your registration request has been processed.\n\nUnfortunatly your request has been rejected.\nAlthough you may make another request, we cannot garantee that any request is accepted.\n\n\nThanks,\nWelsh Wanderers";
            string[] recipient = { InputEmailAddress.Text };
            Functions.SendEmail.Email("Registration Request Update", body, recipient);
        }
    }
}
