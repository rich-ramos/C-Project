using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsBankAccountDemo01
{
    public class Account
    {
        private string accountName;
        private int balance;

        public string AccountName
        {
            get
            {
                return accountName;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
        }

        public Account(string name, int balanceAmount)
        {
            accountName = name;
            balance = balanceAmount;
        }
    }
}
