namespace P2BankAccounts.Accounts
{
    using System;
    using P2BankAccounts;

    public class AccountDeposit : Account
    {
        public AccountDeposit(AccountType type, Customer accountCustumer, decimal balance, decimal interestRate)
            : base(type, accountCustumer, balance, interestRate)
        { 
        }

        public void Drow(decimal amount)
        {
            if (amount > 0)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("You cannot drow negativ amount.");
            }
        }

        public override decimal InterestForPeriod(int mounts)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return base.InterestForPeriod(mounts);
            }
        }
    }
}
