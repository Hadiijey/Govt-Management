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
    public partial class LawAndOrder : Form
    {
        public LawAndOrder()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmergencyContact_Click(object sender, EventArgs e)
        {
            Emergency emergency = new Emergency();
            emergency.Show();
        }

        private void PoliceClearance_Click(object sender, EventArgs e)
        {
            PoliceClearance clearance = new PoliceClearance();
            clearance.Show();
        }
    }
}
