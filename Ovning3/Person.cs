﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Person
    {
        private int age;
        private string fName = string.Empty;
        private string lName= string.Empty;
        private double height;
        private double weight;

        public int Age
        { 
            get { return age; } 
            set {  age = value; } 
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        { 
            get { return lName; } 
            set { lName = value; } 
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
