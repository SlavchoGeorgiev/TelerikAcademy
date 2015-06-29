namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private int age;
        private decimal weekSalary;
        private int workHoursPerDay;
        private const int workDaysPerWeek = 5;

        public Worker()
            : base("N/A")
        { 
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay, int age)
            : this(firstName, lastName, weekSalary, workHoursPerDay)
        {
            this.Age = age;
        }

        public decimal WeekSalary
        {
            get 
            {
                return this.weekSalary; 
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Week salary must be positive number!");
                }
                this.weekSalary = value; 
            }
        }

        public int WorkHoursPerDay
        {
            get 
            {
                return this.workHoursPerDay;
            }

            set
            {

                if (value <= 0 || value > 24)
                {
                    throw new ArgumentOutOfRangeException("Work days must be in interval (0;24]");
                }
                this.workHoursPerDay = value; 
            }
        }
        
        public override int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age must be positive!");
                }
                this.age = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * workDaysPerWeek);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Money per hour: {2:0.00}, Week salary: {3}, Work hour per day: {4}", this.FirstName, this.LastName, this.MoneyPerHour(), this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
