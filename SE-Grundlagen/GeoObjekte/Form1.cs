using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoObjekte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            if (radioButtonPunkt.Checked)
            {
                NeuerPunkt neuerPunkt = new NeuerPunkt();
                neuerPunkt.ShowDialog();

                if (neuerPunkt.DialogResult == DialogResult.OK)
                {
                    //Punkt wurde erstellt
                    listBoxObjekte.Items.Add(neuerPunkt.p);
                    PanelNeuzeichnen();
                }
                else
                {
                    //Abbruch
                }
            }
            if (radioButtonLinie.Checked)
            {
                NeueLinieFormular neueLinieFormular = new NeueLinieFormular();
                neueLinieFormular.ShowDialog();
                if (neueLinieFormular.DialogResult == DialogResult.OK)
                {
                    listBoxObjekte.Items.Add(neueLinieFormular.l);
                    PanelNeuzeichnen();
                }
            }
        }
        void PanelNeuzeichnen()
        {
            Graphics graphics = panel1.CreateGraphics();
            graphics.Clear(SystemColors.Control);

            foreach (object item in listBoxObjekte.Items)
            {
                if (item is Punkt)
                {
                    Punkt p = item as Punkt;
                    //p = (Punkt)item;
                    graphics.DrawEllipse(new Pen(p.farbe, 3), (float)p.x, (float)p.y, 1, 1);
                } 
                else 
                if (item is Linie)
                {
                    Linie l = item as Linie;
                    graphics.DrawLine(new Pen(l.farbe, 3), (float)l.A.x, (float)l.A.y, (float)l.B.x, (float)l.B.y);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listBoxObjekte.SelectedItem != null)
            {
                Punkt p = (Punkt)listBoxObjekte.SelectedItem;
                p.y--;
                PanelNeuzeichnen();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }
    }
}
