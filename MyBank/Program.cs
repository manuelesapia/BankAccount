using System;

namespace MyBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Manuel", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}. ");
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);
        }
    }
}
