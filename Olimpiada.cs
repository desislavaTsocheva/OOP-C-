using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Comperators
{
    public class Olimpiada:IComparable<Olimpiada>
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private int points;
		public int Points
		{
			get { return points; }
			set { points = value;}
		}
		public Olimpiada(string name, int points)
		{
			this.name= name;	
			this.points= points;	
		}
        public override string ToString()
        {
			return $"{this.Name} --> {this.Points}p.";
        }
        public int CompareTo(Olimpiada other)
        {
           return points.CompareTo(other.points);	
        }
    }
}
