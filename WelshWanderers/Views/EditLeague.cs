using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers.Views
{
    public partial class EditLeague : Form
    {
        public EditLeague()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            NavToManageLeagues();   //Navigation to Leagues form
        }

        private void NavToManageLeagues()
        {
            new ManageLeagues().Show(); //Shows Leagues form
            Close();    //closes this form
        }

        private void EditLeague_Load(object sender, EventArgs e)
        {
            LoadLeagueData();   //calls on function to load the data for this league
        }

        private void LoadLeagueData()
        {
            //shows the data for this league in the input boxes
            InputName.Text = Database.LeagueData.name;
            InputTeam.Text = Database.LeagueData.team;
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true && CreateLeagueFile(InputName.Text) == false) //checks validation of inputs and the league doesn't already exist
            {
                EditLeagueData();   //calls on function to edit the league's data
                RenameLeague();     //calls on function to rename the league's file
                NavToManageLeagues();   //Navigation to Leagues form
            }
        }

        private void RenameLeague()
        {
            File.Move(@"Leagues\" + Database.LeagueData.name + ".txt", @"Leagues\" + InputName.Text + ".txt");  //changes the name for the leauge's file
        }

        private void EditLeagueData()
        {
            string[] data = { InputName.Text, InputTeam.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.LeagueData.id.ToString() };
            Functions.FileEdit.EditLine("leagues", 3, data, searchIndex, searchData);   //edits the file to change the data for the league
            MessageBox.Show("Changes have been saved.");
        }

        private bool CreateLeagueFile(string fileName)
        {
            string path = @"Leagues\" + fileName + ".txt";
            if (!File.Exists(path)) //checks if league already exists
            {
                var file = File.Create(path);   //creates file path if league doesn't exist
                file.Close();
                return false;   //returns false if league doesn't exist
            }
            else
            {
                MessageBox.Show("A league by that name already exists.\nName the league differently or delete that exisiting league before continuing.");
                return true;    //returns true if league does exist
            }
        }
         
        private bool ValidInputs()
        {
            bool name = ValidName();    //check validation for league name
            bool team = ValidTeam();    //check validation for league team
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
                return true;    //returns true if validation passes
            MessageBox.Show("Select a team.");
            return false;       //returns false if validation fails
        }
    }
}
