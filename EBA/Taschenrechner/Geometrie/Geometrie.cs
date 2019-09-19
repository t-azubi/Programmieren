using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class GeometrieForm : BaseForm
    {
        public GeometrieForm()
        {
            InitializeComponent();
        }
        public void Area_Circle()
        {
            ShowMessage("Bitte geben sie den Radius an!");
            var meineZahl = returnUserImputValue;
            var area = new Grundrechner().CalcConst("2 *"+new Konstanten().pi.ToString()+" *"+meineZahl.ToString() +" *"+ meineZahl.ToString());
            SetResultInParent("Flächeninhalt Kreis: 2 * (" + new Konstanten().pi.ToString() + " * (" + meineZahl.ToString() + " *" + meineZahl.ToString() + ")) = " + area.ToString());
            Umfang_Circle(meineZahl);
        }

        public void Umfang_Circle(double meineZahl)
        {
            var umfang = new Grundrechner().CalcConst("2 * (" + new Konstanten().pi.ToString() +") *"+ meineZahl.ToString());
            SetResultInParent("Umfang Kreis: 2 * (" + new Konstanten().pi.ToString() + ") *" + meineZahl.ToString() + " = " + umfang.ToString());
        }
        public void area_gramm()
        {
            ShowMessage("Bitte geben sie die Höhe an!");
            var meineZahl = returnUserImputValue;
            ShowMessage("Bitte geben sie die Seitenlänge!");
            var zweiteZahl = returnUserImputValue;
            var area =new Grundrechner().CalcConst( meineZahl.ToString() + " *"+  zweiteZahl.ToString());
            SetResultInParent("Flächeninhalt Parallelogramm: "+meineZahl.ToString() + " *" + zweiteZahl.ToString() +" = " + area.ToString());
            Umfang_gramm(meineZahl, zweiteZahl);
        }
        public void Umfang_gramm(double  meineZahl, double zweiteZahl)
        {
            var umfang = new Grundrechner().CalcConst(" 2 * (" + meineZahl.ToString()+" *" + zweiteZahl.ToString() + ")");
            SetResultInParent("Umfang Parallelogramm: 2 * (" + meineZahl.ToString() + " *" + zweiteZahl.ToString() + ") = "+ umfang.ToString());
        }
        public void Umfang_Dreieck()
        {
            ShowMessage("Bitte geben sie die Seite a an!");
            var meineZahl = returnUserImputValue;
            ShowMessage("Bitte geben sie die Seite b an!");
            var zweiteZahl = returnUserImputValue;
            ShowMessage("Bitte geben sie die Seite c an!");
            var dritteZahl = returnUserImputValue;
            if (checkSites(meineZahl, zweiteZahl, dritteZahl))
            {
                var Umfang = meineZahl + zweiteZahl + dritteZahl;
                SetResultInParent("Umfang Dreieck: "+meineZahl.ToString() + "+" + zweiteZahl.ToString() + "+" + dritteZahl.ToString() + " = " + Umfang.ToString());
                area_Dreieck(meineZahl, zweiteZahl, dritteZahl);
            }
            else
            {
                MessageBox.Show("Bitte überprüfe deine Seitenlängen!");
                Umfang_Dreieck();
            }
        }
        /// <summary>
        /// Checks that 2 sides are allways longer than one 
        /// </summary>
        private bool checkSites(double a, double b, double c)
        {
            if ((a +b >c))
            {
                if ((b +c > a))
                {
                    if ((c +a > b))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public void area_Dreieck(double meineZahl, double zweiteZahl, double dritteZahl)
        {
            var umfang = meineZahl.ToString() + " + " + zweiteZahl.ToString() + "+" + dritteZahl.ToString();
            var root = new Grundrechner().CalcConst("(" + umfang + "/2*("
                + umfang + "/2 -" + meineZahl.ToString() + ")*(" + umfang + "/2-" + zweiteZahl.ToString() + 
                ")*(" + umfang + "/2-" + dritteZahl.ToString() + "))");
            var area = new MathCalc().root(2,root);
             
            SetResultInParent("Flächeninhalt Dreieck: √(" + umfang + "/2*("
                + umfang + "/2 -" + meineZahl.ToString() + ")*(" + umfang + "/2-" + zweiteZahl.ToString() +
                ")*(" + umfang + "/2-" + dritteZahl.ToString() + ")) = " + area.ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Area_Circle();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            area_gramm();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Umfang_Dreieck();
        }

    }
}