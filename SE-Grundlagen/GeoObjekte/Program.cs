using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoObjekte
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Punkt p1 = new Punkt() { x = 1, y = 2 };
            //Punkt p2 = new Punkt() { x = 3, y = 4 };
            //Rechteck r = new Rechteck();
            //r.SetPunktB(p1);
            //r.A = p2;

        }
    }
}
