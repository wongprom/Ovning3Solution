using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Pelican : Bird
    {
        public bool IsDivingForFood { get; set; }
        public Pelican(string name, int age, double weight, double wingSpan, bool isDivingForFood) : base(name, age, weight, wingSpan)
        {
            IsDivingForFood = isDivingForFood;
        }
    }
}
