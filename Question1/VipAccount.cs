using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    // Shani Maroz
    // 211579263

    // Derived class for VIP accounts with overdraft support
    internal class VipAccount : Account
    {
        protected double overdraftLimit;

        // Initialize the overdraft limit
        public VipAccount(int accountNumber, double balance) : base(accountNumber, balance)
        {
            this.overdraftLimit = -5000;
        }

        // Overrides the Withdraw method
        public override void Withdraw(double amount)
        {
            // Checks if the withdraw amount and the balance are valid compared to the overdraft limit
            if (balance - amount >= overdraftLimit)
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
