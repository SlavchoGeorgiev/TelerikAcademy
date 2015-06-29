namespace P2BankAccounts
{
    using System;
    using P2BankAccounts.Accounts;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            Account[] accounts = new Account[] 
            {
                new AccountDeposit(AccountType.Company, new Customer("Telerik AD"), 500M, 1.2M),
                new AccountDeposit(AccountType.Individual, new Customer("Petar", "Petrov"), 1100M, 1.3M),
                new AccountLoan(AccountType.Company, new Customer("Microsoft Corp"), 350.65M, 1.6M),
                new AccountLoan(AccountType.Individual, new Customer("Gosho", "Goshov"), 8000.65M, 1.11M),
                new AccountMortgage(AccountType.Individual, new Customer("Gosho", "Goshov"), 100.11M, 1.41M),
                new AccountMortgage(AccountType.Company, new Customer("Facebook Ltd"), 100.11M, 1.41M)
            };
            foreach (var acc in accounts)
            {
                Console.WriteLine(acc);
                Console.WriteLine();
            }
            Console.WriteLine();
            foreach (var acc in accounts)
            {
                Random rg = new Random();
                System.Threading.Thread.Sleep(10);
                acc.Deposit((decimal)(rg.Next(0, 1000) * rg.NextDouble()));
                Console.WriteLine("Account type: {0}", acc.GetType().Name);
                Console.WriteLine(acc);
                int mounts = rg.Next(0, 16);
                Console.WriteLine("Interest for {0} mount: {1:F2}", mounts, acc.InterestForPeriod(mounts));
                Console.WriteLine();
            }
        }
    }
}
