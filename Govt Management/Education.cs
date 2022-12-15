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
    public partial class Education : Form
    {
        public Education()
        {
            InitializeComponent();
        }

        private void buttonApplication_Click(object sender, EventArgs e)
        {
            buttonCeritificate.Visible = true;
            buttonCorrection.Visible = true;
            buttonNewInstitute.Visible = true;
            
            buttonApplication.Visible = false;
            buttonBoardandInstitute.Visible = false;
            buttonGoBack.Visible = true;
            buttonExit.Visible = false;

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonBoardandInstitute_Click(object sender, EventArgs e)
        {
            BoardAndInstitute bi= new BoardAndInstitute();
            bi.Show();
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            buttonApplication.Visible = true;
            buttonBoardandInstitute.Visible = true;
            buttonCeritificate.Visible = false;
            buttonCorrection.Visible = false;
            buttonNewInstitute.Visible = false;
            
            buttonExit.Visible = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCeritificate_Click(object sender, EventArgs e)
        {
            EducationCertificate EduC = new EducationCertificate();
            EduC.Show();
        }

        private void buttonCorrection_Click(object sender, EventArgs e)
        {
            EducationCorrection eduCo= new EducationCorrection();
            eduCo.Show();
        }

        private void buttonNewInstitute_Click(object sender, EventArgs e)
        {
            NewInstitute ni=new NewInstitute();
            ni.Show();
        }
    }
}
