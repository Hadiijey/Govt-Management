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
    public partial class GasNewCon : Form
    {
        public GasNewCon()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void GasNewCon_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxGasName.Text !=null &&
                comboBoxGasDate.Text != null &&
                comboBoxGasDate.SelectedItem!= null &&
                comboBoxGasMonth.Text != null &&
                comboBoxGasMonth.SelectedItem!= null &&
                comboBoxGasYear.Text != null &&
                comboBoxGasYear.SelectedItem!= null &&
                textBoxGasNID.Text !=null &&
                textBoxGasFatherName.Text  != null &&
                (radioButtonGasMale.Checked ||radioButtonGasFemale.Checked||radioButtonGasOther.Checked)&&
                textBoxGasContact.Text !=null &&
                textBoxGasHouse.Text != null &&
                textBoxGasRoad.Text != null &&
                textBoxGasArea.Text != null &&
                textBoxGasCity.Text != null)
            {
                GasNewConUPass gsup = new GasNewConUPass();
                gsup.Show();
            }
            else
            {
                MessageBox.Show(" Please Insert Information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxGasNID_TextChanged(object sender, EventArgs e)
        {
            string nid = textBoxGasNID.Text;
            if(nid.Length==10)
            {
                labelNIDRight.Visible = true;
                labelNIDWrong.Visible = false;
            }
            else
            {
                labelNIDRight.Visible = false;
                labelNIDWrong.Visible = true;
            }
        }

        private void textBoxGasContact_TextChanged(object sender, EventArgs e)
        {
            string phone = textBoxGasContact.Text;
            if (phone.StartsWith("01") && (phone.Length == 11))
            {
                labelContactRight.Visible = true;
                labelContactWrong.Visible = false;
            }
            else
            {
                labelContactRight.Visible = false;
                labelContactWrong.Visible = true;
            }
        }
    }
}
