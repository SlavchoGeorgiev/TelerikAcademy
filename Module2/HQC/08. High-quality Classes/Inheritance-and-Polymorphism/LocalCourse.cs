namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class LocalCourse : Course
    {
        public LocalCourse(string courseName)
            : base(courseName)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public string Lab 
        {
            get
            {
                return base.Location;
            }

            set
            {
                base.Location = value;
            }
        }

        public override string ToString()
        {
            return base.ToString("Lab");
        }
    }
}
