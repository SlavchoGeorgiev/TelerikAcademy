namespace AnimalHierarchy.Animals.Cats
{
    using System;
    using AnimalHierarchy;
    using AnimalHierarchy.Animals;

    public class Kitten : Cat, ISound
    {
        public Kitten(string name)
            : this(name, 0)
        { 
        }

        public Kitten(string name, int age)
            : base(name, age, SexFormat.Female)
        { 
        }

        public override string MakeSound()
        {
            return "Kitten: miau";
        }
    }
}
