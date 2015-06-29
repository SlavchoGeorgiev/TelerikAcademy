namespace P2BankAccounts.Accounts
{
    using System;
    using P2BankAccounts;
    using System.Text;

    public abstract class Account
    {
        private decimal interestRate;

        public Account(AccountType type, Customer accountCustumer, decimal balance, decimal interestRate)
        {
            this.Type = type;
            this.AccountCustomer = accountCustumer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public AccountType Type { get; set; }

        public Customer AccountCustomer { get; set; }

        public decimal Balance { get; protected set; }

        public decimal InterestRate
        {
            get 
            {
                return this.interestRate; 
            }

            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest is always positive.");
                }

                this.interestRate = value; 
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
            }
            else
            {
                throw new InvalidOperationException("You cannot deposit negativ amount.");
            }
        }

        public virtual decimal InterestForPeriod(int mounts)
        {
            if (mounts <= 0)
            {
                return 0;
            }

            return this.Balance * mounts * this.InterestRate;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(this.AccountCustomer.ToString());
            result.Append(string.Format("Balance: {0:F2}, Interest rate: {1}, Type: {2}", this.Balance, this.InterestRate, this.Type));
            return result.ToString();
        }
    }
}
