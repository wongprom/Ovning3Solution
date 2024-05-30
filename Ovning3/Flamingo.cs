using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Flamingo : Bird
    {
        public bool IsPink { get; set; }

        public Flamingo(string name, int age, double weight, double wingSpan, bool isPink) : base(name, age, weight, wingSpan)
        {
            IsPink = isPink;
        }
    }
}
