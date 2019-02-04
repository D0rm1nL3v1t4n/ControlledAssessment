using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //Check current password is correct
            if (Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("userAccountDetails", Database.UserData.id.ToString(), 0, 2), InputCurrentPassword.Text))
            {
                //Check new password is valid (and equal to confirm password)d
                if(Functions.ValidPassword.IsPasswordValid(InputNewPassword.Text, InputConfirmPassword.Text))
                {
                    //Edit line in userAccountDetails to save the new, hashed password
                    string[] data = { Database.UserData.username, Functions.HashAlgorithm.HashPassword(InputNewPassword.Text), Database.UserData.accessLevel, Database.UserData.team };
                    int[] searchIndex = { 0 };
                    string[] searchData = { Database.UserData.id.ToString() };
                    Functions.FileEdit.EditLine("userAccountDetails", 5, data, searchIndex, searchData);
                }
            }
        }

    }
}
