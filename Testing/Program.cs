using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing:\n");
            InitialTest();
            Console.ResetColor();
            Console.WriteLine("\n\nPress Enter to exit.");
            Console.ReadLine();
        }

        private static void InitialTest()
        {
            File.WriteAllText("testingFile.txt", string.Empty);

            //Validation.TestValidation();
            //FileWrite.TestFileWrite();
            FileSearch.TestFileSearch();
            FileEdit.TestFileEdit();
            FileDelete.TestFileDelete();
            //SendEmail.TestSendEmail();
            RandomCode.TestRandomCode();
            HashAlgorithm.TestHashAlgorithm();
            
            
        }


    }
}
