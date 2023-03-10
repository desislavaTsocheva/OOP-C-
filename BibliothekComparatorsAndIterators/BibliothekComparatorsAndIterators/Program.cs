using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothekComparatorsAndIterators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bibliothek b1 = new Bibliothek("The Little Prince", 2008, "Antoan Eksuperi");
            Bibliothek b2 = new Bibliothek("Pretty Little Things", 1999, "Suzan Mariza","Marine Rest");
            Bibliothek b3 = new Bibliothek("Hobbit", 1789, "Stiven Leninson");
            Library l1 = new Library(b1,b2,b3);
            foreach(var item in l1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
