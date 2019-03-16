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
            Close();
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
            if (ValidInputs() == true && CreateLeagueFile(InputName.Text) == false)
            {
                EditLeagueData();
                RenameLeague();
                NavToManageLeagues();
            }
        }

        private void RenameLeague()
        {
            File.Move(@"Leagues\" + Database.LeagueData.name + ".txt", @"Leagues\" + InputName.Text + ".txt");
        }

        private void EditLeagueData()
        {
            string[] data = { InputName.Text, InputTeam.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.LeagueData.id.ToString() };
            Functions.FileEdit.EditLine("leagues", 3, data, searchIndex, searchData);
            MessageBox.Show("Changes have been saved.");
        }

        private bool CreateLeagueFile(string fileName)
        {
            string path = @"Leagues\" + fileName + ".txt";
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
                return false;
            }
            else
            {
                MessageBox.Show("A league by that name already exists.\nName the league differently or delete that exisiting league before continuing.");
                return true;
            }
        }
                private bool ValidInputs()
        {
            bool name = ValidName();
            bool team = ValidTeam();
            return name && team;
        }

        private bool ValidName()
        {
            if (InputName.Text.Length <= 30 && InputName.Text.Length >= 5)
                return true;
                MessageBox.Show("League name must be between 5 and 30 characters.");
            return false;
        }

        private bool ValidTeam()
        {
            if (InputTeam.Text.Length > 0)
                return true;
            MessageBox.Show("Select a team.");
            return false;
        }
    }
}
