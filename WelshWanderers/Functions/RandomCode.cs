using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelshWanderers.Functions
{
    public class RandomCode
    {
        public static string GenerateCode(int length)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringCharacters = new char[length];
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                stringCharacters[i] = characters[random.Next(characters.Length)];
            }
            return new String(stringCharacters);
        }

    }
}
