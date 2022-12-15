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
    public partial class Gas : Form
    {
        public Gas()
        {
            InitializeComponent();
        }

        private void buttonGasNewCon_Click(object sender, EventArgs e)
        {
            GasNewCon gsn = new GasNewCon();
            gsn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGasBill_Click(object sender, EventArgs e)
        {
            GasBill gb = new GasBill();
            gb.Show();
        }

        private void buttonGasComplain_Click(object sender, EventArgs e)
        {
            GasComplain gc = new GasComplain();
            gc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GasAdminLogin gal = new GasAdminLogin();
            gal.Show();
        }
    }
}
