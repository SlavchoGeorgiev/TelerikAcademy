namespace P2BankAccounts.Accounts
{
    using System;
    using P2BankAccounts;

    public class AccountMortgage : Account
    {
        public AccountMortgage(AccountType type, Customer accountCustumer, decimal balance, decimal interestRate)
            : base(type, accountCustumer, balance, interestRate)
        { 
        }

        public override decimal InterestForPeriod(int mounts)
        {
            if (this.Type == AccountType.Individual)
            {
                return base.InterestForPeriod(mounts - 6);
            }
            else if (this.Type == AccountType.Company)
            {
                if (mounts < 12)
                {
                    return base.InterestForPeriod(mounts) / 2;
                }
                else
                {
                    return base.InterestForPeriod(mounts - 6);
                }
            }
            else
            {
                throw new ArgumentException("Invalid account type");
            }
        }
    }
}
