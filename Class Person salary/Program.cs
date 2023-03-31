using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Person_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter count persons");
            int countPersons = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < countPersons; i++)
            {
                var p = Console.ReadLine().Split();
                Person p1 = new Person(p[0], int.Parse(p[1]), double.Parse(p[2]));
                persons.Add(p1);
            }
            double bonus = double.Parse(Console.ReadLine());
            persons.ForEach(x => Console.WriteLine(x.ToString()));
            persons.OrderBy(x => x.ToString());
        }
    }
}
