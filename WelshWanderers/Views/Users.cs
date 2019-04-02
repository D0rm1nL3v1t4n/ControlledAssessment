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
            TableManageUsers.MultiSelect = false;   //prevents the user from selecting more than one row in the table at a time
            InputAccessLevel.SelectedItem = "All";  //sets the selected value in the drop down box to 'All'
            LoadTableData();    //calls on function to load data into the table
        }
        
        private void LoadTableData()
        {
            StreamReader fileA = new StreamReader("userAccountDetails.txt");    //opens file with read access
            StreamReader fileB = new StreamReader("userPersonalDetails.txt");   //opens file with read access
            string lineA;
            string lineB;
            while (null != (lineA = fileA.ReadLine()) && null != (lineB = fileB.ReadLine()))    //reads both files one line at a time and checks lines are not empty
            {
                string[] sectionA = lineA.Split('|');   //splits line into individual components based on delimiter
                string[] sectionB = lineB.Split('|');   //splits line into individual components based on delimiter
                //checks that the user's access level is the same as the selected item in the drop down box
                if (sectionA[3] == InputAccessLevel.Text || InputAccessLevel.Text == "All") 
                {   //checks the user's name is the same as the name entered in the filter for the name
                    if ((sectionB[2] + " " + sectionB[3]).ToLower().Contains(InputName.Text.ToLower()) || InputName.Text == "")
                    {   //checks the user is not the masteradmin
                        if (sectionA[1] != "masteradmin")
                            //adds a row to the table with the user's data
                            TableManageUsers.Rows.Add(sectionA[0], sectionA[1], sectionB[2], sectionB[3], sectionA[3], sectionA[4]);
                    }
                }
            }
            fileA.Close();
            fileB.Close();
        }

        private void EventFilter_Click(object sender, EventArgs e)
        {
            TableManageUsers.Rows.Clear();  //clears all the data in the table
            LoadTableData();    //calls on function to load data into the table
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();    //navigation to Home form
        }

        private void NavToHome()
        {
            if (Application.OpenForms["DeleteUserConfirm"] != null) //checks if Delete User Confirm form is open
                Application.OpenForms["DeleteUserConfirm"].Close(); //if it is open, closes the Delete User Confirm form
            new Home().Show();  //shows Home form
            Close();    //closes this form
        }

        private void NavView_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["DeleteUserConfirm"] == null) //checks if Delete User Confirm form is open
            {
                try
                {
                    new ViewUser(TableManageUsers.SelectedRows[0].Cells[0].Value.ToString()).Show();    //shows the View User form
                    Close();    //hides this form
                }
                catch (ArgumentOutOfRangeException) //catches and prevents a potential error
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
            if (Application.OpenForms["DeleteUserConfirm"] == null) //checks if Delete User Confirm form is open
            {
                try
                {
                    new Views.DeleteUserConfirm(TableManageUsers.SelectedRows[0].Cells[0].Value.ToString()).Show(); //opens Delete User Confirm form
                }
                catch (ArgumentOutOfRangeException) //catches and prevents potential error
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
