using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comperators
{
    public class ComperatorName : IComparer<Olimpiada>
    {
        public int Compare(Olimpiada x, Olimpiada y)
        {
            return x.Name.CompareTo(y.Name);    
        }
    }
}
