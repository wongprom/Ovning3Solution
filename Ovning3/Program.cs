namespace Ovning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person jane = new Person();
            jane.LName = "Pettersson";
            Console.WriteLine(jane.FName);//""
            Console.WriteLine(jane.LName);//Pettersson
        }
    }
}
