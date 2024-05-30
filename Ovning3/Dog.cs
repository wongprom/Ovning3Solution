using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    internal class Dog : Animal
    {
        public bool IsAllergyFriendly { get; set; }
        public Dog(string name, int age, double weight, bool isAllergyFriendly) : base(name, age, weight)
        {
            IsAllergyFriendly = isAllergyFriendly;
        }

        public override void DoSound()
        {
            Console.WriteLine("bark bark");
        }
    }
}
