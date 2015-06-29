namespace AnimalHierarchy
{
    using System;
    using AnimalHierarchy.Animals;
    using AnimalHierarchy.Animals.Cats;
    using System.Collections.Generic;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            Animal[] testAnimals = new Animal[] 
            {
                new Animal(),
                new Animal("Unknoun Animal"),
                new Cat("Maro", 4),
                new Cat("Macorana", 3, SexFormat.Female),
                new Kitten("Maci", 1),
                new Tomcat("Rambo razbojnika", 5),
                new Dog("Jony", 2),
                new Dog("Rita", 4, SexFormat.Female),
                new Frog("Crazy", 1, SexFormat.Male),
                new Frog("Jabcho", 2, SexFormat.Male),
                new Dog("Papi")
            };
            foreach (var animal in testAnimals)
            {
                Console.WriteLine(animal.ToString());
                Console.WriteLine(animal.MakeSound());
                Console.WriteLine();
            }
            var avrAges = testAnimals
                .GroupBy(a => a.GetType().Name)
                .Select(gr => new { Kind = gr.Key, AvrAge = gr.Average(x => x.Age)})
                .ToList();
            foreach (var animalKind in avrAges)
            {
                Console.WriteLine("{0} - average age: {1}", animalKind.Kind, animalKind.AvrAge);
            }
        }
    }
}
