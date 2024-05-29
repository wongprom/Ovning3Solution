namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person jimmy = new Person(age: -4, 183, 80, "Jimmy", "Bäckström");    
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
