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
            GetAllLeagues();
            InputSortBy.SelectedItem = "Name";
        }

        private void GetAllLeagues()
        {
            InputLeague.Items.Add("All");
            StreamReader file = new StreamReader("leagues.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                InputLeague.Items.Add(section[1]);
            }
            InputLeague.SelectedItem = "All";
        }

        private void LoadAllPlayers()
        {
            List<string> allLeagues = new List<string>();
            if (InputLeague.SelectedItem.ToString() == "All")
            {
                foreach (string item in InputLeague.Items)
                {
                    if (item != "All")
                        allLeagues.Add(item);
                }
            }
            else
            {
                allLeagues.Add(InputLeague.SelectedItem.ToString());
            }

            foreach (string leagueFileName in allLeagues)
            {
                StreamReader file = new StreamReader(@"Leagues\" + leagueFileName + ".txt");   //Works out which file to read
                string line;
                while (null != (line = file.ReadLine()))
                {
                    string[] section = line.Split('|'); // 0:id, 1:played, 2:goals, 3:majors
                    string[] playerName = Functions.FileSearch.ReturnLine("userPersonalDetails", section[0], 0).Split('|');
                    for (int i = 0; i < TableLeagueStats.Rows.Count; ++i)
                    {
                        if (TableLeagueStats.Rows[i].Cells[0].Value.ToString() == section[0])   //Compares to see if id already exists
                        {
                            TableLeagueStats.Rows[i].Cells[2].Value = (Convert.ToInt16(TableLeagueStats.Rows[i].Cells[2].Value) + Convert.ToInt16(section[1])).ToString();  //games played
                            TableLeagueStats.Rows[i].Cells[3].Value = (Convert.ToInt16(TableLeagueStats.Rows[i].Cells[3].Value) + Convert.ToInt16(section[2])).ToString();  //goals
                            TableLeagueStats.Rows[i].Cells[4].Value = (Convert.ToInt16(TableLeagueStats.Rows[i].Cells[3].Value) / Convert.ToInt16(TableLeagueStats.Rows[i].Cells[2].Value)).ToString();   //average goals = goals/games played
                            TableLeagueStats.Rows[i].Cells[5].Value = (Convert.ToInt16(TableLeagueStats.Rows[i].Cells[5].Value) + Convert.ToInt16(section[3])).ToString();  //majors
                            TableLeagueStats.Rows[i].Cells[6].Value = (Convert.ToInt16(TableLeagueStats.Rows[i].Cells[5].Value) / Convert.ToInt16(TableLeagueStats.Rows[i].Cells[2].Value)).ToString();   //average majors = majors/games played
                        }
                        else
                        {
                            TableLeagueStats.Rows.Add(section[0], playerName[2] + " " + playerName[3], section[1], section[2],  (Convert.ToDouble(section[2]) / Convert.ToDouble(section[1])).ToString(), section[3], (Convert.ToDouble(section[3]) / Convert.ToDouble(section[1])).ToString());
                        }
                    }
                    if (TableLeagueStats.Rows.Count == 0)
                    {
                        TableLeagueStats.Rows.Add(section[0], playerName[2] + " " + playerName[3], section[1], section[2], (Convert.ToDouble(section[2]) / Convert.ToDouble(section[1])).ToString(), section[3], (Convert.ToDouble(section[3]) / Convert.ToDouble(section[1])).ToString());
                    }
                }
            }
        }

        private void InputLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableLeagueStats.Rows.Clear();
            LoadAllPlayers();
        }

        private void InputSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void InputDirection_CheckedChanged(object sender, EventArgs e)
        {
            Sort();
        }

        private void Sort()
        {
            int count = TableLeagueStats.Columns[InputSortBy.SelectedIndex + 1].Index;
            if (InputDirection.Checked == true)
                TableLeagueStats.Sort(TableLeagueStats.Columns[count], ListSortDirection.Ascending);
            else
                TableLeagueStats.Sort(TableLeagueStats.Columns[count], ListSortDirection.Descending);

        }



    }
}
