namespace P2BankAccounts
{
    public class Customer : IHuman
    {
        public Customer(string firstName)
            : this(firstName, "", "999999999")
        {
        }

        public Customer(string firstName, string lastName)
            : this(firstName, lastName, "999999999")
        {
        }

        public Customer(string firstName, string lastName, string eikEgn)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EikEgn = eikEgn;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EikEgn { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} EIK/EGN: {2}", this.FirstName, this.LastName, this.EikEgn);
        }
    }
}
