using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileShare
{
    class User
    {
        string userName;
        string displayName;
        string password;

        public string UserName {
            get { return userName; }
            set { userName = value; }
        }

        public string DisplayName {
            get { return displayName; }
            set { displayName = value; }
        }

        public string Password {
            get { return password; }
            set { password = value; }
        }
    }
}
