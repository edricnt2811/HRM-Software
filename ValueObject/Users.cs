using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Users
    {
        public string Username { get; set; }

        public string Pass { get; set; }

        public string StatusLogin { get; set; }

        public Users() { }

        public Users(string _user, string _pass)
        {
            this.Username = _user;
            this.Pass = _pass;
        }
    }
}
