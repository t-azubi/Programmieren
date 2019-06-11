namespace Taschenrechner
{
    partial class ProzentForm
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
            this.Übersicht = new System.Windows.Forms.Label();
            this.dazu = new System.Windows.Forms.Button();
            this.weg = new System.Windows.Forms.Button();
            this.davon = new System.Windows.Forms.Button();
            this.Satz = new System.Windows.Forms.Button();
            this.B2N = new System.Windows.Forms.Button();
            this.N2B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Übersicht
            // 
            this.Übersicht.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Übersicht.AutoSize = true;
            this.Übersicht.Location = new System.Drawing.Point(233, 36);
            this.Übersicht.Name = "Übersicht";
            this.Übersicht.Size = new System.Drawing.Size(63, 13);
            this.Übersicht.TabIndex = 0;
            this.Übersicht.Text = "Funktionen:";
            this.Übersicht.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dazu
            // 
            this.dazu.Location = new System.Drawing.Point(92, 87);
            this.dazu.Name = "dazu";
            this.dazu.Size = new System.Drawing.Size(103, 48);
            this.dazu.TabIndex = 1;
            this.dazu.Text = "%dazu";
            this.dazu.UseVisualStyleBackColor = true;
            this.dazu.Click += new System.EventHandler(this.button1_Click);
            // 
            // weg
            // 
            this.weg.Location = new System.Drawing.Point(92, 153);
            this.weg.Name = "weg";
            this.weg.Size = new System.Drawing.Size(103, 48);
            this.weg.TabIndex = 2;
            this.weg.Text = "%weg";
            this.weg.UseVisualStyleBackColor = true;
            this.weg.Click += new System.EventHandler(this.button2_Click);
            // 
            // davon
            // 
            this.davon.Location = new System.Drawing.Point(92, 220);
            this.davon.Name = "davon";
            this.davon.Size = new System.Drawing.Size(103, 48);
            this.davon.TabIndex = 3;
            this.davon.Text = "% davon";
            this.davon.UseVisualStyleBackColor = true;
            this.davon.Click += new System.EventHandler(this.button3_Click);
            // 
            // Satz
            // 
            this.Satz.Location = new System.Drawing.Point(318, 87);
            this.Satz.Name = "Satz";
            this.Satz.Size = new System.Drawing.Size(103, 48);
            this.Satz.TabIndex = 4;
            this.Satz.Text = "% Satz";
            this.Satz.UseVisualStyleBackColor = true;
            this.Satz.Click += new System.EventHandler(this.button4_Click);
            // 
            // B2N
            // 
            this.B2N.Location = new System.Drawing.Point(318, 153);
            this.B2N.Name = "B2N";
            this.B2N.Size = new System.Drawing.Size(103, 48);
            this.B2N.TabIndex = 5;
            this.B2N.Text = "Brutto von Netto";
            this.B2N.UseVisualStyleBackColor = true;
            this.B2N.Click += new System.EventHandler(this.button5_Click);
            // 
            // N2B
            // 
            this.N2B.Location = new System.Drawing.Point(318, 220);
            this.N2B.Name = "N2B";
            this.N2B.Size = new System.Drawing.Size(103, 48);
            this.N2B.TabIndex = 6;
            this.N2B.Text = "Netto von Brutto";
            this.N2B.UseVisualStyleBackColor = true;
            this.N2B.Click += new System.EventHandler(this.button6_Click);
            // 
            // ProzentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 343);
            this.Controls.Add(this.N2B);
            this.Controls.Add(this.B2N);
            this.Controls.Add(this.Satz);
            this.Controls.Add(this.davon);
            this.Controls.Add(this.weg);
            this.Controls.Add(this.dazu);
            this.Controls.Add(this.Übersicht);
            this.Name = "ProzentForm";
            this.Text = "Prozentrechnung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Übersicht;
        private System.Windows.Forms.Button dazu;
        private System.Windows.Forms.Button weg;
        private System.Windows.Forms.Button davon;
        private System.Windows.Forms.Button Satz;
        private System.Windows.Forms.Button B2N;
        private System.Windows.Forms.Button N2B;
    }
}

