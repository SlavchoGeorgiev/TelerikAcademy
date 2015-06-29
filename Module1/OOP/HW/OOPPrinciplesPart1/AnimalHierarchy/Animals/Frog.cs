namespace AnimalHierarchy.Animals
{
    using System;
    using AnimalHierarchy;

    public class Frog : Animal, ISound
    {
        public Frog(string name)
            : this(name, 0)
        {
        }

        public Frog(string name, int age)
            : this(name, age, SexFormat.Male)
        { 
        }

        public Frog(string name, int age, SexFormat sex)
            : base(name, age, sex)
        { 
        }

        public override string MakeSound()
        {
            return "Frog: Krqak krqk kra";
        }
    }
}
