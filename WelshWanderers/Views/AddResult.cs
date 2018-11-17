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
    public partial class AddResult : Form
    {
        public AddResult()
        {
            InitializeComponent();
        }

        private void NavCancel_Click(object sender, EventArgs e)
        {
            NavToViewMatches();
        }

        private void NavToViewMatches()
        {
            new WelshWanderers.UpcomingMatches().Show();
            this.Hide();
        }
    }
}
