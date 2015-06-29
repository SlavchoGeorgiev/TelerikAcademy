namespace P2BankAccounts.Accounts
{
    using System;
    using P2BankAccounts;

    public class AccountLoan : Account
    {
        public AccountLoan(AccountType type, Customer accountCustumer, decimal balance, decimal interestRate)
            : base(type, accountCustumer, balance, interestRate)
        { 
        }

        public override decimal InterestForPeriod(int mounts)
        {
            if (this.Type == AccountType.Individual)
            {
                return base.InterestForPeriod(mounts - 3);
            }
            else if (this.Type == AccountType.Company)
            {
                return base.InterestForPeriod(mounts - 2);
            }
            else
            {
                throw new ArgumentException("Invalid account type");
            }
        }
    }
}
