/*
 * Refactor the following examples to produce code with well-named C# identifiers.
 * 
 class Hauptklasse
{
  enum Пол { ултра_Батка, Яка_Мацка };
  class чуек
  {
    public Пол пол { get; set; }
    public string име_на_Чуека { get; set; }
    public int Възраст { get; set; }
  }       
  public void Make_Чуек(int магическия_НомерНаЕДИНЧОВЕК)
  {
    чуек new_Чуек = new чуек();
    new_Чуек.Възраст = магическия_НомерНаЕДИНЧОВЕК;
    if (магическия_НомерНаЕДИНЧОВЕК%2 == 0)
    {
      new_Чуек.име_на_Чуека = "Батката";
      new_Чуек.пол = Пол.ултра_Батка;
    }
    else
    {
      new_Чуек.име_на_Чуека = "Мацето";
      new_Чуек.пол = Пол.Яка_Мацка;
    }
  }
}
 */

namespace _02.MakeAHumanInCSharp
{
    using System;

    private class Test
    {
        private static void Main()
        {
            var testMan = new Human("Ivan", Gender.Male, 19);
            var testGirl = new Human("Matia", Gender.Female, 17);
            var superMan = MakeSuperHuman(20);
            var superGirl = MakeSuperHuman(17);

            Console.WriteLine(testMan.Introduce());
            Console.WriteLine(testGirl.Introduce());
            Console.WriteLine(superMan.Introduce());
            Console.WriteLine(superGirl.Introduce());
        }

        private static Human MakeSuperHuman(int age)
        {
            Human superHuman;

            if (age % 2 == 0)
            {
                superHuman = new Human("Батката", Gender.Male, age);
            }
            else
            {
                superHuman = new Human("Мацето", Gender.Female, age);
            }

            return superHuman;
        }
    }
}
