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

namespace WelshWanderers.Views
{
    public partial class ViewMatchAvailability : Form
    {
        public ViewMatchAvailability()
        {
            InitializeComponent();
        }

        private void ViewMatchAvailability_Load(object sender, EventArgs e)
        {
            StreamReader fileMatch = new StreamReader("matchAvailability.txt");
            string line;
            while ((line = fileMatch.ReadLine()) != null)
            {
                string[] sectionA = line.Split('|');
                if (sectionA[0] == Database.MatchData.id.ToString())
                {
                    string[] sectionB = Functions.FileSearch.ReturnLine("userPersonalDetails", sectionA[1], 0).Split('|');
                    bool availabilityState = false;
                    bool responded = false;
                    if (sectionA[2] != "")
                        responded = true;
                    if (sectionA[2] == "Yes")
                        availabilityState = true;
                    TableMatchAvailability.Rows.Add(sectionA[1], sectionB[2], sectionB[3], responded, availabilityState);
                }
            }
        }

        private void NavBack_Click(object sender, EventArgs e)
        {
            new UpcomingMatches().Show();
            Close();
        }
    }
}
