using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        int intIndex1, intIndex2, intLengte;
        string strNaam1 = "John Peterson", strNaam2 = "Michel Jhonson";

        private void btnSorteren_Click(object sender, EventArgs e)
        {
            intIndex1 = strNaam1.IndexOf(" ");
            intIndex1 = intIndex1 < 0 ? 0 : intIndex1--;

            intIndex2 = strNaam2.IndexOf(" ");
            intIndex2 = intIndex2 < 0 ? 0 : intIndex2--;

            intLengte = Math.Max(strNaam1.Length, strNaam2.Length);

            if(string.Compare(strNaam1, intIndex1, strNaam2, intIndex2, intLengte) < 0)
            {
                rtUitvoer.Text += strNaam1 + Environment.NewLine;
                rtUitvoer.Text += strNaam2;
            }

            else
            {
                rtUitvoer.Text += strNaam2 + Environment.NewLine;
                rtUitvoer.Text += strNaam1;
            }
        }
    }
}
