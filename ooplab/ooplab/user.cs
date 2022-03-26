using System;
using System.Collections.Generic;
using System.Text;

namespace ooplab
{
    class user
    {
        string username;
        string password;
        bool isAdmin;

        public user(string username, string password, bool ısAdmin)
        {
            this.Username = username;
            this.Password = password;
            this.IsAdmin = ısAdmin;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool IsAdmin { get => isAdmin; set => isAdmin = value; }
    }
}