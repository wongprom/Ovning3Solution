﻿namespace Ovning3
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

                List<Print> printList = new List<Print>();
                Print printOne = new PrintOne();
                Print printTwo = new PrintTwo();
                Print printThree = new PrintThree();
                printList.Add(printOne);
                printList.Add(printTwo);
                printList.Add(printThree);
                foreach (Print print in printList)
                {
                    Console.Write(print.PrintThis());
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
