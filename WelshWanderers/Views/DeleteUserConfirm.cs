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
    public partial class DeleteUserConfirm : Form
    {
        public static string userID;
        public DeleteUserConfirm(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void DeleteUserConfirm_Load(object sender, EventArgs e)
        {
            LoadDataToDelete();
        }

        private void LoadDataToDelete()
        {
            string[] data = GetData();
            ShowData(data);
        }

        private string[] GetData()
        {
            string dataLine = "";
            dataLine += Functions.FileSearch.ReturnLine("userPersonalDetails", userID, 0);
            dataLine += Functions.FileSearch.ReturnLine("userAccountDetails", userID, 0);
            string[] data = dataLine.Split('|');
            return data;
        }

        private void ShowData(string[] data)
        {
            InputId.Text = data[0];
            InputTitle.Text = data[1];
            InputFirstName.Text = data[2];
            InputLastName.Text = data[3];
            InputDateOfBirth.Text = data[4];
            InputEmailAddress.Text = data[5];
            InputTelephoneNumber.Text = data[6];
            InputPostcode.Text = data[7];
            InputUsername.Text = data[9];
            InputAccessLevel.Text = data[11];
            InputTeam.Text = data[12];
        }

        private void EventNavDeleteUser_Click(object sender, EventArgs e)
        {
            if (ValidInputs())
            {
                AlertUser();
                DeleteUserData();
            }
        }

        private void AlertUser()
        {
            string[] email = { InputEmailAddress.Text };
            string team = "";
            if (InputTeam.Text != null)
                team = ", " + InputTeam.Text;
            string body = "The following account has been removed from the Welsh Wanderers Waterpolo club system:\n- " + InputFirstName.Text + " " + InputLastName.Text + "\n- " + InputUsername.Text + "\n- " + InputAccessLevel.Text + team + "\n\nFor the following reason:\n" + InputReason.Text + "\n\nWelsh Wanderers.";
            Functions.SendEmail.Email("Account removed from system.", body, email);
        }

        private void DeleteUserData()
        {
            int lineNo = Functions.FileSearch.LineNumber("userAccountDetails", InputId.Text, 0);
            Functions.FileDelete.RemoveLine("userAccountDetails", 5, lineNo);
            Functions.FileDelete.RemoveLine("userPersonalDetails", 8, lineNo);
        }

        private bool ValidInputs()
        {
            if (ValidReason() == true && ValidName() == true && ValidPassword() == true)
                return true;
            return false;
        }

        private bool ValidReason()
        {
            if (InputReason.Text != "")
                return true;
            MessageBox.Show("Enter a reason for user being deleted from the system.");
            return false;
        }

        private bool ValidName()
        {
            if (InputName.Text == (InputFirstName.Text.ToLower() + " " + InputLastName.Text.ToLower()))
                return true;
            MessageBox.Show("Name entered does not match the name of the user.");
            return false;
        }
        
        private bool ValidPassword()
        {
            if (Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("userAccountDetails", InputUsername.Text.ToLower(), 1, 2, false), InputPassword.Text) == true)
                return true;
            return false;
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
