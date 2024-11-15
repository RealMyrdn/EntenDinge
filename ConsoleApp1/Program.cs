// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Ente Gustav = new StockEnte();
Ente Udo = new MoorEnte();
Ente Xi = new PekingEnte();
Gustav.schwimmen();
Gustav.gibLaut();
Gustav.fly();
Gustav.taucht();
Udo.schwimmen();
Udo.gibLaut();
Udo.fly();
Udo.taucht();
Xi.schwimmen();
Xi.gibLaut();
Xi.fly();
// Was muss ich tun damit die Pekingente Xi fliegen kann?
// Stockente fliegt, weil Flugfaehigkeit = new KannFliegen() ist
Xi.change(new KannFliegen());
Xi.fly();
Xi.tauchFaehigkeit.tauchen();