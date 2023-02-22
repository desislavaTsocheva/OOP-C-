using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars("Audi A6", "red", 150, 20000);
            Cars car2 = new Cars(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());
        }
    }
}
