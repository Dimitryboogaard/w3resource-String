using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strSub, strWoord;
        int intTeller, intStringLengte, intSubLengte, intLetterTeller, intWoordTeller;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            strSub = tbSub.Text;
            intStringLengte = strInvoer.Length;
            intSubLengte = strSub.Length;

            for(intTeller = 0; intTeller < intStringLengte; intTeller++)
            {
                if(strInvoer.Substring(intTeller, 1) != " ")
                {
                    intLetterTeller++;
                    strWoord += strInvoer.Substring(intTeller, 1);
                }

                else if(strInvoer.Substring(intTeller, 1) == " ")
                {
                    if(intLetterTeller > 0)
                    {
                        intWoordTeller++;
                        intLetterTeller = 0;

                        if(strSub == strWoord)
                        {
                            lblAntwoord.Text += intWoordTeller.ToString() + "e positie, ";
                        }
                    }

                    intLetterTeller = 0;
                    strWoord = "";
                    
                }

                if(intTeller == intStringLengte - 1 && intLetterTeller > 0)
                {
                    intWoordTeller++;

                    if(strSub == strWoord)
                    {
                        lblAntwoord.Text += intWoordTeller.ToString() + "e positie, ";
                    }
                }
            }
        }
    }
}
