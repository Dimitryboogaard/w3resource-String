using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace _27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strDollar = "Dollar";
        string strChange = "Change";
        int intWaarde;
        string strSymbool;
    

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intWaarde = (string.Compare(strChange, strDollar, true, new CultureInfo("en-US")));

            if(intWaarde < 0)
            {
                strSymbool = "<";
            }

            else if(intWaarde == 0)
            {
                strSymbool = "=";

            }

            else
            {
                strSymbool = ">";
            }

            lblEnUs.Text = strChange + strSymbool + strDollar;

            intWaarde = (string.Compare(strChange, strDollar, true, new CultureInfo("cs-CZ")));

            if (intWaarde < 0)
            {
                strSymbool = "<";
            }

            else if (intWaarde == 0)
            {
                strSymbool = "=";

            }

            else
            {
                strSymbool = ">";
            }

            lblcsCZ.Text = strChange + strSymbool + strDollar;
        }
    }
}
