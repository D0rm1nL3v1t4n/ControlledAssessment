using System;
using System.Windows.Forms;

namespace WelshWanderers.Views
{
    public partial class Testing : Form
    {
        public Testing()
        {
            InitializeComponent();
        }


        private void TestOperation_Click(object sender, EventArgs e)
        {
            Console.WriteLine("\n\n");
            Console.WriteLine(Functions.FileSearch.GetNextId("userPersonalDetails"));
        }

        private void TestBackup()
        {
            Functions.Backup.BackupCheck();
        }

        private void TestFileDelete()
        {
            Functions.FileDelete.RemoveLine("testingFile", 5, 3);
        }

        private void TestFileEdit()
        {
            string[] data = { "Aaron", "Johnson", "Red" };
            int[] searchIndex = { 0 };
            string[] searchData = {"2"}; 
            Functions.FileEdit.EditLine("testingFile", 4, data, searchIndex, searchData);
        }

        private void TestFileSearch()
        {
            MessageBox.Show(Functions.FileSearch.ReturnLine("testingFile", "Tony", 1));

            MessageBox.Show(Functions.FileSearch.ReturnSegment("testingFile", "Blue", 3, 1));
            MessageBox.Show(Functions.FileSearch.ReturnSegment("testingFile", "Blue", 3, 1, true));

            MessageBox.Show(Functions.FileSearch.ManyToMany("testingFile", "Green", 3, "Tony", 1));

            MessageBox.Show(Functions.FileSearch.GetNextId("testingFile").ToString());

            MessageBox.Show(Functions.FileSearch.LineNumber("testingFile", "David", 1).ToString());
        }

        private void TestFileWrite()
        {
            string data = "The quick brown fox jumped over the lazy dog. That sentence contains every letter in the alphabet.";
            Functions.FileWrite.WriteData("testingFile", data);
        }

        private void TestHashAlgorithm()
        {
            string password = "ABCDEF12345^&*";
            string hash1 = Functions.HashAlgorithm.HashPassword(password);
            string hash2 = Functions.HashAlgorithm.HashPassword(password);
            
            Console.WriteLine("\n\n");
            Console.WriteLine("Hash1: " + hash1);
            Console.WriteLine("Hash2: " + hash2);
            Console.WriteLine("\n\n");
            
            Console.WriteLine(Functions.HashAlgorithm.CheckHashes(hash1, password).ToString());
            Console.WriteLine(Functions.HashAlgorithm.CheckHashes(hash2, password).ToString());
        }

        private void TestRandomCode()
        {

        }
    }
}
