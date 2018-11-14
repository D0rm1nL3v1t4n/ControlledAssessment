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
    public partial class ViewTraining : Form
    {
        public ViewTraining()
        {
            InitializeComponent();
        }

        private void ViewTraining_Load(object sender, EventArgs e)
        {
            HideEditButton();
            FillTableData();
            TableViewTrainings.MultiSelect = true;
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("trainingDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                TableViewTrainings.Rows.Add(section[0], section[1], section[2] + ":" + section[3], section[4], section[5]);
            }
            file.Close();
        }

        private void NavEdit_Click(object sender, EventArgs e)
        {
            LoadTrainingData();  
            NavToEditTraining();
        }

        private void LoadTrainingData()
        {
            string[] time = TableViewTrainings.SelectedRows[0].Cells[2].Value.ToString().Split(':');
            Database.TrainingData.id = Convert.ToInt16(TableViewTrainings.SelectedRows[0].Cells[0].Value);
            Database.TrainingData.team = TableViewTrainings.SelectedRows[0].Cells[1].Value.ToString();
            Database.TrainingData.timeHour = Convert.ToInt16(time[0]);
            Database.TrainingData.timeMin = Convert.ToInt16(time[1]);
            Database.TrainingData.duration = Convert.ToInt16(TableViewTrainings.SelectedRows[0].Cells[3].Value);
            Database.TrainingData.date = TableViewTrainings.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void NavToEditTraining()
        {
            new WelshWanderers.EditTraining().Show();
            this.Hide();
        }

        private void HideEditButton()
        {
            if (Database.UserData.accessLevel == "Player")
                NavEdit.Hide();
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
    }
}
