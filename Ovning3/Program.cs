using System.Collections.Generic;

namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                PersonHandler personHandler = new PersonHandler();
            try
            {
                List<Animal> animalsList = new List<Animal>();
                Wolfman wolfMan = new Wolfman("jimmy", 34, 34, true);
                Swan svan = new Swan("Svan", 23, 3, 2, true);
                Flamingo flamingo = new Flamingo("flam", 1, 2, 3, false);
                Wolf wolf = new Wolf("wolf", 3, 200, true);
                Pelican pelican = new Pelican("pelican", 3, 3, 4, false);
                Bird bird = new Bird("Bird", 3, 4, 2);
                Worm worm = new Worm("worm", 3, 34, false);
                Hedgehog hedgehog = new Hedgehog("Hedgehog", 3, 45, 2);
                Animal dog = new Dog("dog", 3, 3, false);
                Horse horse = new Horse("Horse", 2, 2, true);
                animalsList.Add(wolfMan);
                animalsList.Add(worm);
                animalsList.Add(svan);
                animalsList.Add(flamingo);
                animalsList.Add(wolf);
                animalsList.Add(bird);
                animalsList.Add(pelican);
                animalsList.Add(hedgehog);
                animalsList.Add(dog);
                animalsList.Add(horse);

                foreach (Animal animal in animalsList)
                {
                    if (animal is Pelican objPelican)
                    {
                        Console.WriteLine(objPelican.Stats());
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
                // ToDo what does throw;
            }
        }
    }
}
