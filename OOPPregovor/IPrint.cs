using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPregovor
{
    public interface IPrint
    {
        void Print();
        //nqma encapsulaciq i ne predostavq kod!!!
        //Interfeisa zadava povedenieto, no ne zadava nachina, po koito shte se izpulnqva
   
        //obratnoto na abtrakciqta
        //tq se osushtesvqva s abstraktni klasove i abstraktni interfeisi, tq ignorira neznachitelnite cherti
        //Mojem da nasledqvame nqkolko interfeisa, no samo 1 klas ednovremenno
    }
}
