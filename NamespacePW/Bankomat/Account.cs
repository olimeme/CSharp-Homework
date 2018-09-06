using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Bankomat
{
    public class Account
    {
        public string Password { get; set; }

        public string WalletNumber { get; set; }

        public int WalletBalance { get; set; }

        public Account(string password, string walletNumber, int walletBalance = 0)
        {
            Password = password;
            WalletNumber = walletNumber;
            WalletBalance = walletBalance;
        }

        public bool IsPasswordValid(string password)
        {
            return (password == Password);
        }

        public void AddWalletBalance(int amount)
        {
            WalletBalance += amount;
        }

        public void WithdrawMoney(int amount)
        {
            if (amount > WalletBalance)
                WriteLine("Не достаточно средств!");
            else
                WalletBalance -= amount;
        }
    }
}
