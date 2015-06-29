namespace SchoolClasses
{
    using System;

    public class Student : Human, INameable, ICommentable
    {
        private int classNumber;

        public Student(string name)
            : base(name)
        { 
        }

        public Student(string name, int classNumber)
            : this(name)
        {
            this.ClassNumber = classNumber;
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Class number should be positive!");
                }

                this.classNumber = value;
            }
        }
    }
}
