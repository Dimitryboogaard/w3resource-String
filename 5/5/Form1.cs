using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int intTeller, intStringLengte, intLetterTeller, intWoordTeller;
        string strInvoer;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            for (intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) != " ")
                {
                    intLetterTeller++;
                }

                else if(strInvoer.Substring(intTeller, 1) == " ")
                {
                    if(intLetterTeller > 1)
                    {
                        intWoordTeller++;
                    }

                    intLetterTeller = 0;
                }

                else if(intTeller == intStringLengte - 1 && intLetterTeller > 1)
                {
                    intWoordTeller++;
                }
            }

                lblUitvoer.Text = "Aantal woorden is: " + intWoordTeller.ToString();
            }
        }
    }
