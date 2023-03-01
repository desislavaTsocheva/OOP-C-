using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal c1 = new Cat("4O4I", 1);
            Console.WriteLine(c1.MakeNoise());
            Console.WriteLine(c1.MakeTricks());
            Animal d1 = new Dog("Sharko", 6);
            Console.WriteLine(d1.MakeNoise());
            Console.WriteLine(d1.MakeTricks());
        }
    }
}
