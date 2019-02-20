using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class RandomCode
    {
        public static void TestRandomCode()
        {
            string code1 = WelshWanderers.Functions.RandomCode.GenerateCode(10);
            string code2 = WelshWanderers.Functions.RandomCode.GenerateCode(10);
            string code3 = WelshWanderers.Functions.RandomCode.GenerateCode(10);
            string code4 = WelshWanderers.Functions.RandomCode.GenerateCode(4);
            string code5 = WelshWanderers.Functions.RandomCode.GenerateCode(17);
            if ((code1 != code2 && code1 != code3) && (code1.Length == code2.Length && code1.Length == code3.Length) && code4.Length == 4 && code5.Length == 17)
                TestResult.TestPass();
            else
                TestResult.TestFail("Random code");
        }
    }
}
