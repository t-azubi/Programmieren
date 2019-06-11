namespace Taschenrechner
{
    partial class EingabeForm
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
            this.one = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.uebernehmen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VariableValue = new System.Windows.Forms.TextBox();
            this.negative = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.nebenrechnungen = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(0, 161);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(94, 32);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Add_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(193, 161);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(94, 32);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Add_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(0, 116);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(94, 32);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Add_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(97, 116);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(94, 32);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Add_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(193, 116);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(94, 32);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Add_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(0, 69);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(94, 32);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Add_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(97, 69);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(94, 32);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Add_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(193, 69);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(94, 32);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Add_Click);
            // 
            // comma
            // 
            this.comma.Location = new System.Drawing.Point(193, 205);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(94, 32);
            this.comma.TabIndex = 10;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.Add_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 205);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(191, 32);
            this.button12.TabIndex = 11;
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Add_Click);
            // 
            // uebernehmen
            // 
            this.uebernehmen.Location = new System.Drawing.Point(293, 10);
            this.uebernehmen.Name = "uebernehmen";
            this.uebernehmen.Size = new System.Drawing.Size(94, 34);
            this.uebernehmen.TabIndex = 14;
            this.uebernehmen.Text = "Übernehmen";
            this.uebernehmen.UseVisualStyleBackColor = true;
            this.uebernehmen.Click += new System.EventHandler(this.Uebernehmen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Variablenname :";
            // 
            // VariableValue
            // 
            this.VariableValue.Location = new System.Drawing.Point(97, 24);
            this.VariableValue.Name = "VariableValue";
            this.VariableValue.Size = new System.Drawing.Size(163, 20);
            this.VariableValue.TabIndex = 16;
            // 
            // negative
            // 
            this.negative.Location = new System.Drawing.Point(293, 116);
            this.negative.Name = "negative";
            this.negative.Size = new System.Drawing.Size(94, 32);
            this.negative.TabIndex = 17;
            this.negative.Text = "-";
            this.negative.UseVisualStyleBackColor = true;
            this.negative.Click += new System.EventHandler(this.Add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(293, 205);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 32);
            this.delete.TabIndex = 18;
            this.delete.Text = "Löschen";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(293, 161);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(94, 32);
            this.clear.TabIndex = 19;
            this.clear.Text = "Leeren";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // nebenrechnungen
            // 
            this.nebenrechnungen.Location = new System.Drawing.Point(293, 69);
            this.nebenrechnungen.Name = "nebenrechnungen";
            this.nebenrechnungen.Size = new System.Drawing.Size(94, 32);
            this.nebenrechnungen.TabIndex = 20;
            this.nebenrechnungen.Text = "Nebenrechnung";
            this.nebenrechnungen.UseVisualStyleBackColor = true;
            this.nebenrechnungen.Click += new System.EventHandler(this.Nebenrechnungen_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(97, 161);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(94, 32);
            this.two.TabIndex = 21;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // EingabeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 237);
            this.Controls.Add(this.two);
            this.Controls.Add(this.nebenrechnungen);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.negative);
            this.Controls.Add(this.VariableValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uebernehmen);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.one);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EingabeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EingabeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button uebernehmen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VariableValue;
        private System.Windows.Forms.Button negative;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button nebenrechnungen;
        private System.Windows.Forms.Button two;
    }
}

