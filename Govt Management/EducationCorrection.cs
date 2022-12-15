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
    public partial class EducationCorrection : Form
    {
        public EducationCorrection()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EducationCorrection_Load(object sender, EventArgs e)
        {

        }

        private void buttonEduCorEnter_Click(object sender, EventArgs e)
        {
            if ((radioButtonHSCEduCor.Checked || radioButtonJSCEduCor.Checked || radioButtonSSCEduCor.Checked) &&
                textBoxEduCorRegNo.Text != "" && textBoxEduCorRoll.Text != "" && textBoxEduCorBoard.Text != "")
            {
                labelEduCor.Visible = true;
                labelEduCorFName.Visible = true;
                labelEduCorName.Visible = true;
                labelEduCorDOB.Visible = true;
                textBoxEduCorName.Visible = true;
                textBoxEduCorFName.Visible = true;
                textBoxEduCorDOB.Visible=true;
                buttontextBoxEduCorSubmit.Visible = true;
            }
            else
            {
                MessageBox.Show(" Please Fill up the information");
            }
        }

        private void buttontextBoxEduCorSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxEduCorDOB.Text== "" && textBoxEduCorFName.Text=="" && textBoxEduCorName.Text=="") 
            {

                MessageBox.Show(" Please Check your information"); 
            }
            else
            {
                MessageBox.Show(" Correction Request Submitted");
            }
        }
    }
}
