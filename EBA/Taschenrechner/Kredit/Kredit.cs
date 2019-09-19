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

            double Kreditbetrag = helper;

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshöhe = helper;

            ShowMessage("Geben sie die Laufzeit in Jahren an!");

            double Laufzeit = helper;

            double zins =(1 + Zinshöhe / 100);
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double result = Kreditbetrag * tempresult;
            double Zinsen_gesamt = tempresult * Kreditbetrag - Kreditbetrag;


            SetResultInParent($"({Kreditbetrag} * ((1+ {Zinshöhe}/100)^{Laufzeit}) = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit}");
            SetResultInParent($"Ratenhöhe (einmalig): {result} Zinsen insgesamt: {Zinsen_gesamt}");

        }

        private void btn_Laufzeitkredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = helper;

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshöhe = helper;

            ShowMessage("Geben sie die Laufzeit in Jahren an!");

            double Laufzeit = helper;

            double zins =(1+ Zinshöhe / 100);
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double Monatsrate = tempresult * Kreditbetrag / (12 * Laufzeit);
            double Zinsen_gesamt = tempresult * Kreditbetrag -Kreditbetrag;

            SetResultInParent($"({Kreditbetrag} * (1+ {Zinshöhe}/100)^{Laufzeit} /12 /Laufzeit= {Monatsrate}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit}");
            SetResultInParent($"Ratenhöhe (monatlich):  {Monatsrate} Zinsen insgesamt: {Zinsen_gesamt}");
        }

        private void Btn_Ratenhöhekredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = helper;

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshoehe = helper;

            ShowMessage("Geben sie die Ratenhöhe pro Monat an!");

            double Ratenhoehe = helper;
            double counter = 0;
            double zins = (1 + Zinshoehe / 100);
            double Kreditbetrag1 = Kreditbetrag;
            do
            {
                Kreditbetrag = (Kreditbetrag - Ratenhoehe) * zins;
                counter++;
            }
            while ( Kreditbetrag > Ratenhoehe );
            
            double Laufzeit = counter + Kreditbetrag/Ratenhoehe;

       
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double Monatsrate = tempresult * Kreditbetrag / (12 * Laufzeit);
            double Zinsen_gesamt = tempresult * Kreditbetrag - Kreditbetrag;



            //SetResultInParent($"({Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag}) / {Laufzeit} = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag1}, Zinssatz: {Zinshoehe}, Ratenhöhe: (monatlich) {Ratenhoehe}");
            SetResultInParent($"Laufzeit: {Laufzeit}, Zinsen (gesamt): {Zinsen_gesamt}");
        }
    }
}
