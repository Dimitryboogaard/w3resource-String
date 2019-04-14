using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strKleineLetters = "xyz";
        string strHoofdLetters = "XYZ";

        int intStatus;

        string strStatus;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            intStatus = String.CompareOrdinal(strKleineLetters, 1, strHoofdLetters, 1, 1);

            if(intStatus < 0)
            {
                strStatus = " is kleiner dan ";
            }

            if(intStatus == 0)
            {
                strStatus = " is gelijk aan ";
            }

            if(intStatus > 0)
            {
                strStatus = " is groter dan ";
            }

            lblCompareOrdinal.Text = strKleineLetters.Substring(1, 1) + strStatus + strHoofdLetters.Substring(1, 1);

            intStatus = String.Compare(strKleineLetters, 1, strHoofdLetters, 1, 1);

            switch (intStatus)
            {
                case -1:
                    strStatus = " is kleiner dan ";
                    break;

                case 0:
                    strStatus = " is gelijk aan ";
                    break;

                case 1:
                    strStatus = " is groter dan ";
                    break;
            }

            lblCompare.Text = strKleineLetters.Substring(1, 1) + strStatus + strHoofdLetters.Substring(1, 1);
        }
    }
}
