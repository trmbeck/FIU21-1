
namespace GeoObjekte
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
            this.listBoxObjekte = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRechteck = new System.Windows.Forms.RadioButton();
            this.radioButtonKreis = new System.Windows.Forms.RadioButton();
            this.radioButtonLinie = new System.Windows.Forms.RadioButton();
            this.radioButtonPunkt = new System.Windows.Forms.RadioButton();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxObjekte
            // 
            this.listBoxObjekte.FormattingEnabled = true;
            this.listBoxObjekte.Location = new System.Drawing.Point(12, 23);
            this.listBoxObjekte.Name = "listBoxObjekte";
            this.listBoxObjekte.Size = new System.Drawing.Size(120, 225);
            this.listBoxObjekte.TabIndex = 0;
            this.listBoxObjekte.SelectedIndexChanged += new System.EventHandler(this.listBoxObjekte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Objekte:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(138, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 225);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRechteck);
            this.groupBox1.Controls.Add(this.radioButtonKreis);
            this.groupBox1.Controls.Add(this.radioButtonLinie);
            this.groupBox1.Controls.Add(this.radioButtonPunkt);
            this.groupBox1.Location = new System.Drawing.Point(14, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objektauswahl";
            // 
            // radioButtonRechteck
            // 
            this.radioButtonRechteck.AutoSize = true;
            this.radioButtonRechteck.Location = new System.Drawing.Point(93, 42);
            this.radioButtonRechteck.Name = "radioButtonRechteck";
            this.radioButtonRechteck.Size = new System.Drawing.Size(72, 17);
            this.radioButtonRechteck.TabIndex = 4;
            this.radioButtonRechteck.Text = "Rechteck";
            this.radioButtonRechteck.UseVisualStyleBackColor = true;
            // 
            // radioButtonKreis
            // 
            this.radioButtonKreis.AutoSize = true;
            this.radioButtonKreis.Location = new System.Drawing.Point(93, 19);
            this.radioButtonKreis.Name = "radioButtonKreis";
            this.radioButtonKreis.Size = new System.Drawing.Size(48, 17);
            this.radioButtonKreis.TabIndex = 5;
            this.radioButtonKreis.Text = "Kreis";
            this.radioButtonKreis.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinie
            // 
            this.radioButtonLinie.AutoSize = true;
            this.radioButtonLinie.Location = new System.Drawing.Point(6, 42);
            this.radioButtonLinie.Name = "radioButtonLinie";
            this.radioButtonLinie.Size = new System.Drawing.Size(47, 17);
            this.radioButtonLinie.TabIndex = 6;
            this.radioButtonLinie.Text = "Linie";
            this.radioButtonLinie.UseVisualStyleBackColor = true;
            // 
            // radioButtonPunkt
            // 
            this.radioButtonPunkt.AutoSize = true;
            this.radioButtonPunkt.Checked = true;
            this.radioButtonPunkt.Location = new System.Drawing.Point(6, 19);
            this.radioButtonPunkt.Name = "radioButtonPunkt";
            this.radioButtonPunkt.Size = new System.Drawing.Size(53, 17);
            this.radioButtonPunkt.TabIndex = 7;
            this.radioButtonPunkt.TabStop = true;
            this.radioButtonPunkt.Text = "Punkt";
            this.radioButtonPunkt.UseVisualStyleBackColor = true;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(204, 312);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(56, 23);
            this.btnNeu.TabIndex = 8;
            this.btnNeu.Text = "Neu ...";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(373, 318);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 23);
            this.btnDown.TabIndex = 0;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(342, 295);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(25, 23);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(373, 276);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(404, 295);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(25, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Enabled = false;
            this.textBoxInfo.Location = new System.Drawing.Point(460, 254);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInfo.Size = new System.Drawing.Size(254, 94);
            this.textBoxInfo.TabIndex = 9;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(266, 312);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(58, 23);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(334, 255);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 360);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxObjekte);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxObjekte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRechteck;
        private System.Windows.Forms.RadioButton radioButtonKreis;
        private System.Windows.Forms.RadioButton radioButtonLinie;
        private System.Windows.Forms.RadioButton radioButtonPunkt;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

