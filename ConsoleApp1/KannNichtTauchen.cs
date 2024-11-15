using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class KannNichtTauchen : TauchFaehigkeit
    {
        public void tauchen()
        {
            Console.WriteLine("Ente kann nicht tauchen");
        }
    }
}
