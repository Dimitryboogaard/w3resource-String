using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strTeken;
        int intTekenTeller, intTeller, intStringLengte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            strTeken = tbTeken.Text;

            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strTeken == strInvoer.Substring(intTeller, 1))
                {
                    intTekenTeller++;
                }
            }

            lblAntwoord.Text = strTeken + " komt " + intTekenTeller.ToString() + " keer voor.";
        }
    }
}
