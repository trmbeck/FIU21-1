using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Basisklasse
    {
        public virtual string Test()
        {
            return "Die Methode Basisklasse.Test wurde ohne Parameter aufgerufen";
        }

        public virtual string Test(int a)
        {
            return "Die Methode Basisklasse.Test wurde mit int Parameter aufgerufen";
        }

        public virtual string Test(string b)
        {
            return "Die Methode Basisklasse.Test wurde mit string Parameter aufgerufen";
        }
    }
}
