namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;

    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string courseName)
            : base(courseName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : base(courseName, teacherName)
        {
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : base(courseName, teacherName, students)
        {
        }

        public string Town 
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
            return base.ToString("Town");
        }
    }
}
