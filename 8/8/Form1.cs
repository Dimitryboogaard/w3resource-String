﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strInvoer, strUitvoer;
        int intStringLengte;

        private void btnAntwoord_Click(object sender, EventArgs e)
        {
            strInvoer = tbInvoer.Text;
            intStringLengte = strInvoer.Length;

            strUitvoer = strInvoer;

            tbUitvoer.Text = strUitvoer;
            lblAntwoord.Text = "Er zijn " + intStringLengte.ToString() + " karakters gecopieerd.";
        }
    }
}
