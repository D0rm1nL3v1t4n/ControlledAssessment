using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCSharp.Forms.Sub_home_Screens.Player_sub_Screens
{
    public partial class MatchNotificationsForm : Form
    {
        public MatchNotificationsForm()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure? Any unsaved matches will not be saved.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ReturnHome();
            }          
        }

        private void ReturnHome()
        {
            new Forms.playerHomeForm().Show();
            this.Hide();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            SaveMatchAvailability();
        }

        private void SaveMatchAvailability()
        {

        }

        private void MatchNotificationsForm_Load(object sender, EventArgs e)
        {

        }

    }
}
