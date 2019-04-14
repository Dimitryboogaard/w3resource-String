using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strSub, strText;
        int intTeller, intStringLengte, intSubStringLengte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            strSub = tbSub.Text;
            strText = tbText.Text;
            intStringLengte = strInvoer.Length;
            intSubStringLengte = strSub.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(intTeller < intStringLengte - intSubStringLengte && strInvoer.Substring(intTeller, intSubStringLengte) == strSub)
                {
                    lblAntwoord.Text += " " + strText + " ";
                }

                lblAntwoord.Text += strInvoer.Substring(intTeller, 1);
            }
        }
    }
}
