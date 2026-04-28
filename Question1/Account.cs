using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    // Shani Maroz
    // 211579263

    // Base class for account management
    internal class Account
    {
        protected int accountNumber;
        protected double balance;


        // Initialize the account number and the balance
        public Account(int accountNumber, double balance) 
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }


        // Withdraw method, which allows overriding
        public virtual void Withdraw(double amount)
        {
            // Checks if the withdraw amount and the balance are valid
            if (balance > 0 && (balance >= amount))
            {
                balance -= amount;
                Console.WriteLine($"Successfully withdrew {amount}, New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

    }
}
