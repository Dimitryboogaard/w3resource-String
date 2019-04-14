using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strKarakter;
        int intKlinkers, intMedeKlinkers, intASCII;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;

            foreach(char chrKarakter in strInvoer)
            {
                intASCII = Convert.ToInt32(chrKarakter);
                strKarakter = Convert.ToString(chrKarakter);
                
                if(strKarakter == "a" || strKarakter == "A" || strKarakter == "o" || strKarakter == "O" ||
                   strKarakter == "u" || strKarakter == "U" || strKarakter == "i" || strKarakter == "I" ||
                   strKarakter == "e" || strKarakter == "E")
                {
                    intKlinkers++;
                }

                else if(intASCII >= 65 && intASCII <= 90 || intASCII >= 97 && intASCII <= 122)
                {
                    intMedeKlinkers++;
                }
            }

            lblKlinkers.Text = "Aantal klinkers: " + intKlinkers.ToString();
            lblMedeKlinkers.Text = "Aantal medeklinkers: " + intMedeKlinkers.ToString();
        }
    }
}
