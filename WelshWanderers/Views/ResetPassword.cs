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
        public static string generatedCode = "";
        public static string userID = ""; 

        public ResetPassword()
        {
            InitializeComponent();
        }

        private void EventEnter_Click(object sender, EventArgs e)
        {
            userID = Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text, 1, 0, false);
            if (null != userID)
            {
                string[] emailAddress = new string[1] { Functions.FileSearch.ReturnSegment("userPersonalDetails", userID, 0, 5, false) };
                ShowEmailAddress(emailAddress[0]);

                GenerateRandomCode();
                Functions.SendEmail.Email("Resetting Password", "Your 6 digit code to change your password:\n\n\n" + generatedCode + "\n\nWelsh Wanderers water polo club.", emailAddress);
            }
            else
            {
                MessageBox.Show("Username not found.");
            }
        }

        private void ShowEmailAddress(string emailAddress)
        {
            LabelUserEmail.Text = emailAddress;
        }

        private void GenerateRandomCode()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringCharacters = new char[6];
            var random = new Random();
            for (int i = 0; i < 6; i++)
            {
                stringCharacters[i] = characters[random.Next(characters.Length)];
            }
            generatedCode = new String(stringCharacters);
        }

        private void EventNavChangePassword_Click(object sender, EventArgs e)
        {
            if (Functions.ValidPassword.IsPasswordValid(InputNewPassword.Text, InputConfirmNewPassword.Text) == true)
            {
                string userAccessLevel = Functions.FileSearch.ReturnSegment("userAccountDetails", userID, 0, 3, false);
                string[] data = { InputUsername.Text, Functions.HashAlgorithm.HashPassword(InputNewPassword.Text), userAccessLevel };
                int[] searchIndex = { 0 };
                string[] searchData = { userID };
                Functions.FileEdit.EditLine("userAccountDetails", 4, data, searchIndex, searchData);
                MessageBox.Show("Your password has been changed.");
                NavToSignIn();
            }
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            NavToSignIn();
        }

        private void NavToSignIn()
        {
            new WelshWanderers.SignIn().Show();
            this.Hide();
        }
    }
}