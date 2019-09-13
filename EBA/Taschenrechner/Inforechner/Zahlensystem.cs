using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustForYou_Informatik
{
    public partial class fm_Zahlensystem : Form
    {
        public fm_Zahlensystem()
        {
            InitializeComponent();
            var eingabe= Eingabe();
        }

        public  string Eingabe()
        {
            //var eingabe = "3010"; //Dies später durch eingabe aus Eingabemodul ersetzen

            int[] digits = eingabe.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            var pos = digits.Length;
            pos--; //zur Vermeidung von Nullpointern

            //hier wird überprüft welche Zahlen in der Eingabe vorhanden sind und daraus ermittelt welche Zahlensysteme möglich sind
            //deaktiviert RadioButtons für ungültige Zahlensysteme
            while (pos > 0)
            {
                if (digits[pos] > 1)
                {
                    rB_Binär.Enabled = false;
                }
                if (digits[pos] > 7)
                {
                    rB_Octal.Enabled = false;
                }
                if (digits[pos] > 2)
                {
                    rB_Ternär.Enabled = false;
                }
                pos--;
            }
            return eingabe;
        }
        private void btn_weiter_Click(object sender, EventArgs e)
        {

            var ergebnis = "";
            var basis = 0;
            if (rB_Binär.Checked)
            {
                basis = 2;
                ergebnis=Binär(eingabe);
            }
            if (rB_Dezimal.Checked)
            {
                basis = 10;
                ergebnis=Dezimal(eingabe);
            }
            if (rB_Octal.Checked)
            {
                basis = 8;
                ergebnis=Octal(eingabe);
            }
            if (rB_Ternär.Checked)
            {
                basis = 3;
                ergebnis=Ternär(eingabe);
            }
            //Startfenstr aufrufen und ergebnis übertragen
            /*fm_Startfenster x= new fm_Startfenster();
            x.Show(ergebnis);*/
            this.Close();
        }

        public static string Binär(string eingabe)
        {
            string umgewandelt2 = eingabe;
            //in Dezimalsystem konvertieren
            var basis = 2;
            string umgewandelt10=Convert.ToInt32(eingabe, basis).ToString();

            //von Dezimal in Octalsystem konvertieren
            basis = 8;
            string umgewandelt8 = Convert.ToString(Convert.ToInt32(umgewandelt10), basis);

            //von Dezimal in Ternär konvertieren
            basis = 3;
            var umgewandelt3 = "";
            var ergebnis = Convert.ToInt32(umgewandelt10);
            while (ergebnis != 0)
            {
                umgewandelt3 = Convert.ToString(ergebnis % basis) + umgewandelt3;
                ergebnis = (ergebnis / basis);
            }
            /*MessageBox.Show(Convert.ToString(umgewandelt10));
            MessageBox.Show(umgewandelt8);
            MessageBox.Show(umgewandelt2);
            MessageBox.Show(umgewandelt3);*/
            return "Ausgangszahl=" + eingabe + ", im Dezimalsystem: " + umgewandelt10 + "im Binärsystem: " + umgewandelt2 + "im Ternärsystem: " + umgewandelt3 + "im Octalsystem: " + umgewandelt8;
        }

        public static string Dezimal(string eingabewert)
        {
            var eingabe = Convert.ToInt32(eingabewert);
            var umgewandelt10 = eingabe;

            //von Dezimal in Binär konvertieren
            var basis = 2;
            string umgewandelt2 = Convert.ToString(eingabe, basis);

            //von Dezimal in Octal konvertieren
            basis = 8;
            string umgewandelt8 = Convert.ToString(eingabe, basis);

            //von Dezimal in Ternär konvertieren
            basis = 3;
            var umgewandelt3 = "";
            while (eingabe != 0)
            {
                umgewandelt3 = Convert.ToString(eingabe % basis) + umgewandelt3;
                eingabe = (eingabe / basis);
            }
            /*MessageBox.Show(Convert.ToString(umgewandelt10));
            MessageBox.Show(umgewandelt8);
            MessageBox.Show(umgewandelt2);
            MessageBox.Show(umgewandelt3);*/
            return "Ausgangszahl=" + eingabe + ", im Dezimalsystem: " + umgewandelt10 + "im Binärsystem: " + umgewandelt2 + "im Ternärsystem: " + umgewandelt3 + "im Octalsystem: " + umgewandelt8;
        }
       
        public static string Octal(string eingabewert)
        {
            //Konvertierung Octal in Dezimal
            var umgewandelt10 = Convert.ToInt32(eingabewert, 8);

            //Konvertierung Dezimal in Dual
            var basis = 2;
            string umgewandelt2 = Convert.ToString(umgewandelt10, basis);

            //Konvertierung Dezimal in Ternär
            basis = 3;
            var eingabe = Convert.ToInt32(umgewandelt10);
            var umgewandelt3 = "";
            while (eingabe != 0)
            {
                umgewandelt3 = Convert.ToString(eingabe % basis) + umgewandelt3;
                eingabe = (eingabe / basis);
            }

            /*MessageBox.Show(Convert.ToString(umgewandelt10));
            MessageBox.Show(umgewandelt2);
            MessageBox.Show(umgewandelt3);*/
            return "Ausgangszahl=" + eingabe + ", im Dezimalsystem: " + umgewandelt10 + "im Binärsystem: " + umgewandelt2 + "im Ternärsystem: " + umgewandelt3;
        }

        public static string Ternär(string eingabewert)
        {
            var eingabe = Convert.ToInt32(eingabewert);
            var umgewandelt10 = 0;
            //eingabewert in int-Array umwandeln
            int[] digits = eingabewert.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            var pos = digits.Length;
            pos--; //zur Vermeidung von Nullpointern
            var i = 1;
            while (pos>= 0)
            {
                //Ermittlung des Dezimalwertes bzw. Konvertierung von Ternär in Dezimal
                umgewandelt10 = (digits[pos] * i)+umgewandelt10;
                i=i * 3;
                pos--;
            }
            //Konvertierung von Dezimal in Binär
            var basis = 2;
            string umgewandelt2 = Convert.ToString(umgewandelt10, basis);

            //Konvertierung von Dezimal in Octal
            basis = 8;
            string umgewandelt8 = Convert.ToString(umgewandelt10, basis);

            /*MessageBox.Show(Convert.ToString(umgewandelt10));
            MessageBox.Show(umgewandelt2);
            MessageBox.Show(umgewandelt8);*/
            return "Ausgangszahl=" + eingabe + ", im Dezimalsystem: " + umgewandelt10 + "im Binärsystem: " + umgewandelt2  + "im Octalsystem: " + umgewandelt8;
        }
    }
}

