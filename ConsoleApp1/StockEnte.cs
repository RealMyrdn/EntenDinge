using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    // StockEnte erbt von Ente 
    public class StockEnte : Ente {
        public override void gibLaut() {
            Console.WriteLine("Stockente quakt");
        }
        public StockEnte() {
            FlugFaehigkeit = new KannFliegen();
            tauchFaehigkeit = new KannNichtTauchen();
        }
    }
}
