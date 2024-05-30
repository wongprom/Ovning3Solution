using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Swan : Bird
    {
        public bool HasLifePartner { get; set; }
        public Swan(string name, int age, double weight, double wingSpan, bool hasLifePartner) : base(name, age, weight, wingSpan)
        {
            HasLifePartner = hasLifePartner;
        }
    }
}
