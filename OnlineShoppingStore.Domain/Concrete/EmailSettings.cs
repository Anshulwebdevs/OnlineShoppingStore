using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingStore.Domain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "anshul@localhost.com";
        public string MailFromAddress = "anshul@localhost.com";
        public bool UseSsl = false;
        public string Username = "anshul@localhost.com";
        public string Password = "1234";
        public string ServerName = "127.0.0.1";
        public int ServerPort = 25;
    }
}
