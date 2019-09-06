namespace Taschenrechner
{
    partial class MatheForm
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
            this.fakultät = new System.Windows.Forms.Button();
            this.Wurzel = new System.Windows.Forms.Button();
            this.potenz = new System.Windows.Forms.Button();
            this.primzahlen = new System.Windows.Forms.Button();
            this.dezimalbruchkonvertierung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(256, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funktionen:";
            // 
            // fakultät
            // 
            this.fakultät.Location = new System.Drawing.Point(125, 94);
            this.fakultät.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fakultät.Name = "fakultät";
            this.fakultät.Size = new System.Drawing.Size(153, 51);
            this.fakultät.TabIndex = 1;
            this.fakultät.Text = "Fakultät";
            this.fakultät.UseVisualStyleBackColor = true;
            this.fakultät.Click += new System.EventHandler(this.Fakultät_Click);
            // 
            // Wurzel
            // 
            this.Wurzel.Location = new System.Drawing.Point(350, 94);
            this.Wurzel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Wurzel.Name = "Wurzel";
            this.Wurzel.Size = new System.Drawing.Size(151, 51);
            this.Wurzel.TabIndex = 2;
            this.Wurzel.Text = "Wurzel";
            this.Wurzel.UseVisualStyleBackColor = true;
            this.Wurzel.Click += new System.EventHandler(this.Wurzel_Click);
            // 
            // potenz
            // 
            this.potenz.Location = new System.Drawing.Point(125, 158);
            this.potenz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.potenz.Name = "potenz";
            this.potenz.Size = new System.Drawing.Size(153, 53);
            this.potenz.TabIndex = 3;
            this.potenz.Text = "Potenzfunktion";
            this.potenz.UseVisualStyleBackColor = true;
            this.potenz.Click += new System.EventHandler(this.Potenz_Click);
            // 
            // primzahlen
            // 
            this.primzahlen.Location = new System.Drawing.Point(350, 158);
            this.primzahlen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.primzahlen.Name = "primzahlen";
            this.primzahlen.Size = new System.Drawing.Size(151, 53);
            this.primzahlen.TabIndex = 4;
            this.primzahlen.Text = "Primzahlen";
            this.primzahlen.UseVisualStyleBackColor = true;
            this.primzahlen.Click += new System.EventHandler(this.Primzahlen_Click);
            // 
            // dezimalbruchkonvertierung
            // 
            this.dezimalbruchkonvertierung.Location = new System.Drawing.Point(125, 225);
            this.dezimalbruchkonvertierung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dezimalbruchkonvertierung.Name = "dezimalbruchkonvertierung";
            this.dezimalbruchkonvertierung.Size = new System.Drawing.Size(153, 54);
            this.dezimalbruchkonvertierung.TabIndex = 5;
            this.dezimalbruchkonvertierung.Text = "Dezimalbruch-Konvertierung";
            this.dezimalbruchkonvertierung.UseVisualStyleBackColor = true;
            this.dezimalbruchkonvertierung.Click += new System.EventHandler(this.Dezimalbruchkonvertierung_Click);
            // 
            // MatheForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 366);
            this.Controls.Add(this.dezimalbruchkonvertierung);
            this.Controls.Add(this.primzahlen);
            this.Controls.Add(this.potenz);
            this.Controls.Add(this.Wurzel);
            this.Controls.Add(this.fakultät);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MatheForm";
            this.Text = "Mathematische Funktionen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fakultät;
        private System.Windows.Forms.Button Wurzel;
        private System.Windows.Forms.Button potenz;
        private System.Windows.Forms.Button primzahlen;
        private System.Windows.Forms.Button dezimalbruchkonvertierung;
    }
}

