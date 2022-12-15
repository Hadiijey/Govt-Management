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
    public partial class WaterNewConUPass : Form
    {
        public WaterNewConUPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxWaterPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxWaterPass.Text == textBoxWaterCPass.Text)
            {
                labelWaterPassRight.Visible = true;
                labelWaterPassWrong.Visible = false;
            }
            else
            {
                labelWaterPassRight.Visible = false;
                labelWaterPassWrong.Visible = true;
            }
        }

        private void textBoxWaterCPass_TextChanged(object sender, EventArgs e)
        {
            if (textBoxWaterPass.Text == textBoxWaterCPass.Text)
            {
                labelWaterPassRight.Visible = true;
                labelWaterPassWrong.Visible = false;
            }
            else
            {
                labelWaterPassRight.Visible = false;
                labelWaterPassWrong.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxWaterUName.Text != null &&
               textBoxWaterPass.Text != null &&
               textBoxWaterCPass.Text != null)
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
