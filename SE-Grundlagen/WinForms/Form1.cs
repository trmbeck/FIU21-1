using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = !progressBar1.Visible;
            if (button1.Text == "Anzeigen")
            {
                button1.Text = "Ausblenden";
            }else
            {
                button1.Text = "Anzeigen";
            }
            progressBar1.Maximum++;
            Point p = new Point();
            p.X = progressBar1.Location.X;
            p.Y = progressBar1.Location.Y - 5;
            progressBar1.Location = p;
           
        }

        private void checkBoxFasel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFasel.Checked)
            {
                MessageBox.Show("Checkbox ausgewählt :-)");
                checkBoxFasel.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
