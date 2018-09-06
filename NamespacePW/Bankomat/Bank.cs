using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bank
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public const string ClientPassword = "123456";

        public const string WalletNumber = "1234 5678 9012 1234";

        public string GetClientPassword()
        {
            return ClientPassword;
        }

        public string GetWalletNumber()
        {
            return WalletNumber;
        }
    }
}
