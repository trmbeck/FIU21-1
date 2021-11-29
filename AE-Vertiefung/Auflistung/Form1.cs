using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auflistung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbTierliste.Items.Add("Affe");
            lbTierliste.Items.Add("Elefant");
        }

        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Button Hinzufügen wurde angeklickt!");
            string eingabe = txbEingabe.Text;
            System.Diagnostics.Debug.WriteLine(eingabe);
            lbTierliste.Items.Add(eingabe);
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            int index = lbTierliste.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Keine Element gewählt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Debug.WriteLine("Zum Löschen wurde kein Element gewählt!");
            }
            else
            {
                DialogResult result = MessageBox.Show(
                    "Wollen Sie wirklich?",
                    "Element löschen",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                    lbTierliste.Items.RemoveAt(index);
            }
        }

        private void btnAlleLoeschen_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Wollen Sie wirklich die Liste leeren?",
                "Liste löschen",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                lbTierliste.Items.Clear();
            }
        }

        private void btnEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbSortieren_CheckedChanged(object sender, EventArgs e)
        {
            bool SollSortiertSein = cbSortieren.Checked;

            lbTierliste.Sorted = SollSortiertSein;
        }
    }
}
