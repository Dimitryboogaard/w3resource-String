﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strHoofdletters = "QRS";
        string strKleineLetters = "qrs";

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            lblAntwoord.Text = (string.Compare(strHoofdletters.ToUpper(), strKleineLetters.ToUpper()) == 0
                                ? "Waar" : "Niet waar");
            lblAntwoord2.Text = (string.Compare(strHoofdletters, strKleineLetters, true) == 0
                                ? "Waar" : "Niet waar");
        }
    }
}
