﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(

               "Phone : " + tbPhone.Text +
               "\n Name : " + tbName.Text

               );
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
