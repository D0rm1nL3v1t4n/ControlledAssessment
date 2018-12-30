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
        private static string[,] allLeagues;

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
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        private void LeagueStats_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            GetAllLeagues();
            ShowLeagues();
            LoadAllPlayers();
        }

        private void ShowLeagues()
        {
            foreach (string league in allLeagues)
                InputLeague.Items.Add(league[0]);
        }

        private void GetAllLeagues()
        {
            StreamReader file = new StreamReader("leagues.txt");
            string line;
            int i = 0;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                allLeagues[i,0] = section[1];
                allLeagues[i,1] = section[2];
                ++i;
            }
        }

        private void LoadAllPlayers()
        {
            string leagueFileName = allLeagues[InputLeague.SelectedIndex, 0];
            StreamReader file = new StreamReader(@"Leagues\" + leagueFileName);   //Work out which file to read
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                
            }
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
