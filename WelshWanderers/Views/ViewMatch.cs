using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WelshWanderers
{
    public partial class ViewMatch : Form
    {
        public ViewMatch()
        {
            InitializeComponent();
        }

        private void ViewMatch_Load(object sender, EventArgs e)
        {
            HideButtons();
            FillTableData();
        }

        private void FillTableData()
        {
            StreamReader file = new StreamReader("matchDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] section = line.Split('|');
                TableViewMatches.Rows.Add(section[0], section[1], section[2], section[3], section[4], section[5], section[6], section[7], section[8]);
            }
        }

        private void HideButtons()
        {
            NavMatchAddResult.Hide();
            NavEditMatch.Hide();
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

        private void NavAddResult_Click(object sender, EventArgs e)
        {
            new WelshWanderers.AddResult().Show();
            this.Hide();
        }

        private void NavEdit_Click(object sender, EventArgs e)
        {
            new WelshWanderers.EditMatch().Show();
            this.Hide();
        }
    }
}
