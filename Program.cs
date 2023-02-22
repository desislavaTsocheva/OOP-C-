using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comperators
{
    public class Program
    {
        static void Main(string[] args)
        {
            Olimpiada o1 = new Olimpiada("Math", 60);
            Olimpiada o2 = new Olimpiada("Bel", 80);
            Olimpiada o3 = new Olimpiada("Biology", 85);
            Olimpiada o4 = new Olimpiada("Chemistry", 50);

            List<Olimpiada> listOlympiada = new List<Olimpiada>
            {
                o1, o2, o3, o4
            };
            listOlympiada.Sort();
            foreach (var item in listOlympiada)
            {
                Console.WriteLine(item);
            }

            var comperator = new ComperatorName();
            listOlympiada.Sort(comperator);

        }
    }
}
