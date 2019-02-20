using System.Linq;
using System.IO;
using System;

namespace Testing
{
    public class FileWrite
    {
        public static void TestFileWrite()
        {
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "Hello world.");
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "This file should have two lines.");
            string allText = File.ReadAllText("testingFile.txt");
            if (allText == "Hello world.\nThis file should have two lines.")
                TestResult.TestPass();
            else
                TestResult.TestFail("File write");

            Console.ResetColor();
            Console.WriteLine("Line count: " + File.ReadAllLines("testingFile.txt").Count());
            Console.WriteLine("Text:\n" + allText);
            Console.WriteLine("--");
            //File.WriteAllText("testingFile.txt", string.Empty);
        }
    }
}
