using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Wolfman : Wolf,IPerson
    {
        public Wolfman(string name, int age, double weight, bool hasPack) : base(name, age, weight, hasPack)
        {
        }

        //ToDo!!! cant make Talk to work
        public string Talk()
        {
            return "I am Wolfman!!";
        }


    }
}
