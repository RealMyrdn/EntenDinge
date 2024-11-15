using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public abstract class Ente {
        public FlugFaehigkeit FlugFaehigkeit;
        public TauchFaehigkeit tauchFaehigkeit;
        // Eine nicht ausprogrammieret Methode
        public abstract void gibLaut();
        // # schwimmen(): void
        public void schwimmen() {
            Console.WriteLine("Ente schwimmt");
        }
        public void fly() {
            FlugFaehigkeit.fliegen();
        }
        public void change(KannFliegen kannFliegen) {
            FlugFaehigkeit = kannFliegen;
        }

        internal void taucht()
        {
            tauchFaehigkeit.tauchen();
        }
    }
}
