namespace StudentsAndWorkers
{
    public abstract class Human
    {
        public Human(string firstName)
        {
            this.FirstName = firstName;
        }

        public Human(string firstName, string lastName) : this(firstName)
        {
            this.LastName = lastName;
        }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public abstract int Age { get; set; }
    }
}
