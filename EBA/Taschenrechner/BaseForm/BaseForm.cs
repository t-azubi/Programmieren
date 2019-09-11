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
    public partial class BaseForm : Form
    {

        public double helper = 0; // handel input
        private EingabeForm EingabeForm = new EingabeForm();
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent;
        public BaseForm()
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
            else // if '=' is in string than retun it back to log it is a function
            {
                SetResultInParent(result);
            }
        }
        public void ShowMessage(string Message)
        {
            MessageBox.Show(Message, "Zahleneingabe");
            EingabeForm.ShowDialog();
        }
    }
}
