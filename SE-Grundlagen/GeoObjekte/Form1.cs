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
        }
        void PanelNeuzeichnen()
        {
            Graphics graphics = panel1.CreateGraphics();
            graphics.Clear(SystemColors.Control);

            foreach (Punkt punkt in listBoxObjekte.Items)
            {
                graphics.DrawEllipse(new Pen(punkt.farbe, 3), (float)punkt.x, (float)punkt.y, 1, 1);

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
