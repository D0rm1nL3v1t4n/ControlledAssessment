using System;

namespace WelshWanderers.Functions
{
    public class RandomCode
    {
        private static Random random = new Random();  //uses a new random generator

        public static string GenerateCode(int length)
        {   //defines the set of characters that can be used when generating the code
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringCharacters = new char[length];    //sets a char array of length n
            for (int i = 0; i < length; i++)    //loops for the length of the char array defined
            {   //sets the value in the array at position i to be a random character from the set above
                stringCharacters[i] = characters[random.Next(characters.Length)];
            }
            return new String(stringCharacters);    //converts the char array to string and returns
        }

    }
}
