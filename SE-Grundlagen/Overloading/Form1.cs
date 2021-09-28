using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBasisTest_Click(object sender, EventArgs e)
        {
            AbgeleiteteKlasse abgeleiteteKlasse = new AbgeleiteteKlasse();
            Basisklasse basisklasse = abgeleiteteKlasse;
            label1.Text = basisklasse.Test();
        }

        private void buttonTestInt_Click(object sender, EventArgs e)
        {
            AbgeleiteteKlasse abgeleiteteKlasse = new AbgeleiteteKlasse();
            Basisklasse basisklasse = abgeleiteteKlasse;
            label1.Text = basisklasse.Test(10);
        }

        private void buttonTestString_Click(object sender, EventArgs e)
        {
            AbgeleiteteKlasse abgeleiteteKlasse = new AbgeleiteteKlasse();
            Basisklasse basisklasse = abgeleiteteKlasse;
            label1.Text = basisklasse.Test("Fasel");
        }
    }
}
