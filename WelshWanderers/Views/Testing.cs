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
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }

        private void EventTest_Click(object sender, EventArgs e)
        {
            TestPasswordHash();
            this.Hide();
        }

        private void TestPasswordHash()
        {
            string hashA = Functions.HashAlgorithm.HashPassword("Password1!");
            Functions.FileWrite.WriteData("testingFile", hashA);

        }


        private void TestWriteData()
        {
            Functions.FileWrite.WriteData("testingFile","0|Nimrod|Abramovich|Great Britain|");
            Functions.FileWrite.WriteData("testingFile", "1|Yoav|Abramovich|Israel|");
        }

        private void TestSearchData()
        {
            string search = Functions.FileSearch.ReturnSegment("testingFile", "2", 0, 3, true);
            string[] section = search.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string searchResult in section)
                MessageBox.Show(searchResult);
        }

        private void TestEditData()
        {
            string[] data = new string[3] { "Edo", "Levitan", "Wales" };
            Functions.FileEdit.EditLine("testingFile", 4, data, 0, "2");
        }

        private void TestDeleteData(int lineNo)
        {
            Functions.FileDelete.RemoveLine("testingFile", 4, lineNo);
        }

        private void TestSendEmail()
        {
            string[] emails = new string[2] { "12nabramovich@stanwell.org", "grumpydormin@gmail.com" };
            Functions.SendEmail.Email("Test Email", "BODY BODY", emails);
        }

        private void TestPasswordValidation()
        {
            Functions.ValidPassword.IsPasswordValid("ABCdef123!()", "ABCdef123!()");
        }
    }
}
