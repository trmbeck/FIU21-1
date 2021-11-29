
namespace Auflistung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTierliste = new System.Windows.Forms.ListBox();
            this.txbEingabe = new System.Windows.Forms.TextBox();
            this.btnHinzufuegen = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.btnAlleLoeschen = new System.Windows.Forms.Button();
            this.btnEnde = new System.Windows.Forms.Button();
            this.cbSortieren = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbTierliste
            // 
            this.lbTierliste.FormattingEnabled = true;
            this.lbTierliste.Location = new System.Drawing.Point(12, 12);
            this.lbTierliste.Name = "lbTierliste";
            this.lbTierliste.Size = new System.Drawing.Size(636, 264);
            this.lbTierliste.TabIndex = 0;
            // 
            // txbEingabe
            // 
            this.txbEingabe.Location = new System.Drawing.Point(12, 282);
            this.txbEingabe.Name = "txbEingabe";
            this.txbEingabe.Size = new System.Drawing.Size(636, 20);
            this.txbEingabe.TabIndex = 1;
            // 
            // btnHinzufuegen
            // 
            this.btnHinzufuegen.Location = new System.Drawing.Point(12, 308);
            this.btnHinzufuegen.Name = "btnHinzufuegen";
            this.btnHinzufuegen.Size = new System.Drawing.Size(75, 23);
            this.btnHinzufuegen.TabIndex = 2;
            this.btnHinzufuegen.Text = "Hinzufügen";
            this.btnHinzufuegen.UseVisualStyleBackColor = true;
            this.btnHinzufuegen.Click += new System.EventHandler(this.btnHinzufuegen_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(94, 309);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoeschen.TabIndex = 3;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // btnAlleLoeschen
            // 
            this.btnAlleLoeschen.Location = new System.Drawing.Point(176, 309);
            this.btnAlleLoeschen.Name = "btnAlleLoeschen";
            this.btnAlleLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnAlleLoeschen.TabIndex = 4;
            this.btnAlleLoeschen.Text = "Alle löschen";
            this.btnAlleLoeschen.UseVisualStyleBackColor = true;
            this.btnAlleLoeschen.Click += new System.EventHandler(this.btnAlleLoeschen_Click);
            // 
            // btnEnde
            // 
            this.btnEnde.Location = new System.Drawing.Point(573, 309);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(75, 23);
            this.btnEnde.TabIndex = 6;
            this.btnEnde.Text = "Beenden";
            this.btnEnde.UseVisualStyleBackColor = true;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // cbSortieren
            // 
            this.cbSortieren.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSortieren.AutoSize = true;
            this.cbSortieren.Location = new System.Drawing.Point(371, 309);
            this.cbSortieren.Name = "cbSortieren";
            this.cbSortieren.Size = new System.Drawing.Size(50, 23);
            this.cbSortieren.TabIndex = 7;
            this.cbSortieren.Text = "Sortiert";
            this.cbSortieren.UseVisualStyleBackColor = true;
            this.cbSortieren.CheckedChanged += new System.EventHandler(this.cbSortieren_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 359);
            this.Controls.Add(this.cbSortieren);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.btnAlleLoeschen);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnHinzufuegen);
            this.Controls.Add(this.txbEingabe);
            this.Controls.Add(this.lbTierliste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTierliste;
        private System.Windows.Forms.TextBox txbEingabe;
        private System.Windows.Forms.Button btnHinzufuegen;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.Button btnAlleLoeschen;
        private System.Windows.Forms.Button btnEnde;
        private System.Windows.Forms.CheckBox cbSortieren;
    }
}

