using System.IO;

namespace Testing
{
    public class FileSearch
    {
        public static void TestFileSearch()
        {
            File.WriteAllText("testingFile.txt", string.Empty);
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "0|Nimrod|Abramovich|30 August 2001|12nabramovich@stanwell.org");
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "1|Dormin|Levitan|15 April 1998|nimrodabramovich2001@gmail.com");

            ReturnSegment();
            ReturnLine();
            LineNumber();
            GetNextId();

            File.WriteAllText("testingFile.txt", string.Empty);
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "1|1|January");
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "1|2|February");
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "2|1|March");
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "3|1|April");
            WelshWanderers.Functions.FileWrite.WriteData("testingFile", "3|3|May");

            ManyToMany();
        }

        private static void ReturnSegment()
        {
            if (WelshWanderers.Functions.FileSearch.ReturnSegment("testingFile", "Dormin", 1, 4) == "nimrodabramovich2001@gmail.com" &&
                WelshWanderers.Functions.FileSearch.ReturnSegment("testingFile", "0", 0, 3) == "30 August 2001" &&
                WelshWanderers.Functions.FileSearch.ReturnSegment("testingFile", "John", 1, 2) == null)
                TestResult.TestPass();
            else
                TestResult.TestFail("File search - Return segment");
        }

        private static void ReturnLine()
        {
            if (WelshWanderers.Functions.FileSearch.ReturnLine("testingFile", "0", 0) == "0|Nimrod|Abramovich|30 August 2001|12nabramovich@stanwell.org" &&
                WelshWanderers.Functions.FileSearch.ReturnLine("testingFile", "Levitan", 2) == "1|Dormin|Levitan|15 April 1998|nimrodabramovich2001@gmail.com" &&
                WelshWanderers.Functions.FileSearch.ReturnLine("testingFile", "Thomas", 1) == null)
                TestResult.TestPass();
            else
                TestResult.TestFail("File search - Return line");
        }

        private static void LineNumber()
        {
            if (WelshWanderers.Functions.FileSearch.LineNumber("testingFile", "Levitan", 2) == 2 &&
                WelshWanderers.Functions.FileSearch.LineNumber("testingFile", "0", 0) == 1 && WelshWanderers.Functions.FileSearch.LineNumber("testingFile", "Bob", 1) == 0)
                TestResult.TestPass();
            else
                TestResult.TestFail("File search - Line number");
        }

        private static void GetNextId()
        {
            bool test1 = WelshWanderers.Functions.FileSearch.GetNextId("testingFile") == 3;
            WelshWanderers.Functions.FileWrite.WriteData("testingFile2", null);
            bool test2 = WelshWanderers.Functions.FileSearch.GetNextId("testingFile2") == 1;
            if (test1 && test2)
                TestResult.TestPass();
            else
                TestResult.TestFail("File search - Get next id");
        }

        private static void ManyToMany()
        {
            if (WelshWanderers.Functions.FileSearch.ManyToMany("testingFile", "1", 0, "1", 1) == "1 | 1 | January" &&
                WelshWanderers.Functions.FileSearch.ManyToMany("testingFile", "1", 1, "3", 0) == "3|1|April" &&
                WelshWanderers.Functions.FileSearch.ManyToMany("testingFile", "4", 0, "2", 1) == null)
                TestResult.TestPass();
            else
                TestResult.TestFail("File search - Many to many");
        }
    }
}
