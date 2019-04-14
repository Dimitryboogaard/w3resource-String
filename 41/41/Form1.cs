using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] strStrings = { "Actions speak louder than words", "Hello!", "Python.",
                           "PHP.", "random" };
        bool booEindigtMetEenPunt;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            foreach(var String in strStrings)
            {
                booEindigtMetEenPunt = String.EndsWith(".");
                rtUitvoer.Text += String + " eindigt met een punt? " + booEindigtMetEenPunt + Environment.NewLine;
            }
        }
    }
}
