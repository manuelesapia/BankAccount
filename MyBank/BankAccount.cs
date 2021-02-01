using System;
using System.Collections.Generic;
using System.Text;

namespace MyBank
{
    class BankAccount
    {

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }
        private static int accountNumberSeed = 123456789;

        private List<Transaction> allTransactions = new List<Transaction>();


        public BankAccount(string name, decimal initiaBalance)
        {
            Owner = name;
            Balance = initiaBalance;
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }


        public void MakeDeposit(decimal amount, DateTime date, string note){


        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {


        }

    }
}
