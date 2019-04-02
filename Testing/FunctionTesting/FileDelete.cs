using System.IO;

namespace Testing
{
    public class FileDelete
    {
        public static void TestFileDelete()
        {
            WelshWanderers.Functions.FileDelete.RemoveLine("testingFile", 3, 4);
            if (File.ReadAllText("testingFile.txt") == "1|1|January\n1|2|June\n2|1|August\n3|3|May")
                TestResult.TestPass();
            else
                TestResult.TestFail("File delete");
        }
    }
}
