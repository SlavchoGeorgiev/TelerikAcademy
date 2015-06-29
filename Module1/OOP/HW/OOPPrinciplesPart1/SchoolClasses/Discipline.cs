namespace SchoolClasses
{
    using System;

    public class Discipline : INameable, ICommentable
    {
        private string name;
        private int numExercises;
        private int numLectures;

        public Discipline(string name)
        {
            this.Name = name;
        }

        public Discipline(string name, int numLectures, int numExercises)
            : this(name)
        {
            this.NumLectures = numLectures;
            this.NumExercises = numExercises;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumLectures
        {
            get 
            { 
                return this.numLectures;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.numLectures = value; 
            }
        }

        public int NumExercises
        {
            get 
            {
                return this.numExercises;
            }

            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.numExercises = value;
            }
        }

        public string Comment { get; set; }
    }
}
