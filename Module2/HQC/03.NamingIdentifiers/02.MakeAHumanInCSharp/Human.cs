namespace _02.MakeAHumanInCSharp
{
    public class Human
    {
        public Human(string name, Gender gender, int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }

        public string Name { get; set; }

        public Gender Gender { get; set; }

        public int Age { get; set; }

        public string Introduce()
        {
            return string.Format("I am {0} {1} years old, and i am {2}", this.Name, this.Age, this.Gender);
        }
    }
}
