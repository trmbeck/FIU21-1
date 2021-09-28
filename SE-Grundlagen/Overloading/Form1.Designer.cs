
namespace Overloading
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTestInt = new System.Windows.Forms.Button();
            this.buttonBasisTest = new System.Windows.Forms.Button();
            this.buttonTestString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 23);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonTestInt
            // 
            this.buttonTestInt.Location = new System.Drawing.Point(256, 139);
            this.buttonTestInt.Name = "buttonTestInt";
            this.buttonTestInt.Size = new System.Drawing.Size(75, 23);
            this.buttonTestInt.TabIndex = 1;
            this.buttonTestInt.Text = "Test(int)";
            this.buttonTestInt.UseVisualStyleBackColor = true;
            this.buttonTestInt.Click += new System.EventHandler(this.buttonTestInt_Click);
            // 
            // buttonBasisTest
            // 
            this.buttonBasisTest.Location = new System.Drawing.Point(12, 139);
            this.buttonBasisTest.Name = "buttonBasisTest";
            this.buttonBasisTest.Size = new System.Drawing.Size(75, 23);
            this.buttonBasisTest.TabIndex = 2;
            this.buttonBasisTest.Text = "Basis Test()";
            this.buttonBasisTest.UseVisualStyleBackColor = true;
            this.buttonBasisTest.Click += new System.EventHandler(this.buttonBasisTest_Click);
            // 
            // buttonTestString
            // 
            this.buttonTestString.Location = new System.Drawing.Point(501, 139);
            this.buttonTestString.Name = "buttonTestString";
            this.buttonTestString.Size = new System.Drawing.Size(75, 23);
            this.buttonTestString.TabIndex = 3;
            this.buttonTestString.Text = "Test(string)";
            this.buttonTestString.UseVisualStyleBackColor = true;
            this.buttonTestString.Click += new System.EventHandler(this.buttonTestString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 174);
            this.Controls.Add(this.buttonTestString);
            this.Controls.Add(this.buttonBasisTest);
            this.Controls.Add(this.buttonTestInt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Überladen und Überschreiben";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTestInt;
        private System.Windows.Forms.Button buttonBasisTest;
        private System.Windows.Forms.Button buttonTestString;
    }
}

