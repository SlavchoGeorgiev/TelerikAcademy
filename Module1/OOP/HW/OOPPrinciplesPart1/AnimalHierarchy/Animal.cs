namespace AnimalHierarchy
{
    using System;

    public class Animal : ISound
    {
        private int age;
        private string name;
        private SexFormat sex;

        public Animal()
            : this("Unnamed Animal", 0, SexFormat.Male)
        {
        }

        public Animal(string name)
            : this(name, 0, SexFormat.Male)
        {
        }

        public Animal(string name, int age)
            : this(name, age, SexFormat.Male)
        { 
        }

        public Animal(string name, int age, SexFormat sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public int Age
        {
            get 
            {
                return this.age; 
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Age must be positive integer number. Not {0}", value));
                }

                this.age = value; 
            }
        }

        public string Name
        {
            get 
            {
                return this.name; 
            }

            set
            {
                this.name = value; 
            }
        }

        public virtual SexFormat Sex
        {
            get 
            {
                return this.sex; 
            }

            set 
            {
                this.sex = value; 
            }
        }

        public virtual string MakeSound()
        {
            return "I am Animal";
        }

        public override string ToString()
        {
            return string.Format("I am {0} {1} year old and i am {2}", this.Name, this.Age, this.Sex == SexFormat.Male ? "boy":"girl");
        }
    }
}
