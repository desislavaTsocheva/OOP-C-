using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OOPPregovor
{
    public class SuperHero:IPrint,IComparable<SuperHero>,IEnumerable<SuperHero>
        //Iteratorite obhojdat zashtiteto kolekciqta ot danni
        //IEnumerable ima samo 1 metod GetEnumerator, koito obhojda ot 1 do posleden element
        //a IEnumeratora ima Move, Current, Reset metodi za po-lesno obhojdane 
    {
        protected string name;
        protected int id;
        protected double power; //enkapsulaciq za nasledqvane na clasa: protected
        //protected poletata ne se nujdaqt ot properties

        public SuperHero(string name,int id,double power) //konstruktora ne moje da se nasledqva
        {                                                 //nasledqvame samo poletata mu
            this.name = name;
            this.id = id;
            this.power = power;
        }

        //Komparatotite imat 2 vida IComparable(az sum neshto sravnimo) i IComparer(Az sravnqvam)
        public int CompareTo(SuperHero other)
        {
           int result=this.power.CompareTo(other.power);
            if (result == 0)
            {
                result=this.id.CompareTo(other.id); 
            }
            else
            {
                result=this.name.CompareTo(other.name); 
            }
            return result;
        }

        public IEnumerator<SuperHero> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        //Implementirane na interfeis
        //Virtual se izpolzva kogato iskame metoda da moje da bude prezapisvan!
        public virtual void Print()
        {
            Console.WriteLine($"Hero: {this.name} with id= {this.id} has {this.power} power");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
