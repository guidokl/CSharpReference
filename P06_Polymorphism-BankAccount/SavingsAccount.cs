using P06_Polymorphism_BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Polymorphism_BankAccount
{
    internal class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate) : base(owner)
        {
            AccountType = "Savings";
            InterestRate = interestRate;
        }

        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Deposit amount must be positive.";
            if (amount > 10000)
                return "Deposit amount exceeds the maximum limit of $10,000.";

            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return $"{Owner} deposited {amount}. New balance is {Balance}.";
        }
    }
}
