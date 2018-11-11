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
        public UserJoinRequests() => InitializeComponent();

        public static string password = "";

        private void UserJoinRequests_Load(object sender, EventArgs e) => LoadNextUser();

        private void LoadNextUser()
        {
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
            }
            else
            {
                MessageBox.Show("No more user registration requests.");
                NavToHome();
            }
        }

        private void EventAcceptUser_Click(object sender, EventArgs e)
        {
            if (null != InputAccessLevel.Text)
            {
                WriteData(Functions.FileSearch.GetNextId("userPersonalDetails").ToString());
                DeleteRequest();
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
            string accountDetailsData = id + "|" + InputUsername.Text.ToLower() + "|" + Functions.HashAlgorithm.HashPassword(password) + "|" + InputAccessLevel.Text + "|";
            Functions.FileWrite.WriteData("userPersonalDetails", personalDetailsData);
            Functions.FileWrite.WriteData("userAccountDetails", accountDetailsData);
        }

        private void EventRejectUser_Click(object sender, EventArgs e)
        {
            DeleteRequest();
            MessageBox.Show("User has been rejected.");
            LoadNextUser();
        }

        private void DeleteRequest() => Functions.FileDelete.RemoveLine("userJoinRequests", 10, 1);

        private void NavHome_Click(object sender, EventArgs e) => NavToHome();

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }
    }
}
