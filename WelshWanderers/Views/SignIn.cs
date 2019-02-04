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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }        

        private void EventNavSignIn_Click(object sender, EventArgs e)
        {
            string password = Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text.ToLower(), 1, 2, false);
            if (null != password)
            {
                bool success = ComparePasswords(password);
                if (success == true)
                {
                    LoadAccountDetails();
                    LoadPersonalDetails();
                    LoadHome();
                }
            }
            else
                MessageBox.Show("That username does not exist.");
        }

        private bool ComparePasswords(string filePassword) 
        {
            return Functions.HashAlgorithm.CheckHashes(filePassword, InputPassword.Text);
        }

        private void LoadPersonalDetails()
        {
            string[] section = Functions.FileSearch.ReturnLine("userPersonalDetails", Database.UserData.id.ToString(), 0).Split('|');
            Database.UserData.title = section[1];
            Database.UserData.firstName = section[2];
            Database.UserData.lastName = section[3];
            Database.UserData.dateOfBirth = section[4];
            Database.UserData.emailAddress = section[5];
            Database.UserData.telephoneNumber = section[6];
            Database.UserData.postcode = section[7];
        }

        private void LoadAccountDetails()
        {
            Database.UserData.id = System.Convert.ToInt16(Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text.ToLower(), 1, 0, false));
            string[] section = Functions.FileSearch.ReturnLine("userAccountDetails", Database.UserData.id.ToString(), 0).Split('|');
            Database.UserData.username = section[1];
            Database.UserData.accessLevel = section[3];
            Database.UserData.team = section[4];
        }
        private void LoadHome()
        {
            new Home().Show();
            Hide();
        }

        private void NavRegister_Click(object sender, EventArgs e)
        {
            new RegisterRequest().Show();
            Hide();
        }

        private void NavResetPassword_Click(object sender, EventArgs e)
        {
            new ResetPassword().Show();
            Hide();
        }
    }
}