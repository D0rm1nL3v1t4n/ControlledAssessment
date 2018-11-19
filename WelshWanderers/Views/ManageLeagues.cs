using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class ManageLeagues : Form
    {
        public ManageLeagues()
        {
            InitializeComponent();
        }

        private void ManageLeagues_Load(object sender, EventArgs e)
        {
            TableViewLeagues.MultiSelect = false;
            LoadAllLeagues();
        }
        
        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void EventNavCreate_Click(object sender, EventArgs e)
        {
            new WelshWanderers.Views.CreateLeague().Show();
            this.Hide();
        }

        private void EventNavEdit_Click(object sender, EventArgs e)
        {
            SaveLeagueDatabase();
            new WelshWanderers.Views.EditLeague().Show();
        }

        private void SaveLeagueDatabase()
        {
            Database.LeagueData.id = Convert.ToInt16(TableViewLeagues.SelectedRows[0].Cells[0].Value);
            Database.LeagueData.name = TableViewLeagues.SelectedRows[0].Cells[1].Value.ToString();
            Database.LeagueData.fileName = TableViewLeagues.SelectedRows[0].Cells[2].Value.ToString();
            Database.LeagueData.team = TableViewLeagues.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void EventDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? This league and all its data will be permanently deleted.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteLeague();
            }
        }

        private void DeleteLeague()
        {
            string fileName = TableViewLeagues.SelectedRows[0].Cells[2].Value.ToString();
            Functions.FileDelete.RemoveLine(fileName, 4, Functions.FileSearch.LineNumber(fileName, TableViewLeagues.SelectedRows[0].Cells[0].Value.ToString(), 0));
            MessageBox.Show("League has been deleted.");
            TableViewLeagues.Rows.Clear();
            LoadAllLeagues();
        }

        private void LoadAllLeagues()
        {
            StreamReader file = new StreamReader("leagues.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                TableViewLeagues.Rows.Add(section[0], section[1], section[2], section[3]);
            }
            file.Close();
        }

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        
    }
}
