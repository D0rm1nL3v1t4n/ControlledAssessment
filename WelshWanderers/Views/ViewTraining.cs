using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelshWanderers
{
    public partial class ViewTrainings : Form
    {
        public ViewTrainings()
        {
            InitializeComponent();
        }

        public static int changesMade = 0;
        public static bool team = false;
        public static bool timeH = false;
        public static bool timeM = false;
        public static bool duration = false;
        public static bool date = false;

        private void EditTraining_Load(object sender, EventArgs e)
        {
            LoadTrainingData();
            EditOff();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (changesMade > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NavToUpcomingTraining();
                }
            }
        }

        private void EventEdit_Click(object sender, EventArgs e)
        {
            EditOn();
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)
                ChangeTrainingData();
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            if (changesMade > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditOff();
                }
            }
        }

        private void EditOn()
        {
            ShowEditButtons();
            EditingEnableChange(true);
        }

        private void EditOff()
        {
            LoadTrainingData();
            HideEditButtons();
            EditingEnableChange(false);
            LabelChangesMade.Text = "No Changes";
        }

        private void ShowEditButtons()
        {
            EventEdit.Hide();
            EventCancelEdit.Show();
            EventSave.Show();
            LabelChangesMade.Show();
        }

        private void EditingEnableChange(bool state)
        {
            InputTeam.Enabled = state;
            InputTimeH.Enabled = state;
            InputTimeM.Enabled = state;
            InputDuration.Enabled = state;
            InputDate.Enabled = state;
        }

        private void HideEditButtons()
        {
            EventEdit.Show();
            EventSave.Hide();
            EventCancelEdit.Hide();
            LabelChangesMade.Hide();
        }


        private void NavToUpcomingTraining()
        {
            new WelshWanderers.UpcomingTrainings().Show();
            this.Hide();
        }

        private void LoadTrainingData()
        {
            InputTeam.Text = Database.TrainingData.team;
            InputTimeH.Text = Database.TrainingData.timeH.ToString();
            InputTimeM.Text = Database.TrainingData.timeM.ToString();
            InputDuration.Text = Database.TrainingData.duration.ToString();
            InputDate.Text = Database.TrainingData.date;
        }

        private void ChangeTrainingData()
        {
            string[] data = { InputTeam.Text, InputTimeH.Text, InputTimeM.Text, InputDuration.Text, InputDate.Text };
            int[] searchIndex = { 0 };
            string[] searchData = { Database.TrainingData.id.ToString() };
            Functions.FileEdit.EditLine("trainingDetails", 6, data, searchIndex, searchData);
        
            Database.TrainingData.team = InputTeam.Text;
            Database.TrainingData.timeH = Convert.ToInt16(InputTimeH.Text);
            Database.TrainingData.timeM = Convert.ToInt16(InputTimeM.Text);
            Database.TrainingData.duration = Convert.ToInt16(InputDuration.Text);
            Database.TrainingData.date = InputDate.Text;
            MessageBox.Show("Training details have been saved.");
        }

        private void ShowChangesMade()
        {
            LabelChangesMade.Text = changesMade + " change(s)\nmade.";
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)
            {
                ++changesMade;
                ShowChangesMade();
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)
            {
                --changesMade;
                ShowChangesMade();
                return false;
            }

            if (changedVal == true)
                return true;
            else
                return false;
        }

        private void InputTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            team = DetailsChanged(InputTeam.Text, Database.TrainingData.team, team);
        }

        private void InputTimeH_TextChanged(object sender, EventArgs e)
        {
            timeH = DetailsChanged(InputTimeH.Text, Database.TrainingData.timeH.ToString(), timeH);
        }

        private void InputTimeM_TextChanged(object sender, EventArgs e)
        {
            timeM = DetailsChanged(InputTimeM.Text, Database.TrainingData.timeM.ToString(), timeM);
        }

        private void InputDuration_TextChanged(object sender, EventArgs e)
        {
            duration = DetailsChanged(InputDuration.Text, Database.TrainingData.duration.ToString(), duration);
        }

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {
            date = DetailsChanged(InputDate.Text, Database.TrainingData.date, date);
        }

        private bool ValidInputs()
        {
            if (ValidTeam() == true && ValidTime() == true && ValidDuration() == true)
                return true;
            return false;
        }

        private bool ValidDuration()
        {
            int duration = System.Convert.ToInt16(InputDuration.Text);
            if (duration > 0 && duration < 240)
                return true;
            MessageBox.Show("Duration entered must be a valid duration.");
            return false;
        }

        private bool ValidTime()
        {
            int hour = System.Convert.ToInt16(InputTimeH.Text);
            int min = System.Convert.ToInt16(InputTimeM.Text);
            if (hour >= 0 && hour <= 23)
            {
                if (min >= 0 && min <= 59)
                    return true;
                else
                    return false;
            }
            MessageBox.Show("Time entered must be a valid time.");
            return false;
            
        }

        private bool ValidTeam()
        {
            if (InputTeam.Text != null)
                return true;
            MessageBox.Show("Selected a training type in the drop down box.");
            return false;
        }

    }
}
