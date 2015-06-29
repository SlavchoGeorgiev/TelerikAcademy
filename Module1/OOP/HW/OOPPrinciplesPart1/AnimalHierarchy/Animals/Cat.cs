namespace AnimalHierarchy.Animals
{
    using System;
    using AnimalHierarchy;

    public class Cat : Animal, ISound
    {
        public Cat(string name)
            : this(name, 0)
        {
        }

        public Cat(string name, int age)
            : this(name, age, SexFormat.Male)
        { 
        }

        public Cat(string name, int age, SexFormat sex)
            : base(name, age, sex)
        { 
        }

        public override string MakeSound()
        {
            return "Cat: marrrrr";
        }
    }
}
