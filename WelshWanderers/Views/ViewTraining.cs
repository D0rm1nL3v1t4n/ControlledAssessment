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

        private class Changes
        {
            public static int count = 0;
            public static bool team = false;
            public static bool timeH = false;
            public static bool timeM = false;
            public static bool duration = false;
            public static bool date = false;
        }

        private void EditTraining_Load(object sender, EventArgs e)
        {
            LoadTrainingData();
            EditOff();
            HideCoachButtons();
        }

        private void HideCoachButtons()
        {
            if (Database.UserData.accessLevel == "Player")
                EventEdit.Hide();
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NavToUpcomingTraining();
                }
            }
            NavToUpcomingTraining();
        }

        private void EventEdit_Click(object sender, EventArgs e)
        {
            EditOn();
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)
            {
                ChangeTrainingData();
                EditOff();
            }
        }

        private void ResetChanges()
        {
            Changes.team = false;
            Changes.timeH = false;
            Changes.timeM = false;
            Changes.duration = false;
            Changes.date = false;
            Changes.count = 0;
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditOff();
                }
            }
            EditOff();
        }

        private void EditOn()
        {
            ShowEditButtons();
            EditingEnableChange(true, false);
        }

        private void EditOff()
        {
            LoadTrainingData();
            HideEditButtons();
            EditingEnableChange(false, true);
            LabelChangesMade.Text = "No Changes";
            ResetChanges();
        }

        private void ShowEditButtons()
        {
            EventEdit.Hide();
            EventCancelEdit.Show();
            EventSave.Show();
            LabelChangesMade.Show();
        }

        private void EditingEnableChange(bool state, bool oppositeSate)
        {
            InputTeam.Enabled = state;
            InputTimeH.ReadOnly = oppositeSate;
            InputTimeM.ReadOnly = oppositeSate;
            InputDuration.ReadOnly = oppositeSate;
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
            new UpcomingTrainings().Show();
            Hide();
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
            LabelChangesMade.Text = Changes.count + " change(s)\nmade.";
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {
            if (inputData != databaseValue && changedVal == false)
            {
                ++Changes.count;
                return true;
            }
            else if (inputData == databaseValue && changedVal == true)
            {
                --Changes.count;
                return false;
            }
            ShowChangesMade();
            return changedVal;
        }

        private void InputTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changes.team = DetailsChanged(InputTeam.Text, Database.TrainingData.team, Changes.team);
        }

        private void InputTimeH_TextChanged(object sender, EventArgs e)
        {
            Changes.timeH = DetailsChanged(InputTimeH.Text, Database.TrainingData.timeH.ToString(), Changes.timeH);
        }

        private void InputTimeM_TextChanged(object sender, EventArgs e)
        {
            Changes.timeM = DetailsChanged(InputTimeM.Text, Database.TrainingData.timeM.ToString(), Changes.timeM);
        }

        private void InputDuration_TextChanged(object sender, EventArgs e)
        {
            Changes.duration = DetailsChanged(InputDuration.Text, Database.TrainingData.duration.ToString(), Changes.duration);
        }

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {
            Changes.date = DetailsChanged(InputDate.Text, Database.TrainingData.date, Changes.date);
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
