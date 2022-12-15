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
    public partial class Electricity : Form
    {
        public Electricity()
        {
            InitializeComponent();
        }

        private void buttonGasNewCon_Click(object sender, EventArgs e)
        {
            ElectricityNewCon enc = new ElectricityNewCon();
            enc.Show();
        }

        private void buttonGasBill_Click(object sender, EventArgs e)
        {
            ElectricityBill eb = new ElectricityBill();
            eb.Show();
        }

        private void buttonGasComplain_Click(object sender, EventArgs e)
        {
            ElectrictyComplain ec = new ElectrictyComplain();
            ec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ElectricityAdminLogin eal=new ElectricityAdminLogin();
            eal.Show();
        }
    }
}
