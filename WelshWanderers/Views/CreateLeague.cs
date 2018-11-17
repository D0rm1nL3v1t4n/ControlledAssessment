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

namespace WelshWanderers.Views
{
    public partial class CreateLeague : Form
    {
        public CreateLeague()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? League will not be created.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NavToManageLeagues();
            }
        }

        private void NavToManageLeagues()
        {
            new WelshWanderers.ManageLeagues().Show();
            this.Hide();
        }

        private void EventNavCreate_Click(object sender, EventArgs e)
        {
            string fileName = GenerateLeagueName();
            if (ValidInputs() == true && CreateLeagueFile(fileName) == false)
            {
                SaveLeague(fileName);
                MessageBox.Show("League created.");
            }
        }

        private void SaveLeague(string fileName)
        {
            string line = Functions.FileSearch.GetNextId("leagues").ToString() + "|" + InputName.Text + "|" + fileName + "|" + InputTeam.Text + "|";
            Functions.FileWrite.WriteData(fileName, line);
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

        private bool CreateLeagueFile(string fileName)
        {
            string path = fileName + ".txt";
            if (!File.Exists(path))
            {
                File.Create(path);
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
            if (InputTeam.Text != null)
            {
                if (InputName.Text.Length <= 20 && InputName.Text.Length >= 5)
                    return true;
                else
                    MessageBox.Show("League name must be between 5 and 20 characters.");
            }
            MessageBox.Show("Select a team.");
            return false;
        }
    }
}
