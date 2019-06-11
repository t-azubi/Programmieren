using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class EingabeForm : Form
    {
        public string Equation;
        private GrundrechnerForm GrundrechnerForm = new GrundrechnerForm();
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent = delegate { };
        public EingabeForm()
        {
            InitializeComponent();
            GrundrechnerForm.AdviseParent += new GrundrechnerForm.AdviseParentEventHandler(SetFromForm2);
            new Button().Click += Add_Click;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Equation += ((Button)(sender)).Text;
            VariableValue.Text = Equation;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (Equation.Count() > 0)
            {
                Equation = Equation.Remove(Equation.Count() -1 );
                VariableValue.Text = Equation;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            VariableValue.Text = String.Empty; 
            Equation = String.Empty;
        }

        private void Nebenrechnungen_Click(object sender, EventArgs e)
        {
            GrundrechnerForm.Font = this.Font;
            GrundrechnerForm.ForeColor = this.ForeColor;
            GrundrechnerForm.BackColor = this.BackColor;
            GrundrechnerForm.ShowDialog();
        }
        public void SetFromForm2(string result)
        {
            if (Regex.IsMatch(result, "="))
            {
                SetResultInParent(result);
            }else
            { 
            VariableValue.Text = result;
            Equation = result;
            }
        }
        private void Uebernehmen_Click(object sender, EventArgs e)
        {
            Equation = VariableValue.Text;
            SetResultInParent(Equation);
            VariableValue.Text = string.Empty;
            Equation = string.Empty;
            this.Close();
        }
        public void SetResultInParent(string label)
        {
                AdviseParent(label);
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.VariableValue.Text, @"[^\d-,]"))
            {
                MessageBox.Show("Please Enter Only Numbers");
                VariableValue.Text = VariableValue.Text.Remove(VariableValue.Text.Length - 1);
                Equation = VariableValue.Text;
            }
            var match = Regex.Match(Regex.Replace(VariableValue.Text, @"\s", ""), @"[^\d]{2}");
            if (match.Success)
            {
                VariableValue.Text = VariableValue.Text.Remove(match.Index, match.Length - 1);
                Equation = VariableValue.Text;
            }
            Equation = VariableValue.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            Equation += ((Button)(sender)).Text;
            VariableValue.Text = Equation;
        }
    }
}
