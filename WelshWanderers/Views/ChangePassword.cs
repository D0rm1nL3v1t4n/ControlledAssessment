using System;
using System.Windows.Forms;

namespace WelshWanderers.Views
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void EventNavChange_Click(object sender, EventArgs e)
        {
            //checks if the password matches that in the file by calling on the CheckHashes function
            if (Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("userAccountDetails", Database.UserData.id.ToString(), 0, 2), InputCurrentPassword.Text))
            {
                //checks if the new passwords are valid by calling on the IsPasswordValid
                if(Functions.Validation.IsPasswordValid(InputNewPassword.Text, InputConfirmPassword.Text))
                {
                    ChangeUserPassword();   //calls on a function to change the user's password
                    MessageBox.Show("Password changed.");
                    Close();    //closes this form
                }
            }
        }

        private void ChangeUserPassword()
        {
            //sets the new data for the user's record including the new password (passed through the hash algorithm)
            string[] data = { Database.UserData.username, Functions.HashAlgorithm.HashPassword(InputNewPassword.Text), Database.UserData.accessLevel, Database.UserData.team };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.UserData.id.ToString() };
            Functions.FileEdit.EditLine("userAccountDetails", 5, data, searchIndex, searchData);    //edits the table to change the user's password
        }

        private void EventNavCancel_Click(object sender, EventArgs e)
        {
            Close();    //closes this form
        }
    }
}
