namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person peter = new Person(age:3, height:150, weight:50, firstName:"Peter", lastName:"Pett");
                PersonHandler.SetAge(peter,-4);
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
