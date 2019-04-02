using System;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class ResetPassword : Form
    {
        private static string generatedCode = "";
        private static string userID = ""; 

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void EventEnter_Click(object sender, EventArgs e)
        {   //checks if the user exists
            if (null != (userID = Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text.ToLower(), 1, 0, false)))
            {   //finds the email address for that user
                InputUsername.ReadOnly = true;  //sets the input for username as readonly so it cannot be edited
                string[] emailAddress = { Functions.FileSearch.ReturnSegment("userPersonalDetails", userID, 0, 5) };
                ShowEmailAddress(emailAddress[0]);  //calls on function to show the email address for that user

                generatedCode = Functions.RandomCode.GenerateCode(8);   //generates random code 8 characters long
                //sends email containing random code
                Functions.SendEmail.Email("Resetting Password", "Your 8 digit code to change your password:\n\n\n" + generatedCode + "\n\nWelsh Wanderers water polo club.", emailAddress);
            }
            else
                MessageBox.Show("Username not found.");
        }

        private void ShowEmailAddress(string emailAddress)
        {
            LabelUserEmail.Text = emailAddress; //shows the email address the code is being sent to
        }

        private void NavToSignIn()
        {
            new SignIn().Show();    //shows Sign In form
            Close();    //closes this form
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            NavToSignIn();  //navigation to Sign In form
        }

        private void EventNavChangePassword_Click(object sender, EventArgs e)
        {
            if (InputCode.Text != generatedCode)    //checks if the code entered is incorrect
            {
                MessageBox.Show("The code entered is incorrect.");
                return;
            }
            if (Functions.Validation.IsPasswordValid(InputNewPassword.Text, InputConfirmNewPassword.Text) == true)  //checks if the new password entered is valid
            {
                ChangePassword();   //calls on function to change the users password
                NavToSignIn();  //navigation to Sign In form
            }
        }

        private void ChangePassword()
        {
            string userAccessLevel = Functions.FileSearch.ReturnSegment("userAccountDetails", userID, 0, 3, false); //gets the access level of the user
            string[] data = { InputUsername.Text, Functions.HashAlgorithm.HashPassword(InputNewPassword.Text), userAccessLevel };
            int[] searchIndex = { 0 };
            string[] searchData = { userID };
            Functions.FileEdit.EditLine("userAccountDetails", 5, data, searchIndex, searchData);    //edits the file, changing the user's password
            MessageBox.Show("Your password has been changed.");
        }

    }
}