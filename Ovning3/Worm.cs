using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Worm : Animal
    {
        public bool LivsInWater { get; set; }
        public Worm(string name, int age, double weight, bool livsInWater) : base(name, age, weight)
        {
            LivsInWater = livsInWater;
        }

        public override void DoSound()
        {
            Console.WriteLine("");
        }
    }
}
