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
    public partial class MatchAvailability : Form
    {
        public MatchAvailability()
        {
            InitializeComponent();
        }

        private void MatchAvailability_Load(object sender, EventArgs e)
        {
            ColAvailability.ReadOnly = false;
            FillTableData();
        }

        private void FillTableData()
        {
            //Seems really inefficient, how could this have fewer iterations?
            //Loop over matchAvailability first, then find matchDetails after?

            StreamReader file = new StreamReader("matchDetails.txt");
            string line;
            while (null != (line = file.ReadLine()))
            {
                string[] sectionA = line.Split('|');
                string sectionB = Functions.FileSearch.ManyToMany("matchAvailability", sectionA[0], 0, Database.UserData.id.ToString(), 1);
                if (sectionB != null)
                {
                    string[] sectionC = sectionB.Split('|');
                    if (Convert.ToDateTime(sectionA[3]) >= DateTime.Now)
                    {
                        TableMatchAvailability.Rows.Add(sectionA[0], sectionA[1], sectionA[2], sectionA[3], sectionA[4] + ":" + sectionA[5], sectionC[2]);
                    }
                }
            }
        }

        private void NavHome_Click(object sender, EventArgs e)
        {
            NavToHome();
        }

        private void NavToHome()
        {
            new Home().Show();
            Hide();
        }

        private void EventMatchDetails_Click(object sender, EventArgs e)
        {
            try
            {
                StoreMatchDetails();
                if (Application.OpenForms["ViewMatch"] == null)
                {
                   new ViewMatch("Match Availability").Show();
                }
                else
                {
                    MessageBox.Show("That form is already open.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a match to view.");
            }            
        }

        private void StoreMatchDetails()
        {
                Database.MatchData.id = Convert.ToInt16(TableMatchAvailability.SelectedRows[0].Cells[0].Value);
                string[] section = Functions.FileSearch.ReturnLine("matchDetails", Database.MatchData.id.ToString(), 0).Split('|');
                Database.MatchData.league = section[1];
                Database.MatchData.opponent = section[2];
                Database.MatchData.date = section[3];
                Database.MatchData.timeH = Convert.ToInt16(section[4]);
                Database.MatchData.timeM = Convert.ToInt16(section[5]);
                Database.MatchData.addressLineA = section[6];
                Database.MatchData.addressLineA = section[7];
                Database.MatchData.postcode = section[8];
        }

        private void EventSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TableMatchAvailability.Rows.Count; ++i)
            {
                string[] section = Functions.FileSearch.ManyToMany("matchAvailability", Database.UserData.id.ToString(), 1, TableMatchAvailability.Rows[i].Cells[0].Value.ToString(), 0).Split('|');
                if (section[2] != TableMatchAvailability.Rows[i].Cells[5].Value.ToString())
                {
                    EditAvailability(i);
                }
            }
            MessageBox.Show("Saved.");
        }

        private void EditAvailability(int i)
        {
            string[] data = { TableMatchAvailability.Rows[i].Cells[5].Value.ToString() };
            int[] searchIndex = { 0, 1 };
            string[] searchData = { TableMatchAvailability.Rows[i].Cells[0].Value.ToString(), Database.UserData.id.ToString() };
            Functions.FileEdit.EditLine("matchAvailability", 3, data, searchIndex, searchData);
        }
    }
}
