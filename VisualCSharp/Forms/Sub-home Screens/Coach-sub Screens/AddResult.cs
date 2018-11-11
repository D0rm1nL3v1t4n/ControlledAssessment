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

namespace VisualCSharp.Forms.Sub_home_Screens.Coach_sub_Screens
{
    public partial class AddResultForm : Form
    {
        public AddResultForm()
        {
            InitializeComponent();
        }

        private void AddResultForm_Load(object sender, EventArgs e)
        {
            ShowOpponentName();
            AddPlayers();
        }

        private void ShowOpponentName()
        {
            grpbxOpponentStats.Text = MatchData.opponent + "'s stats";
        }

        private void AddPlayers()
        {
            StreamReader matchDetailsFile = new StreamReader("matchDetails.txt");
            string line = matchDetailsFile.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');
                if (section[0] == MatchData.matchID)
                {
                    string[] playerIDList = section[8].Split(new[] {','}, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string id in playerIDList)
                    {
                        if (null != id)
                        {
                            string playerName = GetPlayerName(id);
                            TableAddResult.Rows.Add(id, playerName);
                        }
                    }
                }
                line = matchDetailsFile.ReadLine();
            }
            matchDetailsFile.Close();
        }

        private string GetPlayerName(string id)
        {
            StreamReader playerStatsFile = new StreamReader("playerStats.txt");
            string line = playerStatsFile.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');

                if (id == section[1])
                {
                    playerStatsFile.Close();
                    return section[2] + " " + section[3];
                }

                line = playerStatsFile.ReadLine();
            }
            playerStatsFile.Close();
            return null;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Match Result will not be added.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReturnViewMatches();
            }
        }

        private void ReturnViewMatches()
        {
            new Forms.Sub_home_Screens.Shared_sub_Screens.ViewMatches().Show();
            this.Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int rowCount = TableAddResult.Rows.Count;
            string playersList = "";
            
            int sumMajors = 0;
            int sumGoals = 0;
            for (int i = 0; i < rowCount; ++i)
            {
                var majorsCol = TableAddResult.Rows[i].Cells[4].Value;
                if (!(null == majorsCol || 0 == System.Convert.ToInt16(majorsCol)))
                    sumMajors += System.Convert.ToInt16(majorsCol);

                var goalsCol = TableAddResult.Rows[i].Cells[3].Value;
                if (!(null == goalsCol || 0 == System.Convert.ToInt16(goalsCol)))
                    sumGoals += System.Convert.ToInt16(goalsCol);

                var namesCol = TableAddResult.Rows[i].Cells[1].Value;
                if (!(null == namesCol))
                    playersList += namesCol + ",";
            }





            using (System.IO.StreamWriter matchStatsFile =
                new System.IO.StreamWriter("matchStats.txt", true))
            {
                matchStatsFile.WriteLine(
                    MatchData.matchID + "|" + sumGoals + "|" +
                    txtOpponentGoals.Text + "|" + sumMajors + "|" + 
                    txtOpponentMajors.Text + "|" + playersList + "|");
            }



            ReturnViewMatches();
        }

    }
}
