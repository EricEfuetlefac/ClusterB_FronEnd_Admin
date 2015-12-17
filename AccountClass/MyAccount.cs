using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace AccountClass
{
    class MyAccount
    {
        public double currentBalance = 500;
        public double amount = 0;

        public String deposit(double amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(Contract.OldValue(currentBalance) + amount == currentBalance);
            currentBalance += amount;
            return "Your Current Balance is: " + currentBalance;
        }


        public String withdraw(double amount)
        {
            Contract.Requires(currentBalance > amount);
            Contract.Requires(amount > 0);
            Contract.Requires(currentBalance >= amount);
            Contract.Ensures(Contract.OldValue(currentBalance).Equals(amount + currentBalance));
            this.amount = amount;
            currentBalance = currentBalance - amount;

            return "Balance: " + currentBalance;
        }
        
        
    }
}
