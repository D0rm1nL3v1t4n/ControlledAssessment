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

        private void NavCancel_Click(object sender, EventArgs e) => NavToHome();

        private void NavToHome()
        {
            new WelshWanderers.Home().Show();
            this.Hide();
        }
    }
}
