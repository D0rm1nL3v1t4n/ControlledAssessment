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
    public partial class AddTraining : Form
    {
        public AddTraining()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }

        private void EventNavSave_Click(object sender, EventArgs e)
        {
            if (ValidInputs() == true)
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            
        }

        private bool ValidInputs()
        {
            if (ValidType() == false)
                return false;
            else if (ValidTime() == false)
                return false;
            else if (ValidDuration() == false)
                return false;
            else if (ValidDate() == false)
                return false;
            else
                return true;
        }

        private bool ValidDate()
        {
            if (InputDate.Value <= DateTime.Now)
                return false;
            else
            {
                MessageBox.Show("Date entered must be after today.");
                return true;
            }
        }

        private bool ValidDuration()
        {
            int duration = System.Convert.ToInt16(InputDuration.Text);
            if (duration > 0 && duration < 240)
                return true;
            else
            {
                MessageBox.Show("Duration entered must be a valid duration.");
                return false;
            }
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
            else
            {
                MessageBox.Show("Time entered must be a valid time.");
                return false;
            }  
        }
        
        private bool  ValidType()
        {
            if (InputType.Text == "Clinic" || InputType.Text == "Junior" ||
                InputType.Text == "Men" || InputType.Text == "Women")
                return true;
            else
            {
                MessageBox.Show("Selected a training type in the drop down box.");
                return false;
            }
        }
    }
}
