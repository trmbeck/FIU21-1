using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanzzahlRechner2
{
    public partial class Form1 : Form
    {
        //Attribute, Felder, fields
        Rechner rechenoperationen;
        

        //Konstruktor
        public Form1()
        {
            InitializeComponent();
            rechenoperationen = new Rechner();
        }


        //Methoden
        void Init()
        {
            rechenoperationen.zahl1 = Convert.ToInt32(textBoxZahl1.Text);
            rechenoperationen.zahl2 = Convert.ToInt32(textBoxZahl2.Text);
        }
        void Anzeigen(int ergebnis)
        {
            textBoxErgebnis.Text = ergebnis.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Init();
            int erg = rechenoperationen.Addition();
            Anzeigen(erg);
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            Init();
            Anzeigen(rechenoperationen.Subtraktion());
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            Init();
            Anzeigen(rechenoperationen.Division());
        }
        private void btnMul_Click(object sender, EventArgs e)
        {
            Init();
            Anzeigen(rechenoperationen.Multiplikation());
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            Init();
            Anzeigen(rechenoperationen.Modulo());
        }
    }
}
