using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Person
    {
        //Fields
        private int _age;
        private string _fName = string.Empty;
        private string _lName= string.Empty;
        private double _height;
        private double _weight;

        //Constructor
        public Person(int age, double height, double weight, string firstName, string lastName)
        {
            Age = age;
            Height = height;
            Weight = weight;
            FName = firstName;
            LName = lastName;
        }

        //Propertys
        public int Age
        { 
            get { return _age; } 
            set
            {  
                if( value > 0 )
                {
                    _age = value; 
                }
                else
                {
                    throw new ArgumentException("Age must be greater than 0 (zero).");
                } 
            }
        }
        public string FName
        {// ToDo implement Required FName
            get { return _fName; }
            set 
            { 
                if(value.Length >= 2 && value.Length <= 10)
                {
                    _fName = value; 
                }
                else
                {
                    throw new ArgumentException("First name must have min 2 characters AND max 10 characters.");
                }
            }
        }

        public string LName
        { // ToDo implement Required LName
            get { return _lName; } 
            set 
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    _lName = value;
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
    }
}
