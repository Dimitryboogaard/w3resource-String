using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer;
        int intTeller;
        

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;

            foreach(char chrKarakter in strInvoer)
            {
                intTeller++;
            }

            tbUitvoer.Text = intTeller.ToString();
        }
    }
}
