using System;
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
        {   //gets the password for the username entered
            string password = Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text.ToLower(), 1, 2, false);
            if (null != password)   //checks if a password was found ==> if that username exists
            {
                bool success = ComparePasswords(password);  //boolean variable calling on a function to see if the password is correct
                if (success == true)    //checks if the password is correct
                {
                    LoadAccountDetails();   //loads the user's account details into the database
                    LoadPersonalDetails();  //loads the user's personal details into the database
                    MessageBox.Show("Welcome " + Database.UserData.username + ".");
                    LoadHome(); //navigation to Home form
                }
            }
            else
                MessageBox.Show("That username does not exist.");
        }

        private bool ComparePasswords(string filePassword) 
        {
            return Functions.HashAlgorithm.CheckHashes(filePassword, InputPassword.Text);   //calls on function to check if the password entered is correct
        }

        private void LoadPersonalDetails()
        {
            //loads the user's personal details into the database for UserData
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
            //loads the user's account details into the database for UserData NOT including their password
            Database.UserData.id = System.Convert.ToInt16(Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text.ToLower(), 1, 0, false));
            string[] section = Functions.FileSearch.ReturnLine("userAccountDetails", Database.UserData.id.ToString(), 0).Split('|');
            Database.UserData.username = section[1];
            Database.UserData.accessLevel = section[3];
            Database.UserData.team = section[4];
        }
        private void LoadHome()
        {
            new Home().Show();  //shows the Home form
            Hide(); //closes this form
        }

        private void NavRegister_Click(object sender, EventArgs e)
        {
            new RegisterRequest().Show();   //shows the Register Request form
            Hide(); //closes this form
        }

        private void NavResetPassword_Click(object sender, EventArgs e)
        {
            new ResetPassword().Show(); //shows the Reset Password form
            Hide(); //closes this form
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            EventHelp.Hide();   //hides the help button
            if (Functions.FileSearch.ReturnSegment("userAccountDetails", "masteradmin", 1, 0) == null)  //checks if the the userAccountDetails file is empty
            {   //writes data for the masteradmin into the userAccountDetails and userPersonalDetails
                Functions.FileWrite.WriteData("userAccountDetails", "0|masteradmin|" + Functions.HashAlgorithm.HashPassword("Password1!") + "|Admin||");
                Functions.FileWrite.WriteData("userPersonalDetails", "0|Mr|Master|Admin|30 August 2001|12nabramovich@Stanwell.org|07538504384|CF64 2SQ|");
                EventHelp.Show();   //shows the help button
            }
        }

        private void EventHelp_Click(object sender, EventArgs e)
        {   //Message box with information if the user needs help as there are no users on the system
            MessageBox.Show("To use the system you must make a registration request by clicking on the 'Register'.\n\n" +
                "Then, you can use the Master Admin's credentials to enter the system and accept your registration" +
                "request, granting you access to the rest of the system.\nUsername: masteradmin\nPassword: Password1!\n" +
                "Clicking the 'User Join Requests' will allow you to accept your registration request.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}