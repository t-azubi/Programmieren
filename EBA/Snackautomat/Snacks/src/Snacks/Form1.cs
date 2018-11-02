using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snacks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var radioButtons1 = gb1.Controls.OfType<RadioButton>().ToArray();
            var sI1 = Array.IndexOf(radioButtons1, radioButtons1.Single(rb => rb.Checked));

            var radioButtons2 = gb2.Controls.OfType<RadioButton>().ToArray();
            var sI2 = Array.IndexOf(radioButtons2, radioButtons2.Single(rb => rb.Checked));

            int hunger = Hunger.hungry(sI1);
            int weight = Hunger.weight(sI2);

            tb1.Text = Whattoeat(hunger + weight);
        }
        private string Whattoeat(int mealvalue)
        {
            switch (mealvalue)
            {
                case 0:
                    return "Salad";
                case 1:
                    return "Salad with meat";
                case 2:
                    return "French fries with bread rolls";
                case 3:
                    return "Bratwurst with bread rolls";
                case 4:
                    return "Extra large Döner with cheese";
                default:
                   return "Whatever you want";
            }
            
        }

    }
}
