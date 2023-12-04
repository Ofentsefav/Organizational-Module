using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class LoginDetails
    {
        public string Name { get; set; }
        public string Password { get; set; }

        //args constructor to store user details
        public LoginDetails(string name, string password)
        {
            Name = name;
            Password = password;
        }
    }
}
