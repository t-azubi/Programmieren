using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    class Schule
    {
        public  string helper = string.Empty;
        public  List<string> output = new List<string>();
        private  EingabeForm EingabeForm = new EingabeForm();
        public  delegate void AdviseParentEventHandler(string text);
        private  void ShowMessage(string Message)
        {
            MessageBox.Show(Message, "Noteneingabe");
            EingabeForm.ShowDialog();
        }
        public  void SetFromForm2(string result)
        {
            helper = result;
        }
        public  List<string> StartModule(Font font, Color foreColor, Color backColor)
        {
            EingabeForm.Font = font;
            EingabeForm.BackColor = backColor;
            EingabeForm.ForeColor = foreColor;
            EingabeForm.AdviseParent += new EingabeForm.AdviseParentEventHandler(SetFromForm2);
            ShowMessage("Bitte geben sie alle Noten an!(mit , Trennen)");

            var Noten = helper.Split(',');

            if (helper == "")
            {
                return null;
            }
            Notenberechnung(Noten);
            Notenanzahl(Noten);
            return output;
        }
        private  void Notenberechnung(string[] noten)
        {
            double helper = 0;
            foreach (var item in noten)
            {
                helper += Convert.ToInt16(item);
            }
            var count = noten.Count().ToString();
            var helper2 = new Grundrechner().CalcConst(helper.ToString() + " / " + count);
            output.Add("Notenberechnung : " + helper.ToString() + " / " + count + " = " + helper2.ToString());
            Notenempfehlung(helper2);
        }
        private void Notenanzahl(string[] noten)
        {
            List<int> counter = new List<int> { 0, 0, 0, 0, 0, 0 };
            foreach (var item in noten)
            {
                switch (item)
                {
                    case "1":
                        counter[0]++;
                        continue;
                    case "2":
                        counter[1]++;
                        continue;
                    case "3":
                        counter[2]++;
                        continue;
                    case "4":
                        counter[3]++;
                        continue;
                    case "5":
                        counter[4]++;
                        continue;
                    case "6":
                        counter[5]++;
                        continue;
                    default:
                        break;
                }
            }
            output.Add("Noten: " + "1x " + counter[0].ToString() + " | 2x " + counter[1].ToString()  + " | 3x " +counter[2].ToString() + " | 4x " +counter[3].ToString() + " | 5x " + counter[4].ToString() + " | 6x " + counter[5].ToString());
        }
        private  void Notenempfehlung(double Note)
        {
            var zahl = new MathCalc().splitExp(Note);
            if ((zahl.Item2 < .5))
            {
                output.Add("Notenempfehlung: " + zahl.Item1.ToString());
            }
            else
            {
                zahl.Item1++;
                output.Add("Notenempfehlung: " + zahl.Item1.ToString());
            }
        }
    }
}

