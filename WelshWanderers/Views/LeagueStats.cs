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

namespace WelshWanderers
{
    public partial class LeagueStats : Form
    {
         public LeagueStats()
        {
            InitializeComponent();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new Home().Show();
            Hide();
        }

        private void LeagueStats_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GetAllLeagues();
            LoadAllPlayers();
        }

        private void GetAllLeagues()
        {
            StreamReader file = new StreamReader("leagues.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                InputLeague.Items.Add(section[1]);
                InputLeagueFile.Items.Add(section[2]);
            }
        }

        private void LoadAllPlayers()
        {
            string leagueFileName = InputLeagueFile.SelectedItem.ToString();
            StreamReader file = new StreamReader(@"Leagues\" + leagueFileName);   //Work out which file to read
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                string[] playerName = Functions.FileSearch.ReturnLine("userPersonalDetails", section[0], 0).Split('|');
                TableLeagueStats.Rows.Add(section[0], playerName[2] + " " + playerName[3], section[1], section[2], section[3]);
            }
            TableLeagueStats.Sort(ColPlayed, ListSortDirection.Ascending);
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllPlayers();
        }


    }
}
