using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intStart, intLengte, intTeller, intEinde;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStart = Convert.ToInt32(tbStart.Text);
            intLengte = Convert.ToInt32(tbLengte.Text);

            intEinde = intStart + intLengte;

            foreach(char chrKarakter in strInvoer)
            {
                intTeller++;

                if(intTeller >= intStart && intTeller <= intEinde)
                {
                    tbUitvoer.Text += chrKarakter;
                }
            }
        }
    }
}
