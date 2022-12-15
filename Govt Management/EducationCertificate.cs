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
    public partial class EducationCertificate : Form
    {
        public EducationCertificate()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxRegNo.Text!=""&&textBoxRollNo.Text!=""&&textBoxBoard.Text!=""&&(radioButtonJSC.Checked||radioButtonHSC.Checked||radioButtonSSC.Checked))
            {

            }
            else
            {
                MessageBox.Show(" Enter Details to Preview your marksheet!!");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
