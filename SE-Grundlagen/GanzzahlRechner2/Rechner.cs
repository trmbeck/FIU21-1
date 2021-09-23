using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanzzahlRechner2
{
    class Rechner
    {
        public int zahl1;
        public int zahl2;

        public int Addition()
        {
            int ergebnis = zahl1 + zahl2;
            return ergebnis;
        }
        public int Subtraktion()
        {
            return zahl1 - zahl2;
        }
        public int Multiplikation()
        {
            return zahl1 * zahl2;
        }
        public int Division()
        {
            return zahl1 / zahl2;
        }
        public int Modulo()
        {
            return zahl1 % zahl2;
        }
    }
}
