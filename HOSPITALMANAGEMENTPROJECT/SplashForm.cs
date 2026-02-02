using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace HOSPITALMANAGEMENTPROJECT
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, System.EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            startpoint += 1;
            guna2CircleProgressBar1.Value = startpoint;
            if (guna2CircleProgressBar1.Value == 100)
            {
                guna2CircleProgressBar1.Value = 100;
                timer1.Stop();
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            }

        private void SplashForm_Load(object sender, System.EventArgs e)
        {
           this. timer1.Start();

        }
    }
}
