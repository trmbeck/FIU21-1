using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Subklasse SubObj = new Subklasse();
            SubObj.Variable = 10;
            SubObj.SubVariable = 20;//Nur in Subklasse verfügbar
            SubObj.Method1();
            SubObj.SubMethod();     //Nur in Subklasse verfügbar

            Basisklasse BasisObj = SubObj; //Boxing
            BasisObj.Variable = 11;
            BasisObj.Method1();

            Console.WriteLine("Variable: " + SubObj.Variable);

            Subklasse var3 = BasisObj as Subklasse;



        }
    }

    class Basisklasse
    {
        public int Variable;
        public void Method1() { }
    }

    class Subklasse : Basisklasse
    {
        public int SubVariable;
        public void SubMethod() { }
    }
}
