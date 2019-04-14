using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intLeesTekens, intCijfers, intLetters, intASCII;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            foreach(char chrKarakter in strInvoer)
            {
                intASCII = Convert.ToInt32(chrKarakter);

                if(intASCII >= 32 && intASCII <= 47 || intASCII >= 58 && intASCII <= 64 ||
                   intASCII >= 91 && intASCII <= 96 || intASCII >= 123 && intASCII <= 126)
                {
                    intLeesTekens++;
                }

                if(intASCII >= 48 && intASCII <= 57)
                {
                    intCijfers++;
                }

                if(intASCII >= 65 && intASCII <= 90 || intASCII >= 97 && intASCII <= 122)
                {
                    intLetters++;
                }
            }

            lblLeesTekens.Text = "Aantal leestekens: " + intLeesTekens.ToString();
            lblCijfers.Text = "Aantal cijfers: " + intCijfers.ToString();
            lblLetters.Text = "Aantal letters: " + intLetters.ToString();
        }
    }
}
