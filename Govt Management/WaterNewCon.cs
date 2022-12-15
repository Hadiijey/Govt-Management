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
    public partial class WaterNewCon : Form
    {
        public WaterNewCon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxWaterName.Text != null &&
                comboBoxWaterDate.Text != null &&
                comboBoxWaterDate.SelectedItem != null &&
                comboBoxWaterMonth.Text != null &&
                comboBoxWaterMonth.SelectedItem != null &&
                comboBoxWaterYear.Text != null &&
                comboBoxWaterYear.SelectedItem != null &&
                textBoxWaterNID.Text != null &&
                textBoxWaterFatherName.Text != null &&
                (radioButtonWaterMale.Checked || radioButtonWaterFemale.Checked || radioButtonWaterOther.Checked) &&
                textBoxWaterContact.Text != null &&
                textBoxWaterHouse.Text != null &&
                textBoxWaterRoad.Text != null &&
                textBoxWaterArea.Text != null &&
                textBoxWaterCity.Text != null)
            {
                WaterNewConUPass wncu = new WaterNewConUPass();
                wncu.Show();
            }
            else
            {
                MessageBox.Show(" Please Insert Information ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNIDRight_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWaterNID_TextChanged(object sender, EventArgs e)
        {
            string nid = textBoxWaterNID.Text;
            if (nid.Length == 10)
            {
                labelWaterNIDRight.Visible = true;
                labelWaterNIDWrong.Visible = false;
            }
            else
            {
                labelWaterNIDRight.Visible = false;
                labelWaterNIDWrong.Visible = true;
            }
        }

        private void textBoxWaterContact_TextChanged(object sender, EventArgs e)
        {
            string phone = textBoxWaterContact.Text;
            if (phone.StartsWith("01") && (phone.Length == 11))
            {
                labelWaterContactRight.Visible = true;
                labelWaterContactWrong.Visible = false;
            }
            else
            {
                labelWaterContactRight.Visible = false;
                labelWaterContactWrong.Visible = true;
            }
        }
    }
}
