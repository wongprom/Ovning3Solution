using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal  class Horse : Animal
    {
        public bool IsFast { get; set; } = true;

        public Horse(string name, int age, double weight, bool isFast) : base(name, age, weight)
        {
            IsFast = isFast;
        }

        public override void DoSound()
        {
            Console.WriteLine("neigh neigh ");
        }
    }
}
