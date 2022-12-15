using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Govt_Management
{
    public partial class ElectricityNewUpass : Form
    {
        public ElectricityNewUpass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEPass.Text == textBoxECPass.Text)
            {
                labelEPassRight.Visible = true;
                labelEPassWrong.Visible = false;
            }
            else
            {
                labelEPassRight.Visible = false;
                labelEPassWrong.Visible = true;
            }
        }

        private void textBoxECPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEPass.Text == textBoxECPass.Text)
            {
                labelEPassRight.Visible = true;
                labelEPassWrong.Visible = false;
            }
            else
            {
                labelEPassRight.Visible = false;
                labelEPassWrong.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxEUName.Text != null &&
               textBoxEPass.Text != null &&
               textBoxECPass.Text != null)
            {
                MessageBox.Show(" Registration Completed ");
                this.Close();
            }
            else
            {
                MessageBox.Show(" Incomplete!! ");
            }
        }
    }
}
