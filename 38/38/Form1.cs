using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intIndex;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            string strZin = "Kill two birds with one stone";
            string strSubString = "birds";
            bool booJaOfNee = strZin.Contains(strSubString);

            if(booJaOfNee)
            {
                intIndex = strZin.IndexOf(strSubString);

                if(intIndex >= 0)
                {
                    lblAntwoord.Text = strSubString + " begint op positie " + intIndex++;
                }
            }
        }
    }
}
