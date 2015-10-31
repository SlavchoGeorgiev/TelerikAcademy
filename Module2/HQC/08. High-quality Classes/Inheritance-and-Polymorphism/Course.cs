namespace InheritanceAndPolymorphism
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        private const string TeacherNameDefaultValue = null;
        private const string LocationDefaultValue = null;

        protected Course(string courseName)
            : this(courseName, TeacherNameDefaultValue, new List<string>())
        {
        }

        protected Course(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>())
        {
        }

        protected Course(string courseName, string teacherName, IList<string> students)
        {
            this.Name = courseName;
            this.TeacherName = teacherName;
            this.Students = students;
            this.Location = LocationDefaultValue;
        }

        public string Name { get; set; }

        public string TeacherName { get; set; }

        public IList<string> Students { get; set; }

        protected string Location { get; set; }

        protected string ToString(string courseLocationType)
        {
            StringBuilder result = new StringBuilder();

            result.Append(string.Format("{0} {{ Name = ", this.GetType().Name));
            result.Append(this.Name);

            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());

            if (this.Location != null)
            {
                result.Append(string.Format("; {0} = ", courseLocationType));
                result.Append(this.Location);
            }

            result.Append(" }");

            return result.ToString();
        }

        protected virtual string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "{ }";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }
    }
}
