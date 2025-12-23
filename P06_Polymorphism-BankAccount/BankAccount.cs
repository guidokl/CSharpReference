using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Polymorphism_BankAccount
{
    internal class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public string AccountType { get; set; }
        // Potected set to allow modification only within this class and derived classes
        // Polymorphism allows derived classes to modify Balance
        public decimal Balance { get; protected set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            AccountType = "Daily";
            Balance = 0;
        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Deposit amount must be positive.";
            if (amount > 10000)
                return "Deposit amount exceeds the maximum limit of $10,000.";

            Balance += amount;
            return $"{Owner} deposited {amount}. New balance is {Balance}.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "Withdrawal amount must be positive.";
            if (amount > Balance)
                return "Insufficient funds for this withdrawal.";

            Balance -= amount;
            return $"{Owner} withdrew {amount}. New balance is {Balance}.";
        }
    }
}
