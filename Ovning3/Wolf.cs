using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Wolf : Animal
    {
        public bool HasPack {  get; set; }
        public Wolf(string name, int age, double weight, bool hasPack) : base(name, age, weight)
        {
            HasPack = hasPack;
        }

        public override void DoSound()
        {
            Console.WriteLine("yowl yowl");
            
        }
    }
}
