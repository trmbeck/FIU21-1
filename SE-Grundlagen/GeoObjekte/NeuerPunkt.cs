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
    public partial class NeuerPunkt : Form
    {
        public Punkt p;
        public NeuerPunkt()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColor.BackColor = colorDialog1.Color;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            p = new Punkt();
            p.x = Convert.ToDouble(textBoxX.Text);
            p.y = Convert.ToDouble(textBoxY.Text);
            p.farbe = btnColor.BackColor;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
