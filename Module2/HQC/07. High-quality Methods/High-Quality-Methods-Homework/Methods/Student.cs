namespace Methods
{
    using System;

    public class Student
    {
        private const int MinNameLength = 2;

        private const int MaxNameLength = 30;

        private string firstName;
        
        private string lastName;
        
        private string birthTown;

        public Student(string firstName, string lastName, string birthTown, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthTown = birthTown;
            this.BirthDate = birthDate;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Student.ValidateName(value, "First name");
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Student.ValidateName(value, "Last name");
                this.lastName = value;
            }
        }

        public string BirthTown
        {
            get
            {
                return this.BirthTown;
            }

            private set
            {
                this.birthTown = value;
            }
        }

        public DateTime BirthDate { get; private set; }

        public bool IsOlderThan(Student student)
        {
            return this.BirthDate < student.BirthDate;
        }

        private static void ValidateName(string name, string type)
        {
            if (name == null)
            {
                throw new ArgumentNullException(string.Format("{0} cannot be null!", type));
            }

            if (name.Length < Student.MinNameLength || Student.MaxNameLength < name.Length)
            {
                throw new ArgumentOutOfRangeException(string.Format("Name must be in interval [{0}, {1}]", Student.MinNameLength, Student.MaxNameLength));
            }
        }
    }
}
