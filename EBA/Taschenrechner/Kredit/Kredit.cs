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

            double Kreditbetrag = returnUserInputValue;
            if(Kreditbetrag <= 0)
            {
                SetResultInParent($"Eingabe ungültig!");
                return;
            }

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshöhe = returnUserInputValue;

            ShowMessage("Geben sie die Laufzeit in Jahren an!");

            double Laufzeit = returnUserInputValue;
            if (Laufzeit <= 0)
            {
                SetResultInParent($"Eingabe ungültig!");
                return;
            }

            double zins =(1 + Zinshöhe / 100);
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double result = Kreditbetrag * tempresult;
            double Zinsen_gesamt = tempresult * Kreditbetrag - Kreditbetrag;

            SetResultInParent($"({Kreditbetrag} * ((1+ {Zinshöhe}/100)^{Laufzeit} Jahre) = {result}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit} Jahre");
            SetResultInParent($"Ratenhöhe (einmalig): {result} Zinsen insgesamt: {Zinsen_gesamt}");

        }

        private void btn_Laufzeitkredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserInputValue;
            if (Kreditbetrag <= 0)
            {
                SetResultInParent($"Eingabe ungültig!");
                return;
            }

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshöhe = returnUserInputValue;

            ShowMessage("Geben sie die Laufzeit in Jahren an!");

            double Laufzeit = returnUserInputValue;
            if (Laufzeit <= 0)
            {
                SetResultInParent($"Eingabe ungültig!");
                return;
            }

            double zins =(1+ Zinshöhe / 100);
            double tempresult = new MathCalc().Power(zins, Laufzeit);
            double Monatsrate = tempresult * Kreditbetrag / (12 * Laufzeit);
            double Zinsen_gesamt = tempresult * Kreditbetrag -Kreditbetrag;

            SetResultInParent($"({Kreditbetrag} * (1+ {Zinshöhe}/100)^{Laufzeit} Jahre /12 = {Monatsrate}");
            SetResultInParent($"Kreditbetrag: {Kreditbetrag}, Zinssatz: {Zinshöhe}, Laufzeit: {Laufzeit} Jahre");
            SetResultInParent($"Ratenhöhe (monatlich):  {Monatsrate} Zinsen insgesamt: {Zinsen_gesamt}");
        }

        private void Btn_Ratenhöhekredit_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie den Kreditbetrag an");

            double Kreditbetrag = returnUserInputValue;
            if (Kreditbetrag <= 0)
            {
                SetResultInParent($"Eingabe ungültig!");
                return;
            }

            ShowMessage("Geben sie den Jahreszins in % an");

            double Zinshoehe = returnUserInputValue;

            ShowMessage("Geben sie die Ratenhöhe pro Monat an!");

            double Ratenhoehe = (returnUserInputValue * 12);
            if (Ratenhoehe <= 0)
            {
                SetResultInParent($"Eingabe ungültig!");
                return;
            }
            double counter = 0;
            double zins = (1 + Zinshoehe / 100);
            //Kreditbetrag_Start to store value of this time of code
            double Kreditbetrag_Start = Kreditbetrag;

            double Tilgung_Start = Ratenhoehe - ( zins * ( Kreditbetrag_Start - Ratenhoehe) );

            double Laufzeit;

            if (Tilgung_Start > 0)
            {

                while (Kreditbetrag > Ratenhoehe)
                {
                    Kreditbetrag = (Kreditbetrag - Ratenhoehe) * zins;
                    counter++;
                }
                

                double Restlaufzeit = Kreditbetrag / Ratenhoehe * zins;

                Laufzeit = counter + Restlaufzeit;


                double tempresult = new MathCalc().Power(zins, Laufzeit);
                double Zinsen_gesamt = tempresult * Kreditbetrag_Start - Kreditbetrag_Start;



                //SetResultInParent($"({Kreditbetrag} * {Zinshöhe}/100 *{Laufzeit}/12 + {Kreditbetrag}) / {Laufzeit} = {result}");
                SetResultInParent($"Kreditbetrag: {Kreditbetrag_Start}, Zinssatz: {Zinshoehe}, Ratenhöhe: (monatlich) {Ratenhoehe/12}");
                SetResultInParent($"Laufzeit: {Laufzeit} Jahre, Zinsen (gesamt): {Zinsen_gesamt}");

            } else
            {

                SetResultInParent($"Ersten Jahr ergibt sich bereits eine Tilgung von {Tilgung_Start/12}€ pro Monat.");
                SetResultInParent($"Somit ist der Kredit niemals rückzahlbar!");

            }
        }
    }
}
