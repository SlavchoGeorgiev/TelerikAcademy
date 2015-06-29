namespace MyStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Student
    {
        private int age;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public List<double> Marks { get; set; }

        public int GroupNumber { get; set; }
        
        public int Age
        {
            get 
            { 
                return this.age; 
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age must be positive.");
                }

                this.age = value;
            }
        }
    }
}
