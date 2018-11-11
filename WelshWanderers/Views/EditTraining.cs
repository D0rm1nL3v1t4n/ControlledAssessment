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
    public partial class EditTraining : Form
    {
        public EditTraining()
        {
            InitializeComponent();
        }

        private void NavSignIn_Click(object sender, EventArgs e) => NavToViewTraining();

        private void NavToViewTraining()
        {
            new WelshWanderers.ViewTraining().Show();
            this.Hide();
        }
    }
}
