using System;

namespace Testing
{
    class TestResult
    {
        public static void TestPass()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PASS");
        }

        public static void TestFail(string info)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FAIL: " + info);
        }
    }
}
