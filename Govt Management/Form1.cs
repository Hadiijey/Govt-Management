namespace Govt_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Utility_Service us=new Utility_Service();
            us.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login log=new Login();
            log.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Health health = new Health();
            health.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Education education = new Education();
            education.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LawAndOrder law = new LawAndOrder();
            law.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DisasterManagement disaster = new DisasterManagement();
            disaster.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Travel travel = new Travel();
            travel.Show();
        }
    }
}