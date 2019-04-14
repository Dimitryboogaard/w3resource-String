using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str123 = "123";
        string strsometext = "some text";
        string strSomeText = "Some Text";
        string strResultaat;
        int intResultaat;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            
            intResultaat = string.Compare(strsometext, str123);
            strResultaat = (intResultaat < 0) ? strResultaat = " is kleiner dan " : (intResultaat > 0) ?
                           strResultaat = " is groter dan " : strResultaat = " is gelijk aan ";
            lblSomeText123.Text = strsometext + strResultaat + str123;

            intResultaat = string.Compare(strsometext, strsometext);
            strResultaat = (intResultaat < 0) ? strResultaat = " is kleiner dan " : (intResultaat > 0) ?
                           strResultaat = " is groter dan " : strResultaat = " is gelijk aan ";
            lblSomeTextSomeText.Text = strsometext + strResultaat + strsometext;

            intResultaat = string.Compare(strsometext, strSomeText);
            strResultaat = (intResultaat < 0) ? strResultaat = " is kleiner dan " : (intResultaat > 0) ?
                           strResultaat = " is groter dan " : strResultaat = " is gelijk aan ";
            lblSomeTextSomeText2.Text = strsometext + strResultaat + strSomeText;
        }
    }
}
