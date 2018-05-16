using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMarketApp
{
    public class Person
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } 

        public bool Control(string username, string password)
        {
            bool rightUsername = false;
            bool rightPassword = false;

            if (this.UserName.Equals(username))
                rightUsername = true;

            if (this.Password.Equals(password))
                rightPassword = true;

            if (rightUsername && rightPassword)
                return true;

            return false;
        }

    }
}
