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
                personHandler.DisplayPersonDetails(peter);

                Person kalle = personHandler.CreatePerson(23, "Kalle", "Anka", 120, 50);
                personHandler.DisplayPersonDetails(kalle);
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
