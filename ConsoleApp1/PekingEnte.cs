using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class PekingEnte : Ente {
        public override void gibLaut() {
            Console.WriteLine("Pekingente kann nicht quaken");
        }
        public PekingEnte() {
            FlugFaehigkeit = new KannNichtFliegen();
            tauchFaehigkeit = new KannTauchen();
        }
    }
}
