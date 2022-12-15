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
    public partial class ElectricityNewCon : Form
    {
        public ElectricityNewCon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElectricityNewUpass enu=new ElectricityNewUpass();
            enu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxENID_TextChanged(object sender, EventArgs e)
        {
            string nid = textBoxENID.Text;
            if (nid.Length == 10)
            {
                labelENIDRight.Visible = true;
                labelENIDWrong.Visible = false;
            }
            else
            {
                labelENIDRight.Visible = false;
                labelENIDWrong.Visible = true;
            }
        }

        private void textBoxEContact_TextChanged(object sender, EventArgs e)
        {
            string phone = textBoxEContact.Text;
            if (phone.StartsWith("01") && (phone.Length == 11))
            {
                labelEContactRight.Visible = true;
                labelEContactWrong.Visible = false;
            }
            else
            {
                labelEContactRight.Visible = false;
                labelEContactWrong.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxEName.Text != null &&
                comboBoxEDate.Text != null &&
                comboBoxEDate.SelectedItem != null &&
                comboBoxEMonth.Text != null &&
                comboBoxEMonth.SelectedItem != null &&
                comboBoxEYear.Text != null &&
                comboBoxEYear.SelectedItem != null &&
                textBoxENID.Text != null &&
                textBoxEFatherName.Text != null &&
                (radioButtonEMale.Checked || radioButtonEFemale.Checked || radioButtonEOther.Checked) &&
                textBoxEContact.Text != null &&
                textBoxEHouse.Text != null &&
                textBoxERoad.Text != null &&
                textBoxEArea.Text != null &&
                textBoxECity.Text != null)
            {
                ElectricityNewUpass enu = new ElectricityNewUpass();
                enu.Show();
            }
            else
            {
                MessageBox.Show(" Please Insert Information ");
            }
        }
    }
}
