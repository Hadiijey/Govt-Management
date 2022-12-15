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
    public partial class Water : Form
    {
        public Water()
        {
            InitializeComponent();
        }

        private void buttonGasNewCon_Click(object sender, EventArgs e)
        {
            WaterNewCon wnc=new WaterNewCon();
            wnc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGasBill_Click(object sender, EventArgs e)
        {
            WaterBill wb = new WaterBill();
            wb.Show();
        }

        private void buttonGasComplain_Click(object sender, EventArgs e)
        {
            WaterComplain wc = new WaterComplain();
            wc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WaterAdminLogin wal = new WaterAdminLogin();
            wal.Show();
        }
    }
}
