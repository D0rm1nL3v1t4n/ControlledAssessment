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
            new ManageLeagues().Show();
            Hide();
        }

        private void EventNavCreate_Click(object sender, EventArgs e)
        {
            string fileName = InputName.Text;
            if (ValidInputs() == true && CreateLeagueFile(fileName) == false)
            {
                SaveLeague(fileName);
                MessageBox.Show("League created.");
                NavToManageLeagues();
            }
        }

        private void SaveLeague(string fileName)
        {
            string line = Functions.FileSearch.GetNextId("leagues").ToString() + "|" + fileName + "|" + InputTeam.Text + "|";
            Functions.FileWrite.WriteData("leagues", line);
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
            if (InputTeam.Text != null)
            {
                if (InputName.Text.Length <= 30 && InputName.Text.Length >= 5)
                    return true;
                else
                    MessageBox.Show("League name must be between 5 and 30 characters.");
            }
            else
            {
                MessageBox.Show("Select a team.");
            }
            return false;
        }

    }
}
