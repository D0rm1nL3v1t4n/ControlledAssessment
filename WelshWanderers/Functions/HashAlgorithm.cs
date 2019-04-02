using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WelshWanderers.Functions
{
    public class HashAlgorithm
    {
        public static string HashPassword(string password)
        {
            byte[] salt;    //declares a byte array called salt
            //uses function from System.Security.Cryptography library to generate a salt
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            //hashes the salt and password, passing it through the hashing algorithm 10000 times
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000); 

            byte[] hash = pbkdf2.GetBytes(20);  //sets an byte array to be 20 bytes long
            byte[] hashBytes = new byte[36];    //defines a new byte array to be 36 bytes long

            Array.Copy(salt, 0, hashBytes, 0, 16);  //places the salt in index 0 to 16
            Array.Copy(hash, 0, hashBytes, 16, 20); //places the hash in index 17 to 36

            return Convert.ToBase64String(hashBytes);   //converts byte array to base 64 string
        }

        public static bool CheckHashes(string savedHash, string enteredPassword)
        {
            byte[] hashBytes = Convert.FromBase64String(savedHash); //converts to byte array from base 64 string
            byte[] salt = new byte[16]; //defintes a byte array for the salt

            Array.Copy(hashBytes, 0, salt, 0, 16);  //copies the salt from the saved hash into the byte array
            //hashes the salt and password, passing it through the hashing algorithm 10000 times
            var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, 10000);  

            byte[] hash = pbkdf2.GetBytes(20);  //sets an byte array to be 20 bytes long

            for (int i = 0; i < 20; ++i)    //loops for each byte in the byte array for hash
            {   //checks if the saved hash and the newly hashed password have the same character at index i
                if (hashBytes[i + 16] != hash[i])   
                {   //if passwords dont match
                    MessageBox.Show("Password is incorrect.");
                    return false;   //returns false if passwords dont match
                }
            }
            return true;    //returns true if password match
        }

        

    }
}
