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
        private readonly Informatikrechner Icalc = new Informatikrechner();
        public Zahlensystemkonvertierung()
        {
            InitializeComponent();
        }

        private void Ter_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte deine ternäre Zahl eingeben");
            var digits = helper.ToString().ToCharArray();
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
                var result = Icalc.MyConverter("", "", "", "", helper.ToString());
                SetResultInParent($"Deine ternäre Zahl {helper} ist konvertiert zu Bin: {result[0]}, zu Oct: {result[2]}, zu Dez: {result[3]}, zu Hex: {result[4]}");
            }
        }

        private void Bin_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte deine binäre Zahl eingeben");
            var digits = helper.ToString().ToCharArray();
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
                var result = Icalc.MyConverter(helper.ToString(), "", "", "", "");
                SetResultInParent($"Deine binäre Zahl {helper} ist konvertiert zu Ternär: {result[1]}, zu Oct: {result[2]}, zu Dez: {result[3]}, zu Hex: {result[4]}");
            }
        }

        private void oct_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte deine octale Zahl eingeben");
            var digits = helper.ToString().ToCharArray();
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
                var result = Icalc.MyConverter("", helper.ToString(), "", "", "");
                SetResultInParent($"Deine octale Zahl {helper} ist konvertiert zu Binär: {result[0]}, zu Ternär: {result[1]}, zu Dez: {result[3]}, zu Hex: {result[4]}");
            }
        }

        private void dec_Click(object sender, EventArgs e)
        {
            ShowMessage("Bitte deine dezimale Zahl eingeben");
            var digits = helper.ToString().ToCharArray();
            if (string.Empty == digits[0].ToString())
            {
                Close();
            }
            else
            {
                foreach (var item in digits)
                {
                }
                var result = Icalc.MyConverter("", "", helper.ToString(), "", "");
                SetResultInParent($"Deine dezimale Zahl {helper} ist konvertiert zu Binär: {result[0]}, zu Ternär: {result[1]}, zu Oct: {result[2]}, zu Hex: {result[4]}");
            }
        }
    }
}
