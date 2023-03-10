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
    public partial class DisasterManagement : Form
    {
        public DisasterManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MinistryOfDisaster ministry = new MinistryOfDisaster();
            ministry.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentOfDisasterManagement department = new DepartmentOfDisasterManagement();
            department.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            WeatherForecast weather = new WeatherForecast();
            weather.Show();
        }
    }
}
