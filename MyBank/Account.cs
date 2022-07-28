using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, string accountType, double balance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            Balance = balance;
        }
    }
}
