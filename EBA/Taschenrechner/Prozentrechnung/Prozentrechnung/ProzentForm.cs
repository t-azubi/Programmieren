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
            InitializeComponent();
        }
        public void SetResultInParent(string label)
        {
            AdviseParent(label);

        }
        public void SetFromForm2(string result)
        {
            helper = Convert.ToInt32(result);
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
            var ergebnis = sovielProzent / 100 * meineZahl;
            var endergebnis = meineZahl + ergebnis;
            MessageBox.Show(endergebnis.ToString());
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

            var ergebnis = sovielProzent / 100 * meineZahl;
            var endergebnis = meineZahl - ergebnis;
            MessageBox.Show(endergebnis.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte gib die Grundzahl ein");
           var meineZahl = helper;
            ShowMessage("Geben sie die Prozentzahl ein!");
            var sovielProzent = helper;
            var ergebnis = sovielProzent / 100 * meineZahl;
            MessageBox.Show(ergebnis.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //EingabeForm.ShowDialog("Geben sie ihre Zahl ein!");
            //decimal meineZahl = EingabeForm.zahlholen();
            //
            //EingabeForm.ShowDialog("Geben sie die zweite Zahl ein!");
            //decimal zweiteZahl = EingabeForm.zahlholen();
            //
            //meineZahl = 100;
            //zweiteZahl = 20;
            //
            //decimal ergebnis = zweiteZahl * 100 / meineZahl;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //EingabeForm.ShowDialog("Geben sie ihr Netto an!");
            //decimal meineZahl = EingabeForm.zahlholen();
            //
            //EingabeForm.ShowDialog("Geben sie ihre Steuern in Przent an!");
            //decimal zweiteZahl = EingabeForm.zahlholen();
            //
            //
            //decimal ergebnis = meineZahl * zweiteZahl / 100 + 1;
            //
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //EingabeForm.ShowDialog();
            //decimal meineZahl = EingabeForm.zahlholen();
            //
            //EingabeForm.ShowDialog();
            //decimal zweiteZahl = EingabeForm.zahlholen();
            //decimal ergebnis = meineZahl * (1 - (zweiteZahl / 100));
        }
    }
}
