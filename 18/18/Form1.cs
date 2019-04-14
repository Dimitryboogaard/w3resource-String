using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strKarakter;
        int intASCIIKarakter;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strKarakter = tbKarakter.Text;

            foreach(char chrKarakter in strKarakter)
            {
                intASCIIKarakter = Convert.ToInt32(chrKarakter);

                if(intASCIIKarakter >= 65 && intASCIIKarakter <= 90)
                {
                    lblAntwoord.Text = chrKarakter + " is een hoofdletter.";
                }

                else if(intASCIIKarakter >= 97 && intASCIIKarakter <= 122)
                {
                    lblAntwoord.Text = chrKarakter + " is een kleine letter.";
                }

                else
                {
                    lblAntwoord.Text = chrKarakter + " is geen letter.";
                }
            }
        }
    }
}
