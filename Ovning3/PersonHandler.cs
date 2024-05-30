using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ovning3
{
    internal class PersonHandler
    {
        //Constructor
        public PersonHandler()
        {
      
        }
        //Methods
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            //Skapa en ny instans av person
            Person per = new Person(age, height, weight, fname, lname);

            //returnera personen
            return per;
        } 
        public Person CreatePerson()
        {
            return  new Person();
        }
        public void SetAge(Person pers, int age)
        {
                pers.Age = age; 
        }
        public void SetFName(Person pers, string firstName)
        {
                pers.FName = firstName; 
        }
        public void SetLName(Person pers, string lastName)
        {
                pers.LName = lastName; 
        } 
        public void SetWeight(Person pers, double weight)
        {
                pers.Weight = weight; 
        }
        public void SetHeight(Person pers, double height)
        {
                pers.Height = height; 
        }
        public void DisplayPersonDetails(Person person)
        {
            Console.WriteLine($"First name: {person.FName}");
            Console.WriteLine($"Last name: {person.LName}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Weight: {person.Weight}");
            Console.WriteLine($"Height: {person.Height}");
        }
    }
}
