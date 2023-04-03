using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPregovor
{
    public class Gamer:SuperHero,IPrint
    {
        private string gamerName;
        private int countGames;
        private double points;

        //properties
        public string GamerName
        {
            get { return this.gamerName; }
            set { this.GamerName = value; }
        }
        public int CountGames { get { return this.countGames; } set { this.CountGames = value; } }
        public double Points { get { return this.points; } set { this.Points = value; } }

        //poletata v konstructora se nasledqvat s * :base  * 
        public Gamer(string gamerName,int countGames,double points,string name, int id,
        double power) : base( name, id, power)
        {
            this.gamerName = gamerName;
            this.countGames = countGames;
            this.points = points;
        }
        //s overloading prezarejdame metoda
        //s override prezapisvame metoda ili dobavqme nova informaciq
        public override void Print()
        {
            Console.WriteLine($"Gamer:{this.GamerName} has {this.CountGames} games and {this.Points} points");
            base.Print();
        }

    }
}
