using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class AbgeleiteteKlasse : Basisklasse
    {
        public override string Test()
        {
            return "Die Methode Abgeleiteteklasse.Test wurde ohne Parameter aufgerufen";
        }
    }
}
