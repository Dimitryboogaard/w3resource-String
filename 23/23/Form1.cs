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

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strString1 = "COMPUTER";
        string strString2 = "computer";
        string strResultaat;
        int intResultaat;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intResultaat = string.Compare(strString1, 4, strString2, 4, 2, true, new CultureInfo("tr-TR"));
            strResultaat = (intResultaat < 0) ? strResultaat = " is kleiner dan " : (intResultaat > 0) ?
                            strResultaat = " is groter dan " : strResultaat = " is gelijk aan ";
            lblAntwoord.Text = strString1.Substring(4, 2) + strResultaat + strString2.Substring(4, 2);
        }

        private void btnAntwoord2_Click(object sender, EventArgs e)
        {
            intResultaat = string.Compare(strString1, 4, strString2, 4, 2, true, CultureInfo.InvariantCulture);
            strResultaat = (intResultaat < 0) ? strResultaat = " is kleiner dan " : (intResultaat > 0) ?
                            strResultaat = " is groter dan " : strResultaat = " is gelijk aan ";
            lblAntwoord2.Text = strString1.Substring(4, 2) + strResultaat + strString2.Substring(4, 2);
        }
    }
}
