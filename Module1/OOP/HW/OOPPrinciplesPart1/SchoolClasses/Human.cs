namespace SchoolClasses
{
    using System;

    public class Human : INameable, ICommentable
    {
        private string name;

        public Human(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get 
            { 
                return this.name;
            }

            protected set 
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]) && value[i] != ' ')
                    {
                        throw new FormatException(string.Format("Human name can contain only letters. (not {0})",value[i]));
                    }
                }

                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.name = value; 
            }
        }

        public virtual string Comment { get; set; }
    }
}
