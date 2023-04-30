using System;
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


            if (tbName.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || tbAddress.Text == "")
            {
                MessageBox.Show("Invalid field");
            }
            else {
                MessageBox.Show(
                  "Phone : " + tbPhone.Text +
                  "\n Name : " + tbName.Text +
                  "\n Email : " + tbEmail.Text +
                   "\n Address : " + tbAddress.Text
                   );
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            countryListbox.SelectedItems.Clear();
            //for (int i = 0;i<= countryListbox.Items.Count; i++)
            //{
            //    if (countryListbox.Items[i].ToString().ToLower().Contains(searchtb.Text.ToLower()))
            //    {
            //       countryListbox.SelectedIndex = i;
            //    }

            //}

            int index = countryListbox.FindString(searchtb.Text);
            // Determine if a valid index is returned. Select the item if it is valid.
            if (index != -1)
            {
                countryListbox.SetSelected(index, true);
                statusLb.Text = countryListbox.SelectedItems.Count.ToString() + " items found";
            }
            else
            {
                statusLb.Text = "not found";
            }

        }
    }
}
