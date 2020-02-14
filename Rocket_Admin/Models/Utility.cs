using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Rocket_Admin.Models
{
    public class Utility
    {
        #region "密碼加密"
        public const int DefaultSaltSize = 5;
        /// <summary>
        /// 產生Salt
        /// </summary>
        /// <returns>Salt</returns>
        
        public static string GenerateHash(string password)
        {
            // merge password and salt together
            string sHash = password;
            // convert this merged value to a byte array
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(sHash);
            // use hash algorithm to compute the hash
            HashAlgorithm algorithm = new SHA256Managed();
            // convert merged bytes to a hash as byte array
            byte[] hash = algorithm.ComputeHash(saltedHashBytes);
            // return the has as a base 64 encoded string
            return Convert.ToBase64String(hash);
        }
        #endregion


    }
}