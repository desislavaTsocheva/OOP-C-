using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPregovor
{
    public class Program
    {
        static void Main(string[] args)
        {
            //obekt
            SuperHero hero1 = new SuperHero("Eskobar", 1, 63.8);
            SuperHero hero3 = new SuperHero("Bejko", 4, 36.1);
            hero1.Print();

            //Compare
            Console.WriteLine(hero1.CompareTo(hero3));

            //polimorfizum
            SuperHero hero2 = new Gamer("Ivan", 8, 360.7, "Rendimus", 6, 987.2);
            hero2.Print();

            //Obekti v list
            SuperHero hero4 = new SuperHero("Bejko", 4, 36.1);
            SuperHero hero5 = new SuperHero("Ejko", 8, 875.1);
            SuperHero hero6 = new SuperHero("Gejo", 12, 3856.1);
            List<SuperHero> list = new List<SuperHero>()
            {
                hero4, hero5, hero6 
            };

            //Otpechatvane na vs obekti
            foreach (var item in list)
            {
                item.Print();
            }

        }
    }
}
