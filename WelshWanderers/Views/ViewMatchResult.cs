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
    public partial class ViewMatchResult : Form
    {
        public ViewMatchResult()
        {
            InitializeComponent();
        }

        private void ViewMatchResult_Load(object sender, EventArgs e)
        {
            HideEditButton();
            LoadData();
            GetPlayersData();
        }

        private void HideEditButton()
        {
            if (Database.UserData.accessLevel == "Player")
                EventEditMatchResult.Hide();
            EventSave.Hide();
            EventCancelEdit.Hide();
        }

        private void GetPlayersData()
        {
            string[] playerIDs = Functions.FileSearch.ReturnSegment("playerMatchStats", Database.MatchData.id.ToString(), 0, 1, true).Split('|');

            for (int i = 0; i < playerIDs.Length; ++i)
            {
                string[] name = Functions.FileSearch.ReturnLine("userPersonalDetails", playerIDs[i], 0).Split('|');
                string[] stats = Functions.FileSearch.ManyToMany("playerMatchStats", Database.MatchData.id.ToString(), 0, playerIDs[i], 1).Split('|');
                TableMatchResult.Rows.Add(playerIDs[i], name[2] + " " + name[2], stats[3], stats[4], stats[5]);
            }
        }

        private void LoadData()
        {
            string[] line = Functions.FileSearch.ReturnLine("matchStats", Database.MatchData.id.ToString(), 0).Split('|');
            InputOpponent.Text = Database.MatchData.opponent;
            InputWanderersGoals.Text = line[1];
            InputOpponent.Text = line[2];
            InputWanderersMajors.Text = line[3];
            InputOpponentMajorFouls.Text = line[4];
        }

        private void EventEditMatchResult_Click(object sender, EventArgs e)
        {
            InputWanderersGoals.Enabled = true;
            InputOpponentGoals.Enabled = true;
            InputWanderersMajors.Enabled = true;
            InputOpponentMajorFouls.Enabled = true;
            TableMatchResult.Enabled = true;
            EventEditMatchResult.Hide();
            EventSave.Show();
            EventCancelEdit.Show();
        }
    }
}
