using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers.Views
{
    public partial class CreateLeague : Form
    {
        public CreateLeague()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            //Message box with Yes No buttons to check if the user wants to exit the form even though the league will not be created
            if (MessageBox.Show("Are you sure? League will not be created.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToManageLeagues();   //Navigation to the Leagues form
            }
        }

        private void NavToManageLeagues()
        {
            new ManageLeagues().Show(); //Shows the Leagues form
            Close();    //Closes this form
        }

        private void EventNavCreate_Click(object sender, EventArgs e)
        {
            string fileName = InputName.Text;
            if (ValidInputs() == true && CreateLeagueFile(fileName) == false)   //checks that the inputs are valid and if a league already exists
            {
                SaveLeague(fileName);   //saves the league's data
                MessageBox.Show("League created.");
                NavToManageLeagues();   //Navigation to Leagues form
            }
        }

        private void SaveLeague(string fileName)
        {
            string line = Functions.FileSearch.GetNextId("leagues").ToString() + "|" + fileName + "|" + InputTeam.Text + "|";   //data for the league including its id using GetNextId function
            Functions.FileWrite.WriteData("leagues", line); //writes the data to the table
        }

        private bool CreateLeagueFile(string fileName)
        {
            string path = @"Leagues\" + fileName + ".txt";
            if (!File.Exists(path)) //checks if the path for the league already exists
            {
                var file = File.Create(path);   //creates the file if it doesn't exist
                file.Close();
                return false;   //returns false if file doesn't exist
            }
            else
            {
                MessageBox.Show("A league by that name already exists.\nName the league differently or delete that exisiting league before continuing.");
                return true;    //returns true if file does already exist
            }

        }

        private bool ValidInputs()
        {
            bool name = ValidName();    //checks name is valid
            bool team = ValidTeam();    //checks team is valid
            return name && team;
        }

        private bool ValidName()
        {
            if (InputName.Text.Length <= 30 && InputName.Text.Length >= 5)  //range check
                return true;    //returns true if validation passes
                MessageBox.Show("League name must be between 5 and 30 characters.");
            return false;   //returns false if validation fails
        }

        private bool ValidTeam()
        {
            if (InputTeam.Text.Length > 0)  //presence check
                return true;       //returns true if validation passes
            MessageBox.Show("Select a team.");
            return false;   //returns false if validation fails
        }

    }
}
