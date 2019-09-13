using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taschenrechner;

namespace Taschenrechner


{
    public partial class Kredit : Form
    {
        public double helper = 0;
        private EingabeForm EingabeForm = new EingabeForm();
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent;
        public Kredit()
        {
            EingabeForm.AdviseParent += new EingabeForm.AdviseParentEventHandler(SetFromForm2);
            EingabeForm.Font = this.Font;
            EingabeForm.ForeColor = this.ForeColor;
            EingabeForm.BackColor = this.BackColor;
            InitializeComponent();
        }
        public void SetResultInParent(string label)
        {
            AdviseParent(label);
        }
        public void SetFromForm2(string result)
        {
            if ((result.IndexOf('=') == -1))
            {
                helper = Convert.ToDouble(result);
            }
            else
            {
                SetResultInParent(result);
            }
        }
        private void ShowMessage(string Message)
        {
            MessageBox.Show(Message, "Zahleneingabe");
            EingabeForm.ShowDialog();
        }
        private void btn_Krediteinmalig_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben Sie den Kreditbetrag an");

            double Kreditbetrag = helper;

            ShowMessage("Geben Sie den Jahreszins an");

            double Zinshöhe = helper;

            ShowMessage("Geben Sie die Laufzeit in Monaten an!");

            double Laufzeit = helper;

            double Zinsen_gesamt = Kreditbetrag * Zinshöhe / 100 * Laufzeit / 12;

            double result = Zinsen_gesamt + Kreditbetrag;
            SetResultInParent($"{Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit}");
            SetResultInParent($"Ratenhöhe: (einmalig) {result}, Zinsen_gesamt (gesamt): {Zinsen_gesamt}");

        }

        private void btn_Laufzeitkredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben Sie den Kreditbetrag an");

            double Kreditbetrag = helper;

            ShowMessage("Geben Sie den Jahreszins an");

            double Zinshöhe = helper;

            ShowMessage("Geben Sie die Laufzeit in Monaten an!");

            double Laufzeit = helper;

            double Zinsen_gesamt = Kreditbetrag * Zinshöhe / 100 * Laufzeit / 12;

            double result = (Zinsen_gesamt + Kreditbetrag) / Laufzeit;

            SetResultInParent($"({Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag}) / {Laufzeit} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit}");
            SetResultInParent($"Ratenhöhe: (monatlich) {result}, Zinsen (gesamt): {Zinsen_gesamt}");
        }

        private void Btn_Ratenhöhekredit_Click(object sender, EventArgs e)
        {
            var calc = new MathCalc();
            ShowMessage("Geben Sie den Kreditbetrag an");

            double Kreditbetrag = helper;

            ShowMessage("Geben Sie den Jahreszins an");

            double Zinshöhe = helper;

            ShowMessage("Geben Sie die Ratenhöhe an!");

            double Ratenhoehe = helper;

            double Zinsen_gesamt = 0;
            double Laufzeit = 0;

            double Schlussrate = 0;

            for(int i = 0; i < 50; i++)
            {
                Laufzeit = ( Kreditbetrag + Zinsen_gesamt ) / Ratenhoehe;
                Zinsen_gesamt = Kreditbetrag * Zinshöhe /100 * Laufzeit / 12;
            }

            if(Laufzeit != calc.RoundDown(Laufzeit))
            {
                Schlussrate = (Kreditbetrag + Zinsen_gesamt) - (calc.RoundDown(Laufzeit) * Ratenhoehe);
            }
            
            
            //SetResultInParent($"({Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag}) / {Laufzeit} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Ratenhöhe: (monatlich) {Ratenhoehe}");
            SetResultInParent($"Laufzeit: {Laufzeit}, Zinsen (gesamt): {Zinsen_gesamt}€, Schlussrate: {Schlussrate}€");
        }
    }
}
