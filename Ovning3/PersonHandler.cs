using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class PersonHandler
    {
        public static void SetAge(Person pers, int age)
        {
            try 
            { 
                pers.Age = age; 
            } 
            catch(ArgumentException ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SetAge: " + ex.Message);
                Console.ResetColor(); Console.ResetColor();
            }
        }
    }
}
