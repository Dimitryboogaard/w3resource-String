using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strPython = "python";
        string strJava = "JAVA";
        string strResultaat;
        int intResultaat;

        private void button1_Click(object sender, EventArgs e)
        {
            intResultaat = string.CompareOrdinal(strJava, strPython);
            strResultaat = (intResultaat < 0) ? strResultaat = " is kleiner dan " : (intResultaat > 0) ?
                           strResultaat = " is groter dan" : strResultaat = " is gelijk aan ";

            lblResultaat.Text = strJava + strResultaat + strPython;
        }
    }
}
