using System;
using System.Windows.Forms;
using System.IO;

namespace VisualCSharp
{
    public partial class signInForm : Form
    {
        public signInForm()
        {
            InitializeComponent();
        }
        //COMPLETE
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            bool successfulLogin = false;
            string userLevel = "";
            if (TxtUsername.TextLength > 1)
            {
                StreamReader userAccountDetails = new StreamReader("userAccountDetails.txt");
                string line = userAccountDetails.ReadLine();
                while (null != line && successfulLogin == false)
                {
                    if ("" != line)
                    {
                        successfulLogin = CheckLogin(line);
                        if (successfulLogin == true)
                        {
                            LoadAccountDetails(line);
                            LoadPersonalDetails();
                        }

                        userLevel = CheckUserLevel(line);
                    }
                    line = userAccountDetails.ReadLine();
                }
                userAccountDetails.Close();
                if (successfulLogin == true)
                {
                    LoadHome(userLevel);
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!");
                    TxtPassword.Text = "";
                }
            }
            else
            {
                MessageBox.Show("ERROR: Please enter your username.");
            }
        }

        private void LoadPersonalDetails()
        {
            StreamReader userPersonalDetails = new StreamReader("userPersonalDetails.txt");
            string line = userPersonalDetails.ReadLine();

            while (null != line)
            {
                string[] section = line.Split('|');
                
                if (section[0] == UserData.userID.ToString())
                {
                    StoreData(line);
                }
                line = userPersonalDetails.ReadLine();
            }
            userPersonalDetails.Close();

        }


        private void StoreData(string line)
        {
            string[] section = line.Split('|');
            UserData.title = section[1];
            UserData.firstName = section[2];
            UserData.lastName = section[3];
            UserData.dateOfBirth = section[4];
            UserData.emailAddress = section[5];
            UserData.telephoneNumber = section[6];
            UserData.postcode = section[7];


        }

        //Complete
        private void LoadAccountDetails(string line)
        {
            string[] section = line.Split('|');
            UserData.userID = System.Convert.ToInt16(section[0]);
            UserData.username = section[1];
            UserData.userLevel = section[3];
        }
        
        //COMPLETE
        private bool CheckLogin(string line)
        {
            string[] section = line.Split('|');
            bool success = false;
            if (TxtUsername.Text.ToLower() == section[1].ToLower())
            {
                if (TxtPassword.Text == section[2])
                {
                    success = true;
                }
            }
            return success;
        }
        //COMPLETE
        private string CheckUserLevel(string line)
        {
            string[] section = line.Split('|');
            if (section[3] == "Admin")
            {
                return "Admin";
            }
            else if (section[3] == "Coach")
            {
                return "Coach";
            }
            else
            {
                return "Player";
            }
        }

        private void LoadHome(string userLevel)
        {
            
            if (userLevel == "Admin")
            {
                new Forms.Home_Screens.AdminHomeForm().Show();
            }
            else if (userLevel == "Coach")
            {
                new Forms.coachHomeForm().Show();
            }
            else if (userLevel == "Player")
            {
                new Forms.playerHomeForm().Show();
            }
            this.Hide();
        }
        //COMPLETE
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            new Forms.registrationForm().Show();
            this.Hide();
        }

        private void BtnResetPassword_Click(object sender, EventArgs e)
        {
            new Forms.ResetPasswordForm().Show();
            this.Hide();
        }
    }
}
