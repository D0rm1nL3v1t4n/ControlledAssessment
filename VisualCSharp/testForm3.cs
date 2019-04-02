using System;
using System.Windows.Forms;

namespace VisualCSharp
{
    public partial class testForm3 : Form
    {
        public testForm3()
        {
            InitializeComponent();
        }

        private void testForm3_Load(object sender, EventArgs e)
        {
            string[] array = null;
            MessageBox.Show(array[array.Length - 1].ToString());
        }
    }
}
