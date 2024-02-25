using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Hacker
    {
        public string username = "securityGod82";
        public string password = "mySuperSecretPassword";

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        public int Id { get; set; }

        public double BankAccountBalance { get; set; }
        public void DownloadAllBankAccountsInTheWorld()
        {
        }
    }
}
