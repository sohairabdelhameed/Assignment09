using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment09.Question02_Authentication
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string storedUsername = "sohair";
        private readonly string storedPassword = "123456";
        private readonly string storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
