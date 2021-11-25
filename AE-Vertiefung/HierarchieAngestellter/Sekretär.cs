using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchieAngestellter
{
    public class Sekretär : Angestellter
    {
        public override void Gehaltauszahlen()
        {
            Console.WriteLine("Gehaltauszahlen an Sekretär");
        }
    }
}
