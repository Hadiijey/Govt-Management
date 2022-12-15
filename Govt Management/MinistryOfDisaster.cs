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
    public partial class MinistryOfDisaster : Form
    {
        public MinistryOfDisaster()
        {
            InitializeComponent();
        }

        private void govtLogin_Click(object sender, EventArgs e)
        {
            OfficialsLogin login = new OfficialsLogin();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisasterAdminLogin login = new DisasterAdminLogin();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
