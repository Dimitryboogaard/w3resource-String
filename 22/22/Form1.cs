using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strString1 = "COMPUTER", strString2 = "computer";
        bool booString1Upper = false, booString2Upper = false;

        private void btnGevoelig_Click(object sender, EventArgs e)
        {
            char chrKarakter = Convert.ToChar(strString1.Substring(2, 1));
            char chrKarakter2 = Convert.ToChar(strString1.Substring(3, 1));

            if(char.IsUpper(chrKarakter) && char.IsUpper(chrKarakter2))
            {
                booString1Upper = true;
            }

            char chrKarakter3 = Convert.ToChar(strString2.Substring(2, 1));
            char chrKarakter4 = Convert.ToChar(strString2.Substring(3, 1));

            if(char.IsUpper(chrKarakter3) && char.IsUpper(chrKarakter4))
            {
                booString2Upper = true;
            }

            if(booString1Upper && !booString2Upper)
            {
                lblAntwoord2.Text = strString1.Substring(2, 2) + " is groter dan " + strString2.Substring(2, 2);
            }

            if(booString1Upper && booString2Upper)
            {
                lblAntwoord2.Text = strString1.Substring(2, 2) + " is gelijk aan " + strString2.Substring(2, 2);
            }

            if(!booString1Upper && booString2Upper)
            {
                lblAntwoord2.Text = strString1.Substring(2, 2) + " is kleiner dan " + strString2.Substring(2, 2);
            }
        }

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            
           
            
            if(strString1.Substring(2, 2).ToUpper() == strString2.Substring(2, 2).ToUpper())
            {
                lblAntwoord.Text = strString1.Substring(2, 2) + " is gelijk aan " + strString2.Substring(2, 2);
            }

            
        }
    }
}
