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
    public partial class Utility_Service : Form
    {
        public Utility_Service()
        {
            InitializeComponent();
        }

        private void Utility_Service_Load(object sender, EventArgs e)
        {

        }

        private void buttongGas_Click(object sender, EventArgs e)
        {
            Gas gas = new Gas();
            gas.Show();
        }

        private void buttonWater_Click(object sender, EventArgs e)
        {
            Water w=new Water();
            w.Show();
        }

        private void buttonElectricity_Click(object sender, EventArgs e)
        {
            Electricity ec=new Electricity();
            ec.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
