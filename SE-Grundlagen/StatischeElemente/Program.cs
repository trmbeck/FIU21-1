using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischeElemente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rechner r1 = new Rechner();
            //r1.zahl1 = 10;
            Rechner.KlassenVariable = 100;

            int erg = Rechner.Addition(2,3);
            Console.WriteLine(erg);

            Rechner.Quadrieren(100);

            


            Console.ReadLine();
        }
    }

    static class Rechner
    {
        static public int KlassenVariable;
        //public int zahl1;
        //public int zahl2;

        //public int Addition()
        //{
        //    return zahl1 + zahl2;
        //}

        static public int Addition(int z1, int z2)
        {
            return z1 + z2;
        }

        static public double Quadrieren(double zahl)
        {
            return zahl * zahl;
        }
    }
}
