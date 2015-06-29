namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : ICommentable
    {
        public Class(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
        }

        public Class(string textIdentifire, List<Student> students)
            : this(textIdentifire)
        {
            this.Students = students;
        }

        public Class(string textIdentifire, List<Student> students, List<Teacher> teachers)
            : this(textIdentifire, students)
        {
            this.Teachers = teachers;
        }

        public string TextIdentifier { get; set; }

        public List<Student> Students { get; set; }

        public List<Teacher> Teachers { get; set; }

        public virtual string Comment { get; set; }
    }
}
