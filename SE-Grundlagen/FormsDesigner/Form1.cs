using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDesigner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Eingabe.Text = "OK";
            if (progressBar1.Value == 9)
                progressBar1.Value = 6;
            progressBar1.Value += 1;
        }

        private void btnAbbrechen_Click(object sender, EventArgs e)
        {
            Eingabe.Text = "Abbrechen";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
        }

        private void Eingabe_MouseEnter(object sender, EventArgs e)
        {
            Eingabe.BackColor = Color.Yellow;
        }

        private void Eingabe_MouseLeave(object sender, EventArgs e)
        {
            Eingabe.BackColor = Color.Green;
        }
    }
}
