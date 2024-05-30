using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Bird : Animal
    {
        public double WingSpan { get; set; }

        public Bird(string name, int age, double weight, double wingSpan) : base(name, age, weight)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("pip pip");

        }
    }
}
