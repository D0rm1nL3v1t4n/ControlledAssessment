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
    public partial class ViewUser : Form
    {
        private static string userID = "-1";
        private static string password = "";
        private static string accessLevel = "";
        private static string team = "";

        private class Changes
        {
            public static int count = 0;
            public static bool accessLevel = false;
            public static bool team = false;
        }

        public ViewUser(string id)
        {
            InitializeComponent();
            userID = id;
        }

        private void ViewUser_Load(object sender, EventArgs e)
        {
            LoadUserData();
            EditOff();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    NavToManageUsers();
                return;
            }
            NavToManageUsers();
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)
            {
                ChangeData();
                MessageBox.Show("User details have been updated.");
            }
            else
            {
                MessageBox.Show("You have not made any changes.");
            }
        }

        private void ChangeData()
        {
            string newTeam = InputTeam.Text;
            if (accessLevel == "Player" && accessLevel != InputAccessLevel.Text)
                newTeam = "";
            string[] data = { InputUsername.Text, password, InputAccessLevel.Text, newTeam };
            int[] searchIndex = { 0 };
            string[] searchData = { userID };
            Functions.FileEdit.EditLine("userAccountDetails", 5, data, searchIndex, searchData);
        }

        private void NavToManageUsers()
        {
            new ManageUsers().Show();
            Hide();
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            EditOff();
        }

        private void EventEdit_Click(object sender, EventArgs e)
        {
            EditOn();
        }

        private void LoadUserData()
        {
            string[] data = GetData();
            ShowData(data);
        }

        private string[] GetData()
        {
            string personalDetails = Functions.FileSearch.ReturnLine("userPersonalDetails", userID, 0);
            string accountDetails = Functions.FileSearch.ReturnLine("userAccountDetails", userID, 0);
            string dataLine = personalDetails + accountDetails;
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
            password = data[10];
            accessLevel = data[11];
            team = data[12];
        }

        private void ReloadData()
        {
            InputAccessLevel.Text = accessLevel;
            InputTeam.Text = team;
        }

        private void EditOn()
        {
            InputAccessLevel.Enabled = true;
            InputTeam.Enabled = true;
            EventEdit.Hide();
            EventCancelEdit.Show();
            EventSave.Show();
            LabelChangesMade.Show();
            LabelChangesMade.Text = "No Changes";
        }

        private void EditOff()
        {
            InputAccessLevel.Enabled = false;
            InputTeam.Enabled = false;
            EventEdit.Show();
            EventCancelEdit.Hide();
            EventSave.Hide();
            ReloadData();
            LabelChangesMade.Hide();
        }

        private void ShowChangesMade()
        {
            LabelChangesMade.Text = Changes.count + " change(s)\nmade.";
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)
            {
                ++Changes.count;
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)
            {
                --Changes.count;
                return false;
            }
            ShowChangesMade();
            return changedVal;
        }

        private void InputAccessLevel_TextChanged(object sender, EventArgs e)
        {
            Changes.accessLevel = DetailsChanged(InputAccessLevel.Text, accessLevel, Changes.accessLevel);
        }

        private void InputTeam_TextChanged(object sender, EventArgs e)
        {
            Changes.team = DetailsChanged(InputTeam.Text, team, Changes.team);
        }
    }
}
