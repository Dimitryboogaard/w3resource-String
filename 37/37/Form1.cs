using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] strZin = { "hello ", "welcome ", "to ", "C# Sharp ",
                        "create ", "Windows ", "client ", "applications "};


        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = string.Concat(strZin);

            Array.Sort(strZin);

            lblAntwoord2.Text = string.Concat(strZin);
        }
    }
}
