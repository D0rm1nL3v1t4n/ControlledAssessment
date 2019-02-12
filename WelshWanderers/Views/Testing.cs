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
            
        }


        private void TestPasswordHash()
        {
            MessageBox.Show("Password1! | " + Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("testingFile", "0", 0, 1), "Pasword1!").ToString());
            MessageBox.Show("Password | " + Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("testingFile", "1", 0, 1), "Pasword").ToString());
            MessageBox.Show("QWERTY | " + Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("testingFile", "2", 0, 1), "QERTY").ToString());
            MessageBox.Show("1234567890 | " + Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("testingFile", "3", 0, 1), "123467890").ToString());
            MessageBox.Show("ecvgujkkuyfvbufcvbgfv | " + Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("testingFile", "4", 0, 1), "cvgujkkuyfvbufcvbgfv").ToString());
            MessageBox.Show("Password1! | " + Functions.HashAlgorithm.CheckHashes(Functions.FileSearch.ReturnSegment("testingFile", "5", 0, 1), "Password!").ToString());
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
            int[] searchIndex = { 0 };
            string[] searchData = { "2" };
            Functions.FileEdit.EditLine("testingFile", 4, data, searchIndex, searchData);
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
            Functions.Validation.IsPasswordValid("ABCdef123!()", "ABCdef123!()");
        }
    }
}
