using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strSub;
        int intTeller, intStringLengte, intSubStringLengte, intSubTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            strSub = tbSub.Text;
            intStringLengte = strInvoer.Length;
            intSubStringLengte = strSub.Length;

            for(intTeller = 0; intTeller < intStringLengte - intSubStringLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, intSubStringLengte) == strSub)
                {
                    intSubTeller++;
                }
            }

            lblAntwoord.Text = strSub + " komt " + intSubTeller.ToString() + " keer voor.";
        }
    }
}
