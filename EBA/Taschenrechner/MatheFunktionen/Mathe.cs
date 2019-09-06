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
    public partial class MatheForm : Form
    {
        public double helper = 0;
        private EingabeForm EingabeForm = new EingabeForm();
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent;
        public MatheForm()
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

        private void Fakultät_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben Sie die Zahl an von der Sie die Fakultät berechnen wollen.");
            if (helper % 1 != 0 && helper < 0)
            {
                ShowMessage("Man kann nur von ganzahligen und positiven Zahlen die Fakultät berechnen!");
            }

            int result = new MathCalc().factorial(Convert.ToInt32(helper));

            SetResultInParent($"{helper}! = {result}");

        }

        private void Wurzel_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben Sie die Zahl ein von der Sie eine Wurzel berechnen wollen!");
            double Radikant = helper;
            if (helper < 0)
            {
                ShowMessage("Wurzeln von negativen Zalen sind leider nicht möglich.");
            }
            ShowMessage("Geben Sie an die wievielte Wurzel sie von der Zahl berechnen wollen!");
            int Exponent = Convert.ToInt32(helper);
            double result = new MathCalc().root(Exponent, Radikant);
            SetResultInParent($"{helper}! = {result}");
        }

        private void Primzahlen_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben sie die obere Grenze an, in der sie Primzahlen suchen wollen!");
            int obereGrenze = Convert.ToInt32(helper);
            ShowMessage("Geben sie die untere Grenze an, in der sie Primzahlen suchen wollen!");
            int untereGrenze = Convert.ToInt32(helper);
            var result = new MathCalc().Primenumber(untereGrenze, obereGrenze);

            SetResultInParent($"Alle Primzahlen zwischen {untereGrenze} und {obereGrenze} sind: {result}");
        }

        private void Potenz_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben Sie die Zahl ein, von der Sie eine Potenz haben wollen!");
            double num = helper;
            ShowMessage("Geben Sie die Zahl ein, mit der Sie potenzieren wollen");
            double pow = helper;

            double result = new MathCalc().Power(num, pow);

            SetResultInParent($"{num} potenziert mit {pow} = {result}");
        }

        private void Dezimalbruchkonvertierung_Click(object sender, EventArgs e)
        {
            ShowMessage("Geben Sie eine Zahl ein welche Sie als Bruch dargstellt haben wollen!");
            var y = helper;
            var x = new MathCalc().DoubleToFraction(y);

            if (x.Item1 > 0)
            {
                SetResultInParent($"{y} als ein gemeiner Bruch ist : {x.Item1} {x.Item2} / {x.Item3} ");
            }
            else
            {

                SetResultInParent($"{y} als ein gemeiner Bruch ist : {x.Item2} / {x.Item3} ");
            }
           
        }
    }
}
