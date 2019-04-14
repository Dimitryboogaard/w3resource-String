using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intAantalStrings, intTeller, intTeller2;
        string[] arrayStrings = new string[100];

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            if (lblAantal.Text == "Aantal")
            {
                
                intAantalStrings = Convert.ToInt32(tbAantal.Text);
                lblAantal.Text = Convert.ToString(intAantalStrings);
                tbAantal.Text = "";

                
            }
            else
            {
                
                arrayStrings[intTeller] = tbAantal.Text;
                tbAantal.Text = "";
                intTeller++;
                lblAantal.Text = Convert.ToString(intAantalStrings - intTeller);

                if(Convert.ToInt16(lblAantal.Text) < 1)
                {
                    Array.Sort(arrayStrings);

                    for(intTeller2 = arrayStrings.Length - intAantalStrings; intTeller2 < arrayStrings.Length; intTeller2++)
                    {
                        rtUitvoer.Text += arrayStrings[intTeller2] + Environment.NewLine;
                    }
                }
            }

           
                

            
        }
    }
}
