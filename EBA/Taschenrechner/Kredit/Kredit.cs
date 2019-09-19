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
    public partial class KreditForm : BaseForm
    {
        public KreditForm()
        {
            InitializeComponent();
        }
        private void btn_Krediteinmalig_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserImputValue;

            ShowMessage("Geben sie den Jahreszins an");

            double Zinshöhe = returnUserImputValue;

            ShowMessage("Geben sie die Laufzeit in Monaten an!");

            double Laufzeit = returnUserImputValue;

            double Zinsen_gesamt = Kreditbetrag * Zinshöhe / 100 * Laufzeit / 12;

            double result = Zinsen_gesamt + Kreditbetrag;
            SetResultInParent($"{Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit}");
            SetResultInParent($"Ratenhöhe: (einmalig) {result}, Zinsen_gesamt (gesamt): {Zinsen_gesamt}");

        }

        private void btn_Laufzeitkredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserImputValue;

            ShowMessage("Geben sie den Jahreszins an");

            double Zinshöhe = returnUserImputValue;

            ShowMessage("Geben sie die Laufzeit in Monaten an!");

            double Laufzeit = returnUserImputValue;

            double Zinsen_gesamt = Kreditbetrag * Zinshöhe / 100 * Laufzeit / 12;

            double result = (Zinsen_gesamt + Kreditbetrag) / Laufzeit;

            SetResultInParent($"({Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag}) / {Laufzeit} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit}");
            SetResultInParent($"Ratenhöhe: (monatlich) {result}, Zinsen (gesamt): {Zinsen_gesamt}");
        }

        private void Btn_Ratenhöhekredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserImputValue;

            ShowMessage("Geben sie den Jahreszins an");

            double Zinshöhe = returnUserImputValue;

            ShowMessage("Geben sie die Ratenhöhe an!");

            double Ratenhoehe = returnUserImputValue;

            double Zinsen_gesamt = 0;
            double Laufzeit = 0;

            for(int i = 0; i < 50; i++)
            {
                Laufzeit = ( Kreditbetrag + Zinsen_gesamt ) / Ratenhoehe;
                Zinsen_gesamt = Kreditbetrag * Zinshöhe /100 * Laufzeit / 12;
            }
            
            //SetResultInParent($"({Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag}) / {Laufzeit} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Ratenhöhe: (monatlich) {Ratenhoehe}");
            SetResultInParent($"Laufzeit: {Laufzeit}, Zinsen (gesamt): {Zinsen_gesamt}");
        }
    }
}
