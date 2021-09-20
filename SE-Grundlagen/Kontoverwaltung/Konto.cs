using System;
using System.Collections.Generic;
using System.Text;

namespace Kontoverwaltung
{
    class Konto
    {
        //Felder
        private decimal kontostand;

        //Methoden
        public void GeldEinzahlen(decimal betrag)
        {
            kontostand = kontostand + betrag;
        }

        public void GeldAuszahlen(decimal betrag)
        {
            kontostand -= betrag;
        }

        public decimal KontostandAnzeigen()
        {
            if (kontostand < 0)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Kontostand: {kontostand:f2}");
            Console.ForegroundColor = ConsoleColor.White;
            return kontostand;
        }
    }
}
