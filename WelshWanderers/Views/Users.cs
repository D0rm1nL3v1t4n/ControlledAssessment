using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            TableManageUsers.MultiSelect = false;
            InputAccessLevel.SelectedItem = "All";
            LoadTableData();
        }
        
        private void LoadTableData()
        {
            StreamReader fileA = new StreamReader("userAccountDetails.txt");
            StreamReader fileB = new StreamReader("userPersonalDetails.txt");
            string lineA;
            string lineB;
            while (null != (lineA = fileA.ReadLine()) && null != (lineB = fileB.ReadLine()))
            {
                string[] sectionA = lineA.Split('|');
                string[] sectionB = lineB.Split('|');
                if (sectionA[3] == InputAccessLevel.Text || InputAccessLevel.Text == "All")
                {
                    if ((sectionB[2] + " " + sectionB[3]).ToLower().Contains(InputName.Text.ToLower()) || InputName.Text == "")
                    {
                        if (sectionA[1] != "masteradmin")
                            TableManageUsers.Rows.Add(sectionA[0], sectionA[1], sectionB[2], sectionB[3], sectionA[3], sectionA[4]);
                    }
                }
            }
            fileA.Close();
            fileB.Close();
        }

        private void EventFilter_Click(object sender, EventArgs e)
        {
            TableManageUsers.Rows.Clear();
            LoadTableData();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            if (Application.OpenForms["DeleteUserConfirm"] == null)
            {
                new Home().Show();
                Close();
            }
            else
            {
                MessageBox.Show("A Delete User Confirm form is current open.\nTo exit the this form, close the open Delete User Confirm form first.");
            }
        }

        private void NavView_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DeleteUserConfirm"] == null)
            {
                try
                {
                    new ViewUser(TableManageUsers.SelectedRows[0].Cells[0].Value.ToString()).Show();
                    Close();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Select a user to view.");
                }
            }
            else
            {
                MessageBox.Show("A Delete User Confirm form is current open.\nTo view a user, close the open Delete User Confirm form first.");
            }
        }

        private void EventDelete_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DeleteUserConfirm"] == null)
            {
                try
                {
                    new Views.DeleteUserConfirm(TableManageUsers.SelectedRows[0].Cells[0].Value.ToString()).Show();
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Select a user to delete.");
                }
            }
            else
            {
                MessageBox.Show("This form is already open.\nClose it down to open another.");
            }
        }
    }
}
