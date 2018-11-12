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
    public partial class ManageLeagues : Form
    {
        public ManageLeagues()
        {
            InitializeComponent();
        }

        private void ManageLeagues_Load(object sender, EventArgs e)
        {

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

        private void EventNavCreate_Click(object sender, EventArgs e)
        {
            new WelshWanderers.Views.CreateLeague().Show();
            this.Hide();
        }

        private void EventNavEdit_Click(object sender, EventArgs e)
        {
            new WelshWanderers.Views.EditLeague().Show();
        }

        
    }
}
