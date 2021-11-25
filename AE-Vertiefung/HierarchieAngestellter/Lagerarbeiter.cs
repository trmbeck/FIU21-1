using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HierarchieAngestellter
{
    public class Lagerarbeiter : Angestellter
    {
        public override void Gehaltauszahlen()
        {
            Console.WriteLine("Gehaltauszahlen an Lagerarbeiter");
        }
    }
}
