namespace AnimalHierarchy.Animals
{
    using System;
    using AnimalHierarchy;

    public class Dog : Animal, ISound
    {
        public Dog(string name)
            : this(name, 0)
        {
        }

        public Dog(string name, int age)
            : this(name, age, SexFormat.Male)
        { 
        }

        public Dog(string name, int age, SexFormat sex)
            : base(name, age, sex)
        { 
        }

        public override string MakeSound()
        {
            return "Dog: Bau Bau";
        }
    }
}
