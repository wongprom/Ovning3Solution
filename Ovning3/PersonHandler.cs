using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class PersonHandler
    {
        //Constructor
        public PersonHandler()
        {
            
        }
        public void SetAge(Person pers, int age)
        {
            try 
            { 
                pers.Age = age; 
            } 
            catch(ArgumentException ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SetAge: " + ex.Message);
                Console.ResetColor();
            }
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            //Skapa en ny instans av person
            Person kalle = new Person(age, height, weight, fname, lname);

            //returnera personen
            return kalle;
        }
    }
}
