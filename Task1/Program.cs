using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a BankAccount object
            BankAccount myAccount = new BankAccount("ACC123", 500);

            // Display account number
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");

            // Deposit money
            myAccount.Deposit(200); // Deposits 200

            // Withdraw money
            myAccount.Withdraw(100); // Withdraws 100

            // Display remaining balance
            Console.WriteLine($"Remaining Balance: {myAccount.Balance}");
        }
    }
}