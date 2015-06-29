namespace AnimalHierarchy.Animals.Cats
{
    using System;
    using AnimalHierarchy;
    using AnimalHierarchy.Animals;

    public class Tomcat : Cat, ISound
    {
        public Tomcat(string name)
            : this(name, 0)
        { 
        }

        public Tomcat(string name, int age)
            : base(name, age, SexFormat.Male)
        { 
        }

        public override string MakeSound()
        {
            return "Tomcat: Miauuuuuchhhhhhh";
        }
    }
}
