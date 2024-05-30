using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, int age, double weight , int nrOfSpikes) : base(name, age, weight)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("growl growl");
            
        }
    }
}
