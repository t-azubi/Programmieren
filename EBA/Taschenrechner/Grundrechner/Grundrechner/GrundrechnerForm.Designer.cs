namespace Taschenrechner
{
    partial class GrundrechnerForm
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
            this.Input = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Solve = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiplier = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.Bracket_Open = new System.Windows.Forms.Button();
            this.Bracket_Close = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.übernehmen = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.Rechenschritte = new System.Windows.Forms.Button();
            this.RechenschritteOutput = new System.Windows.Forms.RichTextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(10, 41);
            this.Input.Name = "Input";
            this.Input.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Input.Size = new System.Drawing.Size(214, 20);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(10, 76);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(47, 23);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.Add_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(63, 76);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(47, 23);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Add_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(116, 76);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(47, 23);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Add_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(10, 105);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(47, 23);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Add_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(63, 105);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(47, 23);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Add_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(116, 106);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(47, 23);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Add_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(10, 135);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(47, 23);
            this.seven.TabIndex = 7;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Add_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(63, 135);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(47, 23);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Add_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(116, 135);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(47, 23);
            this.nine.TabIndex = 9;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Add_Click);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(63, 194);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(47, 23);
            this.Solve.TabIndex = 10;
            this.Solve.Text = "=";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(177, 76);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(47, 23);
            this.plus.TabIndex = 11;
            this.plus.Text = " + ";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Add_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(177, 106);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(47, 23);
            this.minus.TabIndex = 12;
            this.minus.Text = " - ";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Add_Click);
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(177, 135);
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(47, 23);
            this.multiplier.TabIndex = 13;
            this.multiplier.Text = " * ";
            this.multiplier.UseVisualStyleBackColor = true;
            this.multiplier.Click += new System.EventHandler(this.Add_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(177, 164);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(47, 23);
            this.division.TabIndex = 14;
            this.division.Text = " / ";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Add_Click);
            // 
            // Bracket_Open
            // 
            this.Bracket_Open.Location = new System.Drawing.Point(10, 164);
            this.Bracket_Open.Name = "Bracket_Open";
            this.Bracket_Open.Size = new System.Drawing.Size(47, 23);
            this.Bracket_Open.TabIndex = 15;
            this.Bracket_Open.Text = " ( ";
            this.Bracket_Open.UseVisualStyleBackColor = true;
            this.Bracket_Open.Click += new System.EventHandler(this.Add_Click);
            // 
            // Bracket_Close
            // 
            this.Bracket_Close.Location = new System.Drawing.Point(116, 164);
            this.Bracket_Close.Name = "Bracket_Close";
            this.Bracket_Close.Size = new System.Drawing.Size(47, 23);
            this.Bracket_Close.TabIndex = 16;
            this.Bracket_Close.Text = " ) ";
            this.Bracket_Close.UseVisualStyleBackColor = true;
            this.Bracket_Close.Click += new System.EventHandler(this.Add_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(63, 164);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(47, 23);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Add_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(177, 194);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(47, 23);
            this.Clear.TabIndex = 18;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(116, 194);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(47, 23);
            this.Delete.TabIndex = 19;
            this.Delete.Text = "Del";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // comma
            // 
            this.comma.Location = new System.Drawing.Point(10, 194);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(47, 23);
            this.comma.TabIndex = 20;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.Add_Click);
            // 
            // übernehmen
            // 
            this.übernehmen.Location = new System.Drawing.Point(276, 137);
            this.übernehmen.Name = "übernehmen";
            this.übernehmen.Size = new System.Drawing.Size(89, 23);
            this.übernehmen.TabIndex = 21;
            this.übernehmen.Text = "Übernehmen";
            this.übernehmen.UseVisualStyleBackColor = true;
            this.übernehmen.Click += new System.EventHandler(this.Übernehmen_Click);
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(276, 164);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(89, 36);
            this.history.TabIndex = 22;
            this.history.Text = "Übernehmen in Historie";
            this.history.UseVisualStyleBackColor = true;
            this.history.Click += new System.EventHandler(this.History_Click);
            // 
            // Rechenschritte
            // 
            this.Rechenschritte.Location = new System.Drawing.Point(276, 106);
            this.Rechenschritte.Name = "Rechenschritte";
            this.Rechenschritte.Size = new System.Drawing.Size(89, 23);
            this.Rechenschritte.TabIndex = 23;
            this.Rechenschritte.Text = "Rechenschritte";
            this.Rechenschritte.UseVisualStyleBackColor = true;
            this.Rechenschritte.Click += new System.EventHandler(this.Rechenschritte_Click);
            // 
            // RechenschritteOutput
            // 
            this.RechenschritteOutput.Location = new System.Drawing.Point(229, 6);
            this.RechenschritteOutput.Margin = new System.Windows.Forms.Padding(2);
            this.RechenschritteOutput.Name = "RechenschritteOutput";
            this.RechenschritteOutput.ReadOnly = true;
            this.RechenschritteOutput.Size = new System.Drawing.Size(182, 97);
            this.RechenschritteOutput.TabIndex = 24;
            this.RechenschritteOutput.Text = "";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(10, 6);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Output.Size = new System.Drawing.Size(214, 20);
            this.Output.TabIndex = 25;
            // 
            // GrundrechnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 229);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.RechenschritteOutput);
            this.Controls.Add(this.Rechenschritte);
            this.Controls.Add(this.history);
            this.Controls.Add(this.übernehmen);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.Bracket_Close);
            this.Controls.Add(this.Bracket_Open);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplier);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.Input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GrundrechnerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Grundrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiplier;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button Bracket_Open;
        private System.Windows.Forms.Button Bracket_Close;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button übernehmen;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Button Rechenschritte;
        private System.Windows.Forms.RichTextBox RechenschritteOutput;
        private System.Windows.Forms.TextBox Output;
    }
}

