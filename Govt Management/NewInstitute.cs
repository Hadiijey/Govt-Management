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
    public partial class NewInstitute : Form
    {
        bool RadioBool = false;
        public NewInstitute()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(RadioBool)
            {
                if((radioButtonMulOwner.Checked || radioButtonSinOwner.Checked)&&textBoxArea.Text!=""&&textBoxRoadNo.Text!=""
                    && textBoxBoard.Text!=""&& textBoxCity.Text!="")
                {
                    MessageBox.Show(" Submitted!");
                }
                else
                {
                    MessageBox.Show(" Please Check The Form");
                }
            }
            else if(!RadioBool)
            {
                if ((radioButtonMulOwner.Checked || radioButtonSinOwner.Checked) && textBoxArea.Text != "" && textBoxRoadNo.Text != ""
                    && textBoxBoard.Text != "" && textBoxCity.Text != "" && textBoxOwnerName.Text!="" && textBoxOwnerNID.Text!="")
                {
                    MessageBox.Show(" Submitted!");
                }
                else
                {
                    MessageBox.Show(" Please Check The Form");
                }
            }
           
        }

        private void NewInstitute_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonSinOwner_CheckedChanged(object sender, EventArgs e)
        {
            labelOwnerName.Visible = true;
            labelOwnerNID.Visible = true;
            textBoxOwnerName.Visible = true;
            textBoxOwnerNID.Visible = true;
            RadioBool = false;

        }

        private void radioButtonMulOwner_CheckedChanged(object sender, EventArgs e)
        {
            labelOwnerName.Visible = false;
            labelOwnerNID.Visible = false;
            textBoxOwnerName.Visible = false;
            textBoxOwnerNID.Visible = false;
            RadioBool = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
