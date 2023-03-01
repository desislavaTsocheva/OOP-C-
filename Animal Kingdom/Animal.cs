using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    public abstract class Animal:IMakeNoise,IMakeTricks
    {
        protected string name;
        protected int age;
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age; 
        }

        public virtual string MakeNoise()
        {
            return $"My name is {name}. I am {age} years old";
        }

        public virtual string MakeTricks()
        {
            return $"Look at my trick!";
        }
    }
}
