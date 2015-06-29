namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Human, INameable, ICommentable
    {
        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines { get; set; }
    }
}
