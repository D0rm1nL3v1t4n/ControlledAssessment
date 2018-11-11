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

namespace VisualCSharp.Forms.Sub_home_Screens.Shared_sub_Screens
{
    public partial class ViewTrainings : Form
    {
        public ViewTrainings()
        {
            InitializeComponent();
        }

        private void ViewTrainings_Load(object sender, EventArgs e)
        {
            HideButtons();
            TableViewTrainings.MultiSelect = false;
            StreamReader trainingDetailsFile = new StreamReader("trainingDetails.txt");
            string line = trainingDetailsFile.ReadLine();
            while (null != line)
            {
                string[] section = line.Split('|');
                TableViewTrainings.Rows.Add(
                    section[0], section[1],
                    section[2] + ":" + section[3],
                    section[4] + ":" + section[5],
                    section[6]);
                line = trainingDetailsFile.ReadLine();
            }
            trainingDetailsFile.Close();
        }
                


        private void HideButtons()
        {
            if (UserData.userLevel == "Player")
            {
                BtnEditTraining.Hide();
            }
        }

        private void BtnEditTraining_Click(object sender, EventArgs e)
        {
            TrainingData.trainingID = TableViewTrainings.SelectedRows[0].Cells[0].Value.ToString();
            TrainingData.trainingType = TableViewTrainings.SelectedRows[0].Cells[1].Value.ToString();

            string[] startTime = TableViewTrainings.SelectedRows[0].Cells[2].Value.ToString().Split(':');
            string[] finishTime = TableViewTrainings.SelectedRows[0].Cells[3].Value.ToString().Split(':');
            TrainingData.startTimeHour = startTime[0];
            TrainingData.startTimeMin = startTime[1];
            TrainingData.finishTimeHour = finishTime[0];
            TrainingData.finishTimeMin = finishTime[1];

            TrainingData.date = TableViewTrainings.SelectedRows[0].Cells[4].Value.ToString();

            new Forms.Sub_home_Screens.Coach_sub_Screens.EditTrainingForm().Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (UserData.userLevel == "Player")
            {
                new Forms.playerHomeForm().Show();
            }
            else if (UserData.userLevel == "Coach")
            {
                new Forms.coachHomeForm().Show();
            }
            this.Hide();
        }

  
    }
}
