using System;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers.Views
{
    public partial class EditLeague : Form
    {
        public EditLeague()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            NavToManageLeagues();
        }

        private void NavToManageLeagues()
        {
            new ManageLeagues().Show();
            Hide();
        }

        private void EditLeague_Load(object sender, EventArgs e)
        {
            LoadLeagueData();
        }

        private void LoadLeagueData()
        {
            InputName.Text = Database.LeagueData.name;
            InputTeam.Text = Database.LeagueData.team;
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            EditLeagueData();
            RenameLeague();
            NavToManageLeagues();
        }

        private void RenameLeague()
        {
            //File.Move(Database.LeagueData.fileName)
        }

        private void EditLeagueData()
        {
            string[] data = { InputName.Text, GenerateLeagueName(), InputTeam.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.LeagueData.id.ToString() };
            Functions.FileEdit.EditLine("leagues", 4, data, searchIndex, searchData);
        }

        private string GenerateLeagueName()
        {
            string[] name = InputName.Text.Split(' ');
            string fileName = "League";
            foreach (string segement in name)
            {
                fileName += "_" + segement.ToLower();
            }
            return fileName;
        }
    }
}
