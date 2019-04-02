using System;
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
        {   //variables for the count for the changes made and boolean values if the data has been changed from the original data
            public static int count = 0;
            public static bool team = false;
            public static bool timeH = false;
            public static bool timeM = false;
            public static bool duration = false;
            public static bool date = false;
        }

        private void ResetChanges()
        {   //resets the changes made back to the original data
            Changes.count = 0;
            Changes.team = false;
            Changes.timeH = false;
            Changes.timeM = false;
            Changes.duration = false;
            Changes.date = false;
        }

        private void EditTraining_Load(object sender, EventArgs e)
        {
            LoadTrainingData(); //calls on function to load the data into the form
            EditOff();  //calls on function to change the editability of the form off
            HideCoachButtons(); //calls on function to hide buttons made for the coach only
        }

        private void HideCoachButtons()
        {   //checks if the user is a player
            if (Database.UserData.accessLevel == "Player")
                EventEdit.Hide();   //hides the edit button
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks that changes have been made
            {
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NavToUpcomingTraining();    //navigation to Trainings form
                }
                return;
            }
            NavToUpcomingTraining();    //navigation to Trainings form
        }

        private void EventEdit_Click(object sender, EventArgs e)
        {
            EditOn();   //calls on function to turn the editability of the form on
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)  //checks that the inputs are all valid
            {
                ChangeTrainingData();   //calls on function to edit the data for the training
                EditOff();  //calls on function to turn the editability of the form off
            }
        }

        private void EventCancelEdit_Click(object sender, EventArgs e)
        {
            if (Changes.count > 0)  //checks if changes have been made
            {   //Messagebox with Yes No buttons asking the user if they wish to continue as they have unsaved changes
                if (MessageBox.Show("Are you sure? Changes will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    EditOff();  //calls on function to turn the editability of the form off
                }
                return;
            }
            EditOff();  //calls on function to turn the editability of the form off
        }

        private void EditOn()
        {
            ShowEditButtons();  //calls on function to show the edit buttons
            EditingEnableChange(true, false);   //calls on function to change the editability of the form
        }

        private void EditOff()
        {
            LoadTrainingData(); //calls on function to load the data into the form
            HideEditButtons();  //calls on funtion to hide the buttons for the editing
            EditingEnableChange(false, true);   //changes the editability of the form
            LabelChangesMade.Text = "No Changes";
            ResetChanges(); //calls on function to reset the changes made in the form 
        }

        private void ShowEditButtons()
        {
            EventEdit.Hide();   //hides the edit button
            //Shows the changes made label and save & cancel edit buttons
            EventCancelEdit.Show();
            EventSave.Show();
            LabelChangesMade.Show();
            LabelChangesMade.Text = "0 changes\nmade.";
        }

        private void EditingEnableChange(bool state, bool oppositeSate)
        {   //changes the readonly / enabled state of the inputs on the form
            InputTeam.Enabled = state;
            InputTimeH.ReadOnly = oppositeSate;
            InputTimeM.ReadOnly = oppositeSate;
            InputDuration.ReadOnly = oppositeSate;
            InputDate.Enabled = state;
        }

        private void HideEditButtons()
        {
            EventEdit.Show();   //shows the edit button
            //Hides the changes made label and save & cancel edit buttons
            EventSave.Hide();
            EventCancelEdit.Hide();
            LabelChangesMade.Hide();
        }


        private void NavToUpcomingTraining()
        {
            new UpcomingTrainings().Show(); //shows the Trainings form
            Close();    //closes this form
        }   

        private void LoadTrainingData()
        {   //loads the data from the TrainingData in the database into the form
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
            Functions.FileEdit.EditLine("trainingDetails", 6, data, searchIndex, searchData);   //edits the training's record in the file
            //updates the TrainingData to the data in the form
            Database.TrainingData.team = InputTeam.Text;
            Database.TrainingData.timeH = Convert.ToInt16(InputTimeH.Text);
            Database.TrainingData.timeM = Convert.ToInt16(InputTimeM.Text);
            Database.TrainingData.duration = Convert.ToInt16(InputDuration.Text);
            Database.TrainingData.date = InputDate.Text;
            MessageBox.Show("Training details have been saved.");
        }

        private void ShowChangesMade()
        {   //label showing the changes made to the data
            LabelChangesMade.Text = Changes.count + " change(s)\nmade.";
        }

        private bool DetailsChanged(string inputData, string databaseValue, bool changedVal)
        {   //checks if changes have been made to the original data
            if (inputData != databaseValue && changedVal == false)
            {
                ++Changes.count;    //incraments count by 1
                ShowChangesMade();  //calls on function to show the changes mad
                return true;
            }
            //checks if data has been changed back to original data
            else if (inputData == databaseValue && changedVal == true)
            {
                --Changes.count;    //decreases count by 1
                ShowChangesMade();  //calls on function to show the changes mad
                return false;
            }
            return changedVal;
        }

        private void InputTeam_SelectedIndexChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the team data
            Changes.team = DetailsChanged(InputTeam.Text, Database.TrainingData.team, Changes.team);
        }

        private void InputTimeH_TextChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the hours data
            Changes.timeH = DetailsChanged(InputTimeH.Text, Database.TrainingData.timeH.ToString(), Changes.timeH);
        }

        private void InputTimeM_TextChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the minutes data
            Changes.timeM = DetailsChanged(InputTimeM.Text, Database.TrainingData.timeM.ToString(), Changes.timeM);
        }

        private void InputDuration_TextChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the duration data
            Changes.duration = DetailsChanged(InputDuration.Text, Database.TrainingData.duration.ToString(), Changes.duration);
        }

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {   //checks if changes have been made to the date data
            Changes.date = DetailsChanged(InputDate.Text, Database.TrainingData.date, Changes.date);
        }

        private bool ValidInputs()
        {   //checks that all the inputs are valid
            if (ValidTeam() == true && ValidTime() == true && ValidDuration() == true)
                return true;    //returns true if all inputs are valid
            return false;   //returns false if not all inputs are valid
        }

        private bool ValidDuration()
        {   //converts data from string to integer
            int duration = System.Convert.ToInt16(InputDuration.Text);
            if (duration > 0 && duration < 240) //range check
                return true;    //returns true if validation passes
            MessageBox.Show("Duration entered must be a valid duration.");
            return false;   //returns false if validation fails
        }

        private bool ValidTime()
        {   //converts data from string to integer
            int hour = System.Convert.ToInt16(InputTimeH.Text);
            int min = System.Convert.ToInt16(InputTimeM.Text);
            if (hour >= 0 && hour <= 23)    //range check
            {
                if (min >= 0 && min <= 59)  //range check
                    return true;    //returns true if validation passes
            }
            MessageBox.Show("Time entered must be a valid time.");
            return false;   //returns false if validation fails

        }

        private bool ValidTeam()
        {   //presence check
            if (InputTeam.Text.Length > 0)
                return true;    //returns true if validation passes
            MessageBox.Show("Selected a training type in the drop down box.");
            return false;   //returns false if validation fails
        }

    }
}
