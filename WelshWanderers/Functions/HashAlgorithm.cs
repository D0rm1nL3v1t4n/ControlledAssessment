using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace WelshWanderers.Functions
{
    class HashAlgorithm
    {
        public static string HashPassword(string password)
        {
            SHA512 sha512Hash = SHA512.Create();
            byte[] hashedPassword = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

            var cryptoProvider = new RNGCryptoServiceProvider();
            byte[] saltA = new byte[12];
            byte[] saltB = new byte[12];
            cryptoProvider.GetBytes(saltA);
            cryptoProvider.GetBytes(saltB);

            string newPassword = Convert.ToBase64String(hashedPassword);
            
            newPassword = TrimEnd(newPassword);

            return Convert.ToBase64String(saltA) + newPassword + Convert.ToBase64String(saltB);
        }

        private static string TrimEnd(string strPassword)
        {
            string strTrimmed = "";
            char[] characters = strPassword.ToCharArray();
            for (int i = 0; i < 86; ++i)
                strTrimmed +=  characters[i];
            return strTrimmed;
        }

        public static bool CompareHashes(string passwordA, string passwordB)
        {
            string[] arrayPasswordA = passwordA.Split();
            string[] arrayPasswordB = passwordB.Split();

            for (int i = 0; i < 86; ++i)
            {
                if (passwordA[i + 16] != passwordB[i + 16])
                {
                    MessageBox.Show("Password is incorrect.");
                    return false;
                }
            }
            return true;
        }
    }
}
