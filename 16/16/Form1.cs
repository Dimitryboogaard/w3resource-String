using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strUser, strPass;

        private void btnCheck_Click(object sender, EventArgs e)
        {
            strUser = tbUser.Text;
            strPass = tbPass.Text;

            if(strUser == "uesr" && strPass == "pass" || strUser == "abcd" && strPass == "1234")
            {
                lblCheck.Text = "Correct.";
            }

            else
            {
                lblCheck.Text = "Incorrect.";
            }
        }
    }
}
