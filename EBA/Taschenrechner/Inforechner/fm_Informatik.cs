using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustForYou_Informatik
{
    public partial class fm_Informatik : Form
    {
        public fm_Informatik()
        {
            InitializeComponent();
        }

        private void btn_Zahlensystem_Click(object sender, EventArgs e)
        {
            fm_Zahlensystem x = new fm_Zahlensystem();
            x.ShowDialog();
        }


        //für das Bild
        private void btn_Bild_Click(object sender, EventArgs e)
        {
            var höhe = 100; //durch Wert aus Eingabemodul ersetzen
            var breite = 300; //durch Wert aus Eingabemodul ersetzen
            var tiefe = 64; //durch Wert aus Eingabemodul ersetzen
            var bild = höhe * breite * tiefe;
            var rückgabe= "Ein Bild mit der Größe " + höhe + " x " + breite + " und einer Farbtiefe von " + tiefe + " hat eine Größe von " + bild + "bit";
            //MessageBox.Show(rückgabe);
        }

        private void btn_Video_Click(object sender, EventArgs e)
        {
            var höhe = 100; //durch Wert aus Eingabemodul ersetzen
            var breite = 300; //durch Wert aus Eingabemodul ersetzen
            var tiefe = 64; //durch Wert aus Eingabemodul ersetzen
            var länge = 200; //durch Wert aus Eingabemodul ersetzen
            var video = höhe * breite * tiefe * länge;
            var rückgabe = "Ein Bild mit der Größe " + höhe + " x " + breite + " und einer Farbtiefe von " + tiefe + " sowie einer Länge von "+länge+" hat eine Größe von " + video + " bit ";
            //MessageBox.Show(rückgabe);
        }

        private void btn_BitByte_Click(object sender, EventArgs e)
        {
            fm_BitByte x = new fm_BitByte();
            x.ShowDialog();
        }
    }
}
