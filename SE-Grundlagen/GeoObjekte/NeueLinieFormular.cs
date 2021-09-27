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
    public partial class NeueLinieFormular : Form
    {
        public Linie l;
        public NeueLinieFormular()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            btnColor.BackColor = colorDialog1.Color;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBoxX1.Text);
            double y1 = Convert.ToDouble(textBoxY1.Text);
            double x2 = Convert.ToDouble(textBoxX2.Text);
            double y2 = Convert.ToDouble(textBoxY2.Text);
            l = new Linie(x1, y1, x2, y2, btnColor.BackColor);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
