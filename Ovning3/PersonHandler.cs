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

        //Fields
        private int _age;
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private double _height;
        private double _weight;

        //Constructor
        public PersonHandler()
        {
      
        }
        public PersonHandler(int age, double height, double weight, string firstName, string lastName)
        {
            Age = age;
            Height = height;
            Weight = weight;
            FirstName = firstName;
            LastName = lastName;
        }  
        //Propertys
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0 (zero).");
                }
            }
        }
        public string FirstName
        {// ToDo implement Required FName
            get { return _firstName; }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    _firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name must have min 2 characters AND max 10 characters.");
                }
            }
        }

        public string LastName
        { // ToDo implement Required LName
            get { return _lastName; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name must have min 3 characters AND max 15 characters.");
                }
            }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        //Methods
        public void SetAge(Person pers, int age)
        {
                pers.Age = age; 
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            //Skapa en ny instans av person
            Person per = new Person(age, height, weight, fname, lname);

            //returnera personen
            return per;
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
