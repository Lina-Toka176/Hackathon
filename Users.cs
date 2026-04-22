using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Реактор_22_04
{
    internal class Users
    {
        private string Login;
        private int Password;

        public string _login { get { return Login; } }
        public int _password { get { return Password; } }

        public Users(string _login, int _password)
        {
            Login = _login;
            Password = _password;
        }
    }
}
