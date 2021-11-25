using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchieAngestellter
{
    public class Manager : Angestellter
    {
        public override void Gehaltauszahlen()
        {
            Console.WriteLine("Gehaltauszahlen an Manager");
        }
    }
}
