using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class MatchAvailability : Form
    {
        public MatchAvailability()
        {
            InitializeComponent();
        }

        private void MatchAvailability_Load(object sender, EventArgs e)
        {
            ColAvailability.ReadOnly = false;   
            FillTableData();    //calls on function to fill the data into the tabke
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("matchDetails.txt");   //opens the file with read access
            string line;
            while (null != (line = file.ReadLine()))    //loops through the file reading one line at a time until line is empty
            {
                string[] sectionA = line.Split('|');    //splits the data into individual components
                //searching for the match availability for this player for this match
                string sectionB = Functions.FileSearch.ManyToMany("matchAvailability", sectionA[0], 0, Database.UserData.id.ToString(), 1);
                if (sectionB != null)   //checks if player is part of the match
                {
                    string[] sectionC = sectionB.Split('|');
                    if (Convert.ToDateTime(sectionA[3]) >= DateTime.Now)    //checks that the match is in the future
                    {   //adds a row to the table with the user's availability status
                        TableMatchAvailability.Rows.Add(sectionA[0], sectionA[1], sectionA[2], sectionA[3], sectionA[4] + ":" + sectionA[5], sectionC[2]);
                    }
                }
            }
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            //Message box with Yes No buttons to check if user wants to continue even though changes may be lost
            if (MessageBox.Show("Any changes that haven't been saved will be lost. Continue?", "Unsaved changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Application.OpenForms["ViewMatch"] != null) //checks if View Match form is open
                {
                    Application.OpenForms["ViewMatch"].Close(); //closes View Match form if open
                }
                NavToHome();    //Navigation to Home form
            }
        }

        private void NavToHome()
        {
            new Home().Show();  //shows Home form
            Close();    //hides this form
        }

        private void EventMatchDetails_Click(object sender, EventArgs e)
        {
            try
            {
                StoreMatchDetails();    //calls on function to save details of match to database variables
                if (Application.OpenForms["ViewMatch"] == null) //checks if View Match form is open
                {
                   new ViewMatch("Match Availability").Show();  //shows View Match form
                }
                else
                {
                    MessageBox.Show("That form is already open.");
                }
            }
            catch (ArgumentOutOfRangeException) //catches potential error
            {
                MessageBox.Show("Please select a match to view."); 
            }            
        }

        private void StoreMatchDetails()
        {
            //changes the database matchdata variables to be those of the match being selected
            Database.MatchData.id = Convert.ToInt16(TableMatchAvailability.SelectedRows[0].Cells[0].Value);
            string[] section = Functions.FileSearch.ReturnLine("matchDetails", Database.MatchData.id.ToString(), 0).Split('|');
            Database.MatchData.league = section[1];
            Database.MatchData.opponent = section[2];
            Database.MatchData.date = section[3];
            Database.MatchData.timeH = Convert.ToInt16(section[4]);
            Database.MatchData.timeM = Convert.ToInt16(section[5]);
            Database.MatchData.addressLineA = section[6];
            Database.MatchData.addressLineA = section[7];
            Database.MatchData.postcode = section[8];
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableMatchAvailability.Rows.Count; ++i) //loops through each row in the table
            {   //searches for the current avaibility for the player for this match 
                string[] section = Functions.FileSearch.ManyToMany("matchAvailability", Database.UserData.id.ToString(), 1, TableMatchAvailability.Rows[i].Cells[0].Value.ToString(), 0).Split('|');
                if (section[2] != TableMatchAvailability.Rows[i].Cells[5].Value.ToString()) //checks if their availability has changed
                {
                    EditAvailability(i);    //if their availability has changed calls on function to edit the file
                }
            }
            MessageBox.Show("Updates saved.");

            if (Application.OpenForms["ViewMatch"] != null) //checks if View Match form is open
                Application.OpenForms["ViewMatch"].Close(); //closes View Match form if open
            NavToHome();    //Navigation to Home form
        }

        private void EditAvailability(int i)
        {
            string[] data = { TableMatchAvailability.Rows[i].Cells[5].Value.ToString() };
            int[] searchIndex = { 0, 1 };
            string[] searchData = { TableMatchAvailability.Rows[i].Cells[0].Value.ToString(), Database.UserData.id.ToString() };
            Functions.FileEdit.EditLine("matchAvailability", 3, data, searchIndex, searchData); //edits record to update for new availability
        }
    }
}
