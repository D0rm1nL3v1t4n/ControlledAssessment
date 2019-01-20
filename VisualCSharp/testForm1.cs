using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualCSharp
{
    public partial class testForm1 : Form
    {

        testForm2 form;

        public testForm1()
        {
            InitializeComponent();
            form = new testForm2();
        }

        private void EventOpenForm2_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void EventCloseForm2_Click(object sender, EventArgs e)
        {
            //Application.OpenForms["testForm1"].Hide();
            if (form.Visible)
            {
                form.Hide();
            }
            else
            {
                MessageBox.Show("You cannot close a form that isn't open!");
            }
        }
    }
}
