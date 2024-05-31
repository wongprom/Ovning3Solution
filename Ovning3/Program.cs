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
                Person peter = new Person(age: 3, height: 150, weight: 50, firstName: "Peter", lastName: "Pett");
                personHandler.SetAge(peter, 1);
                //personHandler.DisplayPersonDetails(peter);

                Person kalle = personHandler.CreatePerson(23, "Kalle", "Anka", 120, 50);
                //personHandler.DisplayPersonDetails(kalle);

                Person fredrik = personHandler.CreatePerson();
                //personHandler.DisplayPersonDetails(fredrik);
                personHandler.SetFName(fredrik, "Fredrik");
                personHandler.SetLName(fredrik, "Fredriksson");
                personHandler.SetAge(fredrik, 15);
                personHandler.SetHeight(fredrik, 174);
                personHandler.SetWeight(fredrik, 102);
                //personHandler.DisplayPersonDetails(fredrik);

                /*List<UseError> errorList = new List<UseError>();
                NumericInputError numericInputError = new NumericInputError();
                TextInputError textInputError = new TextInputError();
                errorList.Add(numericInputError);
                errorList.Add(textInputError);
                foreach (UseError error in errorList)
                {
                    Console.WriteLine(error.UEMessage());
                }*/

                /* List<Print> printList = new List<Print>();
                 Print printOne = new PrintOne();
                 Print printTwo = new PrintTwo();
                 Print printThree = new PrintThree();
                 printList.Add(printOne);
                 printList.Add(printTwo);
                 printList.Add(printThree);
                 foreach (Print print in printList)
                 {
                     Console.Write(print.PrintThis());
                 }*/

                List<Animal> animalsList = new List<Animal>();
                Wolfman wolfMan = new Wolfman("jimmy", 34, 34, true);
                Swan svan = new Swan("Svan", 23, 3, 2, true);
                Flamingo flamingo = new Flamingo("flam", 1, 2, 3, false);
                Wolf wolf = new Wolf("wolf", 3, 200, true);
                Pelican pelican = new Pelican("pelican", 3, 3, 4,false);
                Bird bird = new Bird("Bird", 3, 4, 2);
                Worm worm = new Worm("worm", 3, 34, false);
                Hedgehog hedgehog = new Hedgehog("Hedgehog", 3, 45, 2);
                Dog dog = new Dog("dog", 3, 3,false);
                Horse horse = new Horse("Horse", 2,2,true);
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
                    if(animal is IPerson test)
                    {
                        test.Talk();
                    }
                    animal.DoSound();
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
