using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualCSharp.Forms.Sub_home_Screens.Shared_sub_Screens
{
    public partial class ViewMatches : Form
    {
        public ViewMatches()
        {
            InitializeComponent();
        }

        private void ViewMatches_Load(object sender, EventArgs e)
        {
            HideButtons();
            TableViewMatches.MultiSelect = false;
            StreamReader matchDetailsFile = new StreamReader("matchDetails.txt");
            string line = matchDetailsFile.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');
                TableViewMatches.Rows.Add(
                    section[0], section[1], section[2],
                    section[3], section[4], section[5], 
                    section[6], section[7]);
                line = matchDetailsFile.ReadLine();
            }
        }
        
        private void HideButtons()
        {
            if (UserData.userLevel == "Player")
            {
                BtnEditMatch.Hide();
                BtnAddResults.Hide();
            }
        }

        private void BtnEditMatch_Click(object sender, EventArgs e)
        {
            MatchData.matchID = TableViewMatches.SelectedRows[0].Cells[0].Value.ToString();
            MatchData.matchType = TableViewMatches.SelectedRows[0].Cells[1].Value.ToString();
            MatchData.opponent = TableViewMatches.SelectedRows[0].Cells[2].Value.ToString();
            MatchData.teamType = TableViewMatches.SelectedRows[0].Cells[3].Value.ToString();
            MatchData.dateAndTime = TableViewMatches.SelectedRows[0].Cells[4].Value.ToString();
            MatchData.addressLine1 = TableViewMatches.SelectedRows[0].Cells[5].Value.ToString();
            MatchData.addressLine2 = TableViewMatches.SelectedRows[0].Cells[6].Value.ToString();
            MatchData.postcode = TableViewMatches.SelectedRows[0].Cells[7].Value.ToString();

            new Forms.Sub_home_Screens.Coach_sub_Screens.EditMatchForm().Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (UserData.userLevel == "Player")
            {
                new Forms.playerHomeForm().Show();
            }
            else if (UserData.userLevel == "Coach")
            {
                new Forms.coachHomeForm().Show();
            }
            this.Hide();
        }

        private void BtnAddResults_Click(object sender, EventArgs e)
        {
            MatchData.matchID = TableViewMatches.SelectedRows[0].Cells[0].Value.ToString();
            MatchData.opponent = TableViewMatches.SelectedRows[0].Cells[2].Value.ToString();
            new Forms.Sub_home_Screens.Coach_sub_Screens.AddResultForm().Show();
            this.Hide();
        }
    }
}
