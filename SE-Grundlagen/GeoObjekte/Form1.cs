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

            foreach (GeoObjekt item in listBoxObjekte.Items)
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
                GeoObjekt p = (GeoObjekt)listBoxObjekte.SelectedItem;
                p.Verschieben(0,-(double)numericUpDown1.Value);
                PanelNeuzeichnen();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {

        }

        private void btnDown_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string ObejektInformationen = "";
            // Auswahl bestimmen
            if (listBoxObjekte.SelectedItem is Linie)
            {
                ObejektInformationen = (listBoxObjekte.SelectedItem as Linie).GetInfo();
            }else if (listBoxObjekte.SelectedItem is Punkt)
            {
                ObejektInformationen = (listBoxObjekte.SelectedItem as Punkt).GetInfo();
            }


            //Info von gewähltem Element in TextboxInfo ausgeben
            textBoxInfo.Text = ObejektInformationen;
        }

        private void listBoxObjekte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ObejektInformationen = "";
            // Auswahl bestimmen
            if (listBoxObjekte.SelectedItem is Linie)
            {
                ObejektInformationen = (listBoxObjekte.SelectedItem as Linie).GetInfo();
            }
            else if (listBoxObjekte.SelectedItem is Punkt)
            {
                ObejektInformationen = (listBoxObjekte.SelectedItem as Punkt).GetInfo();
            }


            //Info von gewähltem Element in TextboxInfo ausgeben
            textBoxInfo.Text = ObejektInformationen;
        }
    }
}
