using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken ch1 = new Chicken("иванка",13,6);
            ch1.CalsulateEggsForday();
        }
    }
}
