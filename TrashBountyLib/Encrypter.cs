using System.Security.Cryptography;
using System;

namespace TrashBountyLib
{
    public class Encrypter
    {
        const int passBytes = 40; // Total amount of bytes in the password
        const int iterationCount = 100; // Iteration count for the Rfc2898DeriveBytes objects

        static public string Hash(string password)
        {
            string hashPass = string.Empty;

            // Create the salt
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[passBytes / 2]);

            // Get the hash value
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterationCount);
            byte[] hash = pbkdf2.GetBytes(passBytes / 2);

            // Combine the salt and password bytes
            byte[] hashBytes = new byte[passBytes];
            Array.Copy(salt, 0, hashBytes, 0, passBytes / 2);
            Array.Copy(hash, 0, hashBytes, passBytes / 2, passBytes / 2);

            // Turn the salt+hash into a string
            hashPass = Convert.ToBase64String(hashBytes);

            return hashPass;
        }

        // test is the password you want to validate, pass is the hash password you want to validate against
        static public bool Validate(string test, string pass)
        {
            bool result = true;

            // Extract the bytes
            byte[] hashBytes = Convert.FromBase64String(pass);
            // Get the salt
            byte[] salt = new byte[passBytes / 2];
            Array.Copy(hashBytes, 0, salt, 0, passBytes / 2);
            // Hash the user's password
            var pbkdf2 = new Rfc2898DeriveBytes(test, salt, iterationCount);
            byte[] hash = pbkdf2.GetBytes(passBytes / 2);
            // Compare the results
            for (int i = 0; i < passBytes / 2; i++)
            {
                if (hashBytes[i + passBytes / 2] != hash[i])
                    return false;
            }

            return result;
        }
    }
}
