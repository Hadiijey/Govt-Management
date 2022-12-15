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
    public partial class GasNewConUPass : Form
    {
        public GasNewConUPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGasPass.Text == textBoxGasCPass.Text)
            {
                labelPassRight.Visible = true;
                labelPassWrong.Visible = false;
            }
            else
            {
                labelPassRight.Visible = false;
                labelPassWrong.Visible = true;
            }
        }

        private void textBoxGasCPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxGasPass.Text == textBoxGasCPass.Text)
            {
                labelPassRight.Visible = true;
                labelPassWrong.Visible = false;
            }
            else
            {
                labelPassRight.Visible = false;
                labelPassWrong.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxGasUname.Text != null &&
               textBoxGasPass.Text != null &&
               textBoxGasCPass.Text != null)
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
