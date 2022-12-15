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
    public partial class BoardAndInstitute : Form
    {
        public BoardAndInstitute()
        {
            InitializeComponent();
        }

        private void BoardAndInstitute_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBoxBoardList.Text!="" &&
                comboBoxBoardList.SelectedItem!=null) 
            {
                labelBiName.Visible = true;
                labelBiArea.Visible = true;
                labelBiDepartment.Visible = true;
                labelBiStudentSeat.Visible = true;
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show(" Select a board to see institutes");
            }
            
        }
    }
}
