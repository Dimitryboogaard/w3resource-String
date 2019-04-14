using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strString1 = "Don't count your chickens, ";
        string strString2 = "before the eggs, ";
        string strString3 = "have hatched.";

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = strString1 + strString2 + strString3;
        }
    }
}
