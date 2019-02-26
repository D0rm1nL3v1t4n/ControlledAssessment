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
    public partial class AddResult : Form
    {
        public AddResult()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Match Result will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToViewMatches();
            }
        }

        private void NavToViewMatches()
        {
            new UpcomingMatches().Show();
            Close();
        }

        private void AddResult_Load(object sender, EventArgs e)
        {
            ShowOpponentName();
            AddPlayers();
        }

        private void ShowOpponentName()
        {
            InputOpponent.Text = Database.MatchData.opponent;
        }

        private void AddPlayers()
        {
            string[] userIDs = Functions.FileSearch.ReturnSegment("matchAvailability", Database.MatchData.id.ToString(), 0, 1, true).Split('|');
            for (int i = 0; i < userIDs.Length; ++i)
            {
                if (Functions.FileSearch.ReturnSegment("matchAvailability", userIDs[i], 1, 2) == "Yes")
                {
                    string[] line = Functions.FileSearch.ReturnLine("userPersonalDetails", userIDs[i], 0).Split('|');
                    TableAddMatchResult.Rows.Add(userIDs[i], line[2] + " " + line[3], "0", "0", "None");
                }
            }
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            SavePlayerMatchData();
            SaveMatchResult();
            SaveLeagueData();
            NavToViewMatches();
        }

        private void SavePlayerMatchData()
        {
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)
            {
                Functions.FileWrite.WriteData("playerMatchStats", GetUserStats(i));
            }
        }

        private string GetUserStats(int i)
        {
            string id = TableAddMatchResult.Rows[i].Cells[0].Value.ToString();
            string goals = TableAddMatchResult.Rows[i].Cells[2].Value.ToString();
            string majorFouls = TableAddMatchResult.Rows[i].Cells[3].Value.ToString();
            string other = TableAddMatchResult.Rows[i].Cells[4].Value.ToString();
            return Database.MatchData.id.ToString() + "|" + id + "|" + goals + "|" + majorFouls + "|" + other + "|";
        }

        private void SaveMatchResult()
        {
            int totalGoals = GetGoals();
            int totalMajors = GetMajorFouls();
            string line = Database.MatchData.id + "|" + totalGoals + "|" + InputOpponentGoals.Text + "|" + totalMajors + "|" + InputOpponentMajorFouls.Text + "|";
            Functions.FileWrite.WriteData("matchStats", line);
        }

        private int GetGoals()
        {
            int total = 0;
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)
            {
                var goals = TableAddMatchResult.Rows[i].Cells[2].Value;
                if (!(null == goals || 0 == System.Convert.ToInt16(goals)))
                    total += System.Convert.ToInt16(goals);
            }
            return total;
        }

        private int GetMajorFouls()
        {
            int total = 0;
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)
            {
                var majors = TableAddMatchResult.Rows[i].Cells[3].Value;
                if (!(null == majors || 0 == System.Convert.ToInt16(majors)))
                    total += System.Convert.ToInt16(majors);
            }
            return total;
        }

        private void SaveLeagueData()
        {
            MessageBox.Show(Database.MatchData.league);
            for (int i = 0; i < TableAddMatchResult.Rows.Count; ++i)
            {
                string line;
                int played = 1;
                int goals = Convert.ToInt16(TableAddMatchResult.Rows[i].Cells[2].Value.ToString());
                int majors = Convert.ToInt16(TableAddMatchResult.Rows[i].Cells[3].Value.ToString());
                if (null != (line = Functions.FileSearch.ReturnLine(@"Leagues\" + Database.MatchData.league, TableAddMatchResult.Rows[i].Cells[0].Value.ToString(), 0)))
                {
                    string[] section = line.Split('|');
                    played += Convert.ToInt16(section[1]);
                    goals += Convert.ToInt16(section[2]);
                    majors += Convert.ToInt16(section[3]);
                    string[] data = { played.ToString(), goals.ToString(), majors.ToString() };
                    int[] searchIndex = { 0 };
                    string[] searchData = { TableAddMatchResult.Rows[i].Cells[0].Value.ToString() };
                    Functions.FileEdit.EditLine(@"Leagues\" + Database.MatchData.league, 4, data, searchIndex, searchData);
                }
                else
                {
                    string data = TableAddMatchResult.Rows[i].Cells[0].Value.ToString() + "|" + played + "|" + goals + "|" + majors + "|";
                    Functions.FileWrite.WriteData(@"Leagues\" + Database.MatchData.league, data);
                }
            }
        }
    }
}
