using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class GrundrechnerForm : Form
    {
        public string Equation;
        public string oldEquation;
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent = delegate { };
        public List<string> RechenSchritte = new List<string>();
        public GrundrechnerForm()
        {
            InitializeComponent();
            new Button().Click += Add_Click;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Equation += ((Button)(sender)).Text;
            Input.Text = Equation;
        }
        private void Solve_Click(object sender, EventArgs e)
        {
           var match = Regex.Match(Regex.Replace(Input.Text, @"\s", ""), @"/0");
           if (match.Success)
           {
               if (Regex.Replace(Equation, @"\s", "").Substring(match.Index + match.Length).IndexOf(',') != 0)
               {
                   MessageBox.Show("You can't divide by Zero!!");
               }
               else
               {
                   Equation = new ErrorHandling().CorrectEquation(Equation, new ErrorHandling().CountBrackets(Equation, true), new ErrorHandling().CountBrackets(Equation, false));
                   var result = new Grundrechner().Solve(Equation, out RechenSchritte);
                   oldEquation = Equation;
                   Equation = result.ToString();
                   Output.Text = result.ToString();
               }
           }
           else
           {
               Equation = new ErrorHandling().CorrectEquation(Equation, new ErrorHandling().CountBrackets(Equation, true), new ErrorHandling().CountBrackets(Equation, false));
               var result = new Grundrechner().Solve(Equation, out RechenSchritte);
               oldEquation = Equation;
               Equation = result.ToString();
               Output.Text = result.ToString();
           }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            RechenschritteOutput.Clear();
            RechenSchritte.Clear();
            Input.Text = String.Empty;
            Equation = String.Empty;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Equation == null || Equation == " " || Equation == String.Empty)
            {
                Input.Text = Equation;
            }
            else
            {
                if (Equation.LastIndexOf(' ') + 1 == Equation.Count())
                {
                    Equation = Equation.Remove(Equation.Count() - 3);
                }
                else
                {
                    Equation = Equation.Remove(Equation.Count() - 1);
                }
                Input.Text = Equation;
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Input.Text = new ErrorHandling().checkForErrors(Input.Text);
            Input.SelectionStart = Input.TextLength;
            Input.SelectionLength = 0;
            Equation = Input.Text;
        }
        private void Übernehmen_Click(object sender, EventArgs e)
        {
            SetResultInParent(Equation);
        }
        private void History_Click(object sender, EventArgs e)
        {
            SetResultInParent(oldEquation + " = " + Input.Text);
        }
        public void SetResultInParent(string label)
        {
            AdviseParent(label);
        }
        private void Rechenschritte_Click(object sender, EventArgs e)
        {
            var Count = RechenSchritte.Count;
            var length = RechenschritteOutput.Text.Length;
            for (int i = 0; i < Count; i++)
            {
                RechenSchritte[i] = Regex.Replace(RechenSchritte[i], "#", @"/-");
                RechenSchritte[i] = Regex.Replace(RechenSchritte[i], "x", @"*-");
                RechenschritteOutput.AppendText(RechenSchritte[i] + "\n");
                var substring = RechenSchritte[i].Substring(0, RechenSchritte[i].IndexOf(')') + 1);
                var firstindex = substring.LastIndexOf('(');
                if (firstindex != -1)
                {
                    var lastindex = substring.Substring(substring.LastIndexOf('(')).Length;
                    RechenschritteOutput.Select(firstindex + length, lastindex);
                    length += RechenSchritte[i].Length + 1;
                    var show = RechenschritteOutput.SelectedText;
                    RechenschritteOutput.SelectionColor = Color.Red;
                }
            }
        }
    }
}
