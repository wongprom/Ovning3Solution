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
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string LName
        { 
            get { return _lName; } 
            set { _lName = value; } 
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
