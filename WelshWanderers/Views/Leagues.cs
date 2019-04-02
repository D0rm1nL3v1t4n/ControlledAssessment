using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class ManageLeagues : Form
    {
        public ManageLeagues()
        {
            InitializeComponent();
        }

        private void ManageLeagues_Load(object sender, EventArgs e)
        {
            TableViewLeagues.MultiSelect = false;   //allows the user to only select one row in the table at a time
            LoadAllLeagues();   //calls on a function to load all the leagues from the file
        }
        
        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();    //Navigation to Home form
        }

        private void EventNavCreate_Click(object sender, EventArgs e)
        {
            new Views.CreateLeague().Show();    //shows Create League form
            Close();    //closes this form
        }

        private void EventNavEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SaveLeagueDatabase();   //calls on function to change variables
                new Views.EditLeague().Show();  //shows the Edit League form
                Close();    //closes this form
            }
            catch (ArgumentOutOfRangeException) //catches an error (if the user doesn't select a row when they click the button)
            {
                MessageBox.Show("Select a league to edit.");
            }
        }

        private void SaveLeagueDatabase()
        {
            //changes the variables to the data in the row that the user selected
            Database.LeagueData.id = Convert.ToInt16(TableViewLeagues.SelectedRows[0].Cells[0].Value);
            Database.LeagueData.name = TableViewLeagues.SelectedRows[0].Cells[1].Value.ToString();
            Database.LeagueData.team = TableViewLeagues.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void EventDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //Message box with Yes No buttons to ask if the user is sure they want to premanently delete the league
                if (MessageBox.Show("Are you sure? This league and all its data will be permanently deleted.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteLeague(); //calls on a function to delete the league
                }
            }
            catch (ArgumentOutOfRangeException) //catches an error (if the user doesn't select a row when they click the button)
            {
                MessageBox.Show("Select a league to delete.");
            }
        }

        private void DeleteLeague()
        {
            string fileName = TableViewLeagues.SelectedRows[0].Cells[1].Value.ToString();   //gets the name of the league
            //deletes the record for that league in the leagues file
            Functions.FileDelete.RemoveLine("leagues", 3, Functions.FileSearch.LineNumber("leagues", TableViewLeagues.SelectedRows[0].Cells[0].Value.ToString(), 0));
            File.Delete(@"Leagues\" + fileName + ".txt");   //deletes the directory path with that file's name
            MessageBox.Show("League has been deleted.");
            TableViewLeagues.Rows.RemoveAt(TableViewLeagues.SelectedRows[0].Index); //removes league from table
        }

        private void LoadAllLeagues()
        {
            StreamReader file = new StreamReader("leagues.txt");    //opens file with read access
            string line;    
            while (null != (line = file.ReadLine()))    //reads file line at a time until line is empty
            {
                string[] section = line.Split('|'); //splits contents of each record into individual cells
                TableViewLeagues.Rows.Add(section[0], section[1], section[2]);  //adds a row to the table
            }
            file.Close();
        }

        private void NavToHome()
        {
            new Home().Show();  //shows the Home form
            Close();    //closes this form
        }

        
    }
}
