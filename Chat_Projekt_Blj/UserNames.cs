using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Projekt_Blj
{
    public class UserNames
    {
        public string receiver;

        public string user;

        public void SaveUsername(string userName)
        {
            user = userName;
        }

        public void SaveReceiver(string username)
        {
            receiver = username;
        }
    }
}
