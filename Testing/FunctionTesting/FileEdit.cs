using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WelshWanderers.Functions;
using System.IO;

namespace Testing
{
    public class FileEdit
    {
        public static void TestFileEdit()
        {
            string[] data = { "June" };
            int[] searchIndex = { 0, 1 };
            string[] searchData = { "1", "2" };
            WelshWanderers.Functions.FileEdit.EditLine("testingFile", 3, data, searchIndex, searchData);

            string[] data2 = { "5", "August" };
            int[] searchIndex2 = { 0 };
            string[] searchData2 = { "2" };
            WelshWanderers.Functions.FileEdit.EditLine("testingFile", 3, data2, searchIndex2, searchData2);

            if (File.ReadAllText("testingFile.txt") == "1|1|January\n1|2|June\n2|1|August\n3|1|April\n3|3|May")
                TestResult.TestPass();
            else
                TestResult.TestFail("File edit");
        }
    }
}
