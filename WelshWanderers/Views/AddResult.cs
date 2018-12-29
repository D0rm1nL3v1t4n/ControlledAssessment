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
            new WelshWanderers.UpcomingMatches().Show();
            this.Hide();
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
                string[] line = Functions.FileSearch.ReturnLine("userPersonalDetails", userIDs[i], 0).Split('|');
                TableAddMatchResult.Rows.Add(userIDs[i], line[2] + " " + line[3]);
            }
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            SavePlayerMatchData();
            SaveMatchResult();
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
            return id + "|" + goals + "|" + majorFouls + "|" + other + "|";
        }

        private void SaveMatchResult()
        {
            int totalGoals = GetGoals();
            int totalMajors = GetMajorFouls();
            string line = Database.MatchData.id + "|" + totalGoals + "|" + InputOpponentGoals.Text + "|" + totalMajors + "|" + InputOpponentMajorFouls.Text + "|";
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
    }
}
