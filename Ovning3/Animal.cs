using Ovning3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    abstract class Animal : IAnimal
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public double Weight { get; set; }

        // Add more Attributes for all Animals 

        //Constructor
        public Animal(string name, int age, double weight) 
        { 
        
            Name = name;
            Age = age;
            Weight = weight;
        }

        //Method
        public abstract void DoSound();
        // Todo Why cant I run Stats on instance of Animal?
        public virtual string Stats()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}";
        }
    }
}
