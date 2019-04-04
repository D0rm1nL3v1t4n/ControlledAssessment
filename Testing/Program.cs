using System;
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
            Validation.TestValidation();
        }


    }
}
