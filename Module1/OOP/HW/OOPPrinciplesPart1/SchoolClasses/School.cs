namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School : INameable
    {
        private string name;

        private List<Class> classes;

        public School()
        {
            this.Classes = new List<Class>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        
        public List<Class> Classes
        {
            get { return this.classes; }
            set { this.classes = value; }
        }
    }
}
