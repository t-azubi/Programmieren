using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class LogForm : Form
    {
        private ProzentForm ProzentForm = new ProzentForm();
        private GeometrieForm GeometrieForm = new GeometrieForm();
        private ColorDialog color = new ColorDialog();
        private FontDialog FontDialog = new FontDialog();
        private MatheForm MatheForm = new MatheForm();
        public LogForm()
        {
            InitializeComponent();
            ProzentForm.AdviseParent += new ProzentForm.AdviseParentEventHandler(SetFromForm2);
            MatheForm.AdviseParent += new MatheForm.AdviseParentEventHandler(SetFromForm2);
            GeometrieForm.AdviseParent += new GeometrieForm.AdviseParentEventHandler(SetFromForm2);
            this.Font = new Font("Arial", 8);
            Menu.Font = this.Font;
        }
        private void OpenProzentrechnung_Click(object sender, EventArgs e)
        {
            LogFormatierung("Prozentrechnung");
            ProzentForm.Font = this.Font;
            ProzentForm.ForeColor = this.ForeColor;
            ProzentForm.BackColor = this.BackColor;
            ProzentForm.ShowDialog();
        }
        public void SetFromForm2(string result)
        {
            Log.AppendText(result + Environment.NewLine);
        }
        private void HintergrundfarbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color.ShowDialog();
            Menu.BackColor = color.Color;
            this.BackColor = color.Color;
        }

        private void SchriftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog.ShowDialog();
            menüToolStripMenuItem.Font = FontDialog.Font;
            this.Font = FontDialog.Font;
        }

        private void SchriftfarbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color.ShowDialog();
            Menu.ForeColor = color.Color;
            this.ForeColor = color.Color;
        }

        private void Open_Geometrie_Click(object sender, EventArgs e)
        {
            LogFormatierung("Geometrie");
            GeometrieForm.Font = this.Font;
            GeometrieForm.ForeColor = this.ForeColor;
            GeometrieForm.BackColor = this.BackColor;
            GeometrieForm.ShowDialog();
        }

        private void Schule_Click(object sender, EventArgs e)
        {
            LogFormatierung("Schule");
            var result = new Schule().StartModule(this.Font, this.ForeColor, this.BackColor);
            foreach (var item in result)
            {
                SetFromForm2(item);
            }
        }
        private void LogFormatierung(string LoadedForm)
        {
            Log.AppendText(Environment.NewLine);
            var firstIndex = Log.Text.Length;
            Log.AppendText(LoadedForm + Environment.NewLine + Environment.NewLine);
            Log.Select(firstIndex, LoadedForm.Length);
            Log.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void Mathe_Click(object sender, EventArgs e)
        {
            LogFormatierung("Mathematische Funktionen");
            MatheForm.Font = this.Font;
            MatheForm.ForeColor = this.ForeColor;
            MatheForm.BackColor = this.BackColor;
            MatheForm.ShowDialog();
        }
    }
}
