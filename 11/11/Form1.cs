using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strZonderSpatie;
        int intTeller, intStringLengte;
        

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) != " ")
                {
                    strZonderSpatie += strInvoer.Substring(intTeller, 1);
                }
            }

            intStringLengte = strZonderSpatie.Length;

            string[] arrayLetters = new string[intStringLengte];

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                arrayLetters[intTeller] = strZonderSpatie.Substring(intTeller, 1);
            }

            Array.Sort(arrayLetters);

            for (intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                tbUitvoer.Text += arrayLetters[intTeller] + " ";
            }
        }
    }
}
