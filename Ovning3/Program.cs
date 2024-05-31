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
               

                List<Object> listForAllTypes = new List<Object>();
                Horse horse = new Horse("Horse", 2,2,true);
                Person peter = new Person(age: 3, height: 150, weight: 50, firstName: "Peter", lastName: "Pett");
                TextInputError inputError = new TextInputError();
                listForAllTypes.Add(horse);
                listForAllTypes.Add(peter);
                listForAllTypes.Add(inputError);
                


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
