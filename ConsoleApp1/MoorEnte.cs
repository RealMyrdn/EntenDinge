using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class MoorEnte : Ente {
        public override void gibLaut() {
            Console.WriteLine("Moorente quakt");
        }
        public MoorEnte() {
            FlugFaehigkeit = new KannFliegen();
            tauchFaehigkeit = new KannTauchen();
        }
    }
}
