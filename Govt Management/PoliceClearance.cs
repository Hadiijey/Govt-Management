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
    public partial class PoliceClearance : Form
    {
        public PoliceClearance()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = namebox.Text;
            string mobile = mobilebox.Text; 
            string nid=nidbox.Text;
            string pass = passbox.Text;
            string confirmpass = conpass.Text;
            if (name.Length!=0 && mobile.Length!=0 && nid.Length!=0 && pass.Length!=0 && confirmpass.Length!=0)
            {
                PoliceClearanceDetails clearanceDetails = new PoliceClearanceDetails();
                clearanceDetails.Show();
            }
            else
            {
                MessageBox.Show("Must input name, mobile no, NID & pass");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
