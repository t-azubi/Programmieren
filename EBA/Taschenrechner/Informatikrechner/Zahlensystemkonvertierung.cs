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
    public partial class Zahlensystemkonvertierung : BaseForm
    {
        private readonly Informatikrechner ICalc = new Informatikrechner();
        public Zahlensystemkonvertierung()
        {
            InitializeComponent();
        }

        private void Ter_Click(object sender, EventArgs e)
        {
            foreach (var button in eingabeForm.Controls.OfType<Button>())
            {
                var isInt = int.TryParse(button.Text, out int a);
                if (isInt && a > 2)
                {
                    button.Enabled = false;
                }
                if (button.Text == "-" || button.Text == ",")
                {
                    button.Enabled = false;
                }
            }
            ShowMessage("Bitte deine ternäre Zahl eingeben");
            var digits = returnUserImputValue.ToString().ToCharArray();
            if (string.Empty == digits[0].ToString())
            {
                Close();
            }
            else
            {
                foreach (var item in digits)
                {
                    if (Convert.ToInt16(item.ToString()) > 2)
                    {
                        ShowMessage("Deine Zahl ist nicht Ternär!");
                        Ter_Click(sender, e);
                    }
                }
                var result = ICalc.NumberSystemConverter("", "", "", "", returnUserImputValue.ToString());
                SetResultInParent($"Deine ternäre Zahl {returnUserImputValue} ist konvertiert zu Bin: {result[0]}, zu Oct: {result[2]}, zu Dez: {result[3]}, zu Hex: {result[4]}");
            }
        }

        private void Bin_Click(object sender, EventArgs e)
        {

            foreach (var button in eingabeForm.Controls.OfType<Button>())
            {
                var isInt = int.TryParse(button.Text, out int a);
                if (isInt && a > 1)
                {
                    button.Enabled = false;
                }
                if (button.Text == "-" || button.Text == ",")
                {
                    button.Enabled = false;
                }
            }
            ShowMessage("Bitte deine binäre Zahl eingeben");
            var digits = returnUserImputValue.ToString().ToCharArray();
            if (string.Empty == digits[0].ToString())
            {
                Close();
            }
            else
            {
                foreach (var item in digits)
                {
                    if (Convert.ToInt16(item.ToString()) > 1)
                    {
                        ShowMessage("Deine Zahl ist nicht Binär!");
                        Bin_Click(sender, e);
                    }
                }
                var result = ICalc.NumberSystemConverter(returnUserImputValue.ToString(), "", "", "", "");
                SetResultInParent($"Deine binäre Zahl {returnUserImputValue} ist konvertiert zu Ternär: {result[1]}, zu Oct: {result[2]}, zu Dez: {result[3]}, zu Hex: {result[4]}");
            }
        }

        private void oct_Click(object sender, EventArgs e)
        {

            foreach (var button in eingabeForm.Controls.OfType<Button>())
            {
                var isInt = int.TryParse(button.Text, out int a);
                if (isInt && a > 7)
                {
                    button.Enabled = false;
                }
                if (button.Text == "-" || button.Text == ",")
                {
                    button.Enabled = false;
                }
            }
            ShowMessage("Bitte deine octale Zahl eingeben");
            var digits = returnUserImputValue.ToString().ToCharArray();
            if (string.Empty == digits[0].ToString())
            {
                Close();
            }
            else
            {
                foreach (var item in digits)
                {
                    if (Convert.ToInt16(item.ToString()) > 7)
                    {
                        ShowMessage("Deine Zahl ist nicht Octal!");
                        oct_Click(sender, e);
                    }
                }
                var result = ICalc.NumberSystemConverter("", returnUserImputValue.ToString(), "", "", "");
                SetResultInParent($"Deine octale Zahl {returnUserImputValue} ist konvertiert zu Binär: {result[0]}, zu Ternär: {result[1]}, zu Dez: {result[3]}, zu Hex: {result[4]}");
            }
        }

        private void dec_Click(object sender, EventArgs e)
        {

            foreach (var button in eingabeForm.Controls.OfType<Button>())
            {
                if (button.Text == "-" || button.Text == ",")
                {
                    button.Enabled = false;
                }
            }
            ShowMessage("Bitte deine dezimale Zahl eingeben");
            if (!returnUserImputValue.ToString().Contains(','))
            {
                SetResultInParent("Bitte nur ganze Zahlen eingeben!");
            }
            else
            {
                var digits = returnUserImputValue.ToString().ToCharArray();
                if (string.Empty == digits[0].ToString())
                {
                    Close();
                }
                else
                {
                    foreach (var item in digits)
                    {
                    }
                    var result = ICalc.NumberSystemConverter("", "", returnUserImputValue.ToString(), "", "");
                    SetResultInParent($"Deine dezimale Zahl {returnUserImputValue} ist konvertiert zu Binär: {result[0]}, zu Ternär: {result[1]}, zu Oct: {result[2]}, zu Hex: {result[4]}");
                }
            }
        }
    }
}
