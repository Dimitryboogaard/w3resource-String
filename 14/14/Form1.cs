using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intSubStringLengte;
        string strInvoer, strSubString;
        bool booTrue = false;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            strSubString = tbSub.Text;
            intStringLengte = strInvoer.Length;
            intSubStringLengte = strSubString.Length;

            for(intTeller = 0; intTeller < intStringLengte - intSubStringLengte; intTeller++)
            {
                if(strSubString == strInvoer.Substring(intTeller, intSubStringLengte))
                {
                    booTrue = true;
                }
            }

            if(booTrue)
            {
                lblAntwoord.Text = "De substring bestaat.";
            }

            else if(!booTrue)
            {
                lblAntwoord.Text = "De substring bestaat niet.";
            }
        }
    }
}
