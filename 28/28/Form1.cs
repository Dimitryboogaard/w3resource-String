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

namespace _28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strsister = "sister";
        string strSister = "Sister";
        int intWaarde;
        string strResultaat;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intWaarde = string.Compare(strsister, strSister, false, new CultureInfo("en-US"));

            if(intWaarde < 0)
            {
                strResultaat = "<";
            }

            else if(intWaarde == 0)
            {
                strResultaat = "=";
            }

            else
            {
                strResultaat = ">";
            }

            lblAntwoord.Text = strsister + strResultaat + strSister;

            intWaarde = string.Compare(strsister, strSister, true, new CultureInfo("en-US"));

            if (intWaarde < 0)
            {
                strResultaat = "<";
            }

            else if (intWaarde == 0)
            {
                strResultaat = "=";
            }

            else
            {
                strResultaat = ">";
            }

            lblAntwoord2.Text = strsister + strResultaat + strSister;


            intWaarde = string.CompareOrdinal(strsister, strSister);

            if (intWaarde < 0)
            {
                strResultaat = "<";
            }

            else if (intWaarde == 0)
            {
                strResultaat = "=";
            }

            else
            {
                strResultaat = ">";
            }

            lblAntwoord3.Text = strsister + strResultaat + strSister;

        }
    }
}
