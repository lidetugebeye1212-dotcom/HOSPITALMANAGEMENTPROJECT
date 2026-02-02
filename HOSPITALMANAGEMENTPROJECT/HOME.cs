using System;
using System.Windows.Forms;

namespace HOSPITALMANAGEMENTPROJECT
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show(); ;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //develpped by lidetu gebeye at university debre markos
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DOCTERSFORM doctersform = new DOCTERSFORM();
            this.Hide();
            doctersform.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PatientForm pat= new PatientForm();
            this.Hide();
            pat.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DiagnosisForm diag = new DiagnosisForm();
            this.Hide();
                diag.Show();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }
    }
}
