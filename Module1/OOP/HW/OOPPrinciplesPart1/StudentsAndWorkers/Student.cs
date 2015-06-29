namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int age;
        private int grade;

        public Student()
            : base("Nonamed Student")
        { 
        }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
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

        public int Grade
        {
            get 
            {
                return this.grade; 
            }

            set 
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Garade interval is [2;6]");
                }
                this.grade = value; 
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} Grade: {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
