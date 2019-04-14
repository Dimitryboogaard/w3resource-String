using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer;
     

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
      

            foreach(char chrKarakter in strInvoer)
            {
                if(char.IsUpper(chrKarakter))
                {
                    tbUitvoer.Text += Convert.ToString(chrKarakter).ToLower();
                }

                if(char.IsLower(chrKarakter))
                {
                    tbUitvoer.Text += Convert.ToString(chrKarakter).ToUpper();
                }
            }
        }
    }
}
