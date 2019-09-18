namespace Taschenrechner
{
    partial class Zahlensystemkonvertierung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ter = new System.Windows.Forms.Button();
            this.Bin = new System.Windows.Forms.Button();
            this.oct = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.hex = new System.Windows.Forms.Button();
            this.Konvertieren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ter
            // 
            this.Ter.Location = new System.Drawing.Point(12, 12);
            this.Ter.Name = "Ter";
            this.Ter.Size = new System.Drawing.Size(172, 42);
            this.Ter.TabIndex = 0;
            this.Ter.Text = "Ternär Basis";
            this.Ter.UseVisualStyleBackColor = true;
            this.Ter.Click += new System.EventHandler(this.Ter_Click);
            // 
            // Bin
            // 
            this.Bin.Location = new System.Drawing.Point(212, 12);
            this.Bin.Name = "Bin";
            this.Bin.Size = new System.Drawing.Size(172, 42);
            this.Bin.TabIndex = 1;
            this.Bin.Text = "Binär Basis";
            this.Bin.UseVisualStyleBackColor = true;
            this.Bin.Click += new System.EventHandler(this.Bin_Click);
            // 
            // oct
            // 
            this.oct.Location = new System.Drawing.Point(414, 12);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(172, 42);
            this.oct.TabIndex = 2;
            this.oct.Text = "Octal Basis";
            this.oct.UseVisualStyleBackColor = true;
            this.oct.Click += new System.EventHandler(this.oct_Click);
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(12, 118);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(172, 42);
            this.dec.TabIndex = 3;
            this.dec.Text = "Dezimal Basis";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // hex
            // 
            this.hex.Location = new System.Drawing.Point(212, 118);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(172, 42);
            this.hex.TabIndex = 4;
            this.hex.Text = "Hexadezimal Basis";
            this.hex.UseVisualStyleBackColor = true;
            this.hex.Click += new System.EventHandler(this.hex_Click);
            // 
            // Konvertieren
            // 
            this.Konvertieren.Location = new System.Drawing.Point(414, 118);
            this.Konvertieren.Name = "Konvertieren";
            this.Konvertieren.Size = new System.Drawing.Size(172, 42);
            this.Konvertieren.TabIndex = 5;
            this.Konvertieren.Text = "Konvertieren";
            this.Konvertieren.UseVisualStyleBackColor = true;
            this.Konvertieren.Click += new System.EventHandler(this.Konvertieren_Click);
            // 
            // Zahlensystemkonvertierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 186);
            this.Controls.Add(this.Konvertieren);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.Bin);
            this.Controls.Add(this.Ter);
            this.Name = "Zahlensystemkonvertierung";
            this.Text = "Zahlensystemkonvertierung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ter;
        private System.Windows.Forms.Button Bin;
        private System.Windows.Forms.Button oct;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button hex;
        private System.Windows.Forms.Button Konvertieren;
    }
}