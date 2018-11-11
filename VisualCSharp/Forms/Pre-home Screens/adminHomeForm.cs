using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCSharp.Forms
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void BtnMyAccountAdmin_Click(object sender, EventArgs e)
        {
            new Home_Screens.myAccountDetails().Show();
            this.Hide();
        }

        private void BtnSignOutAdmim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new signInForm().Show();
                this.Hide();
            }
        }
    }
}
