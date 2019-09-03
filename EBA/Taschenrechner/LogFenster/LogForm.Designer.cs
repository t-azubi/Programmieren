namespace Taschenrechner
{
    partial class LogForm
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
            this.Log = new System.Windows.Forms.RichTextBox();
            this.Prozentrechnung = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.menüToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintergrundfarbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schriftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schriftfarbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Geometrie = new System.Windows.Forms.Button();
            this.Schule = new System.Windows.Forms.Button();
            this.Mathe = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(5, 47);
            this.Log.Name = "Log";
            this.Log.ReadOnly = true;
            this.Log.Size = new System.Drawing.Size(567, 247);
            this.Log.TabIndex = 0;
            this.Log.Text = "";
            // 
            // Prozentrechnung
            // 
            this.Prozentrechnung.Location = new System.Drawing.Point(12, 300);
            this.Prozentrechnung.Name = "Prozentrechnung";
            this.Prozentrechnung.Size = new System.Drawing.Size(147, 32);
            this.Prozentrechnung.TabIndex = 1;
            this.Prozentrechnung.Text = "Prozentrechnung";
            this.Prozentrechnung.UseVisualStyleBackColor = false;
            this.Prozentrechnung.Click += new System.EventHandler(this.OpenProzentrechnung_Click);
            // 
            // Menu
            // 
            this.Menu.GripMargin = new System.Windows.Forms.Padding(292, 2, 1000, 2);
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menüToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(576, 27);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "Menu";
            // 
            // menüToolStripMenuItem
            // 
            this.menüToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hintergrundfarbeToolStripMenuItem,
            this.schriftToolStripMenuItem,
            this.schriftfarbeToolStripMenuItem});
            this.menüToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menüToolStripMenuItem.Name = "menüToolStripMenuItem";
            this.menüToolStripMenuItem.Size = new System.Drawing.Size(57, 23);
            this.menüToolStripMenuItem.Text = "Menü";
            // 
            // hintergrundfarbeToolStripMenuItem
            // 
            this.hintergrundfarbeToolStripMenuItem.Name = "hintergrundfarbeToolStripMenuItem";
            this.hintergrundfarbeToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.hintergrundfarbeToolStripMenuItem.Text = "Hintergrundfarbe";
            this.hintergrundfarbeToolStripMenuItem.Click += new System.EventHandler(this.HintergrundfarbeToolStripMenuItem_Click);
            // 
            // schriftToolStripMenuItem
            // 
            this.schriftToolStripMenuItem.Name = "schriftToolStripMenuItem";
            this.schriftToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.schriftToolStripMenuItem.Text = "Schrift";
            this.schriftToolStripMenuItem.Click += new System.EventHandler(this.SchriftToolStripMenuItem_Click);
            // 
            // schriftfarbeToolStripMenuItem
            // 
            this.schriftfarbeToolStripMenuItem.Name = "schriftfarbeToolStripMenuItem";
            this.schriftfarbeToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.schriftfarbeToolStripMenuItem.Text = "Schriftfarbe";
            this.schriftfarbeToolStripMenuItem.Click += new System.EventHandler(this.SchriftfarbeToolStripMenuItem_Click);
            // 
            // Geometrie
            // 
            this.Geometrie.Location = new System.Drawing.Point(179, 300);
            this.Geometrie.Name = "Geometrie";
            this.Geometrie.Size = new System.Drawing.Size(147, 32);
            this.Geometrie.TabIndex = 3;
            this.Geometrie.Text = "Geometrie";
            this.Geometrie.UseVisualStyleBackColor = false;
            this.Geometrie.Click += new System.EventHandler(this.Open_Geometrie_Click);
            // 
            // Schule
            // 
            this.Schule.Location = new System.Drawing.Point(344, 300);
            this.Schule.Name = "Schule";
            this.Schule.Size = new System.Drawing.Size(147, 32);
            this.Schule.TabIndex = 4;
            this.Schule.Text = "Schule";
            this.Schule.UseVisualStyleBackColor = false;
            this.Schule.Click += new System.EventHandler(this.Schule_Click);
            // 
            // Mathe
            // 
            this.Mathe.Location = new System.Drawing.Point(12, 359);
            this.Mathe.Name = "Mathe";
            this.Mathe.Size = new System.Drawing.Size(147, 32);
            this.Mathe.TabIndex = 5;
            this.Mathe.Text = "Mathematische Funktionen";
            this.Mathe.UseVisualStyleBackColor = false;
            this.Mathe.Click += new System.EventHandler(this.Mathe_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(576, 443);
            this.Controls.Add(this.Mathe);
            this.Controls.Add(this.Schule);
            this.Controls.Add(this.Geometrie);
            this.Controls.Add(this.Prozentrechnung);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.Menu;
            this.Name = "LogForm";
            this.Text = "LogFenster";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Log;
        private System.Windows.Forms.Button Prozentrechnung;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem menüToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintergrundfarbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schriftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schriftfarbeToolStripMenuItem;
        private System.Windows.Forms.Button Geometrie;
        private System.Windows.Forms.Button Schule;
        private System.Windows.Forms.Button Mathe;
    }
}

