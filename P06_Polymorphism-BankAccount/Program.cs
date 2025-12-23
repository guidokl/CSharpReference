// Real-world Example   = Applying polymorphism to business logic
//                        All accounts share properties (Balance, Owner)
//                        But specific logic (CalculateInterest) differs per type

namespace P06_Polymorphism_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount("Alice");
            SavingsAccount savingsAccount1 = new SavingsAccount("Bob", 3);

            // Polymorphic behavior in action by calling the overridden Deposit method
            Console.WriteLine(bankAccount1.Deposit(1000));
            Console.WriteLine(savingsAccount1.Deposit(1000));

            // SavingsAccount is a derived class of BankAccount, so we can use a BankAccount reference
            List<BankAccount> accounts = new List<BankAccount> { bankAccount1, savingsAccount1 };
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account Owner: {account.Owner}, Balance: {account.Balance}");
            }
        }
    }
}
