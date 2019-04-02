using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers.Views
{
    public partial class ViewMatchAvailability : Form
    {
        public ViewMatchAvailability()
        {
            InitializeComponent();
        }

        private void ViewMatchAvailability_Load(object sender, EventArgs e)
        {
            StreamReader fileMatch = new StreamReader("matchAvailability.txt"); //opens file with read access
            string line;
            while ((line = fileMatch.ReadLine()) != null)   //loops through file reading one line at a time as long as line isn't empty
            {
                string[] sectionA = line.Split('|');    //splits line into individual components based on the delimiter
                if (sectionA[0] == Database.MatchData.id.ToString())    //checks the id is that of the user's
                {   //calls on function to return line and splits it based on the delimiter
                    string[] sectionB = Functions.FileSearch.ReturnLine("userPersonalDetails", sectionA[1], 0).Split('|');
                    bool availabilityState = false;
                    bool responded = false;
                    if (sectionA[2] != "")  //checks if the user has responded
                        responded = true;
                    if (sectionA[2] == "Yes")   //checks if the user has said 'Yes'
                        availabilityState = true;
                    //adds row to the table
                    TableMatchAvailability.Rows.Add(sectionA[1], sectionB[2], sectionB[3], responded, availabilityState);
                }
            }
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            new UpcomingMatches().Show();   //shows Upcoming Matches form
            Close();    //closes this form
        }
    }
}
