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
    public partial class ResetPassword : Form
    {
        private static string generatedCode = "";
        private static string userID = ""; 

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void EventEnter_Click(object sender, EventArgs e)
        {
            if (null != (userID = Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text, 1, 0, false)))
            {
                string[] emailAddress = { Functions.FileSearch.ReturnSegment("userPersonalDetails", userID, 0, 5) };
                ShowEmailAddress(emailAddress[0]);

                generatedCode = Functions.RandomCode.GenerateCode(8);
                Functions.SendEmail.Email("Resetting Password", "Your 8 digit code to change your password:\n\n\n" + generatedCode + "\n\nWelsh Wanderers water polo club.", emailAddress);
            }
            else
                MessageBox.Show("Username not found.");
        }

        private void ShowEmailAddress(string emailAddress)
        {
            LabelUserEmail.Text = emailAddress;
        }

        private void NavToSignIn()
        {
            new SignIn().Show();
            Close();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            NavToSignIn();
        }

        private void EventNavChangePassword_Click(object sender, EventArgs e)
        {
            if (InputCode.Text != generatedCode)
            {
                MessageBox.Show("The code entered is incorrect.");
                return;
            }
            if (Functions.Validation.IsPasswordValid(InputNewPassword.Text, InputConfirmNewPassword.Text) == true)
            {
                ChangePassword();
                NavToSignIn();
            }
        }

        private void ChangePassword()
        {
            string userAccessLevel = Functions.FileSearch.ReturnSegment("userAccountDetails", userID, 0, 3, false);
            string[] data = { InputUsername.Text, Functions.HashAlgorithm.HashPassword(InputNewPassword.Text), userAccessLevel };
            int[] searchIndex = { 0 };
            string[] searchData = { userID };
            Functions.FileEdit.EditLine("userAccountDetails", 4, data, searchIndex, searchData);
            MessageBox.Show("Your password has been changed.");
        }

    }
}