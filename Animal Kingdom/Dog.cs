using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    public class Dog:Animal
    {
        public Dog(string name, int age):base(name,age)
        {

        }
        public string IMakeNoise()
        {
            return $"Woaf!";
        }
        public string IMakeTricks()
        {
            return $"Hold my paw human!";
        }
    }
}
