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
    public partial class UpcomingTrainings : Form
    {
        public UpcomingTrainings()
        {
            InitializeComponent();
        }

        private void ViewTraining_Load(object sender, EventArgs e)
        {
            InputFilter.SelectedItem = "Upcoming";
            TableViewTrainings.MultiSelect = true;
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("trainingDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');

                if ((Convert.ToDateTime(section[5]) >= DateTime.Today && InputFilter.Text == "Upcoming") || (Convert.ToDateTime(section[5]) < DateTime.Today && InputFilter.Text == "Past") || (InputFilter.Text == "All"))
                    TableViewTrainings.Rows.Add(section[0], section[1], section[2] + ":" + section[3], section[4], section[5]);
            }
            file.Close();
        }

        private void NavEdit_Click(object sender, EventArgs e)
        {
            try
            {
                LoadTrainingData();
                NavToEditTraining();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select a training session to view it.");
            }
        }

        private void LoadTrainingData()
        {
            string[] time = TableViewTrainings.SelectedRows[0].Cells[2].Value.ToString().Split(':');
            Database.TrainingData.id = Convert.ToInt16(TableViewTrainings.SelectedRows[0].Cells[0].Value);
            Database.TrainingData.team = TableViewTrainings.SelectedRows[0].Cells[1].Value.ToString();
            Database.TrainingData.timeH = Convert.ToInt16(time[0]);
            Database.TrainingData.timeM = Convert.ToInt16(time[1]);
            Database.TrainingData.duration = Convert.ToInt16(TableViewTrainings.SelectedRows[0].Cells[3].Value);
            Database.TrainingData.date = TableViewTrainings.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void NavToEditTraining()
        {
            new ViewTrainings().Show();
            Close();
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new Home().Show();
            Close();
        }

        private void InputFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableViewTrainings.Rows.Clear();
            FillTableData();
            ListSortDirection direction = ListSortDirection.Descending;
            if (InputFilter.SelectedItem == "Upcoming")
                direction = ListSortDirection.Ascending;
            TableViewTrainings.Sort(TableViewTrainings.Columns[3], direction);
        }
    }
}
