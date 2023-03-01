using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    public class Cat:Animal
    {
        public Cat(string name,int age):base(name,age)
        {

        }
        public string IMakeNoise()
        {
            return $"Meow!";
        }
        public string IMakeTrick()
        {
            return $"No tricks for you!I am too lazy";
        }
    }
}
