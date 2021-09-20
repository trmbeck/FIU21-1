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
            Console.WriteLine($"Kontostand: {kontostand:f2}");
            return kontostand;
        }
    }
}
