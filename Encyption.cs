using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ConstructPOE
{
    public class Encyption
    {
        public string hash(string userpassword)
        {

            SHA1CryptoServiceProvider sHA1 = new SHA1CryptoServiceProvider();
            //passing in the string
            byte[] Password = Encoding.ASCII.GetBytes(userpassword);
            byte[] encyption = sHA1.ComputeHash(Password);
            //convert to hashed
            return Convert.ToBase64String(encyption);
        }
    }
}