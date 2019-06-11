using System;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class ProzentForm : Form
    {
        public int helper = 0;
        private EingabeForm EingabeForm = new EingabeForm();
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent = delegate { };
        public ProzentForm()
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
            if (result.IndexOf('=') == -1)
            {
                helper = Convert.ToInt32(result);
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
        private void button1_Click(object sender, EventArgs e)
        {
            ShowMessage("Gib die Grundzahl ein");
            var meineZahl = helper;
            ShowMessage("Wieviel Prozent soll dazu gerechnet werden ?");
            var sovielProzent = helper;
            var endergebnis = meineZahl + new Grundrechner().CalcConst(sovielProzent.ToString() + " / 100 * " + meineZahl.ToString());
            SetResultInParent("( " + sovielProzent.ToString() + " / 100 * " + meineZahl.ToString() + " ) + " + meineZahl.ToString() + " = " + endergebnis.ToString());
            if (sovielProzent < 0)
            {
                MessageBox.Show("Geben sie eine korrekte Zahl ein");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte gib die Grundzahl ein");
            var meineZahl = helper;
            ShowMessage("Wieviel Prozent sollen abgezogen werden? ");
            var sovielProzent = helper;
            var endergebnis = meineZahl - new Grundrechner().CalcConst(sovielProzent.ToString()+ " / 100 * " +meineZahl.ToString()) ;
            SetResultInParent(meineZahl.ToString() + " - ( " + sovielProzent.ToString() + " / 100 * " + meineZahl.ToString() + ")  = " + endergebnis.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte gib die Grundzahl ein");
            var meineZahl = helper;
            ShowMessage("Geben sie die Prozentzahl ein!");
            var sovielProzent = helper;
            var ergebnis = new Grundrechner().CalcConst(sovielProzent.ToString() +"/ 100 *"+ meineZahl.ToString());
            SetResultInParent(sovielProzent.ToString() + " / 100 * " + meineZahl.ToString() + " = " + ergebnis.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte gib die Grundzahl ein");
            var meineZahl = helper;
            ShowMessage("Geben sie die zweite Zahl ein!");
            var zweiteZahl = helper;
            var ergebnis = new Grundrechner().CalcConst(zweiteZahl.ToString()+ " * 100 / " + meineZahl.ToString());
            SetResultInParent(zweiteZahl.ToString() + " * 100 / " + meineZahl.ToString() + " = " + ergebnis.ToString());
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie ihr Netto an!");
            var meineZahl = helper;
            ShowMessage("Geben sie ihre Steuern in Prozent an!");
            var zweiteZahl = helper;
            var ergebnis = new Grundrechner().CalcConst(meineZahl.ToString() +"*"+ zweiteZahl.ToString() +"/ 100 + 1");
            SetResultInParent(meineZahl.ToString() + " * " + zweiteZahl.ToString() + " / 100 + 1 = " + ergebnis.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie ihr Brutto an!");
            var meineZahl = helper;
            ShowMessage(" Geben sie ihre Steuern in Prozent an");
            var zweiteZahl = helper;
            var ergebnis = new Grundrechner().CalcConst(meineZahl.ToString() + "* (1 - (" + zweiteZahl.ToString() + " / 100)");
            SetResultInParent(meineZahl.ToString() + " * ( 1 - ( " + zweiteZahl.ToString() + " / 100 ) ) = " + ergebnis.ToString());
        }
    }
}
