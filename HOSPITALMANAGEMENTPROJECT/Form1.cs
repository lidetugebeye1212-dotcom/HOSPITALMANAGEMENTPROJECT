using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HOSPITALMANAGEMENTPROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            DocName.Text = "";
            DocPass.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || DocPass.Text == "")
            {
                MessageBox.Show("Please enter your Doctor name and Password");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DocTable where DocName='" + DocName.Text + "' and DocPass='" + DocPass.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    HOME H = new HOME();
                    H.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Doctor Name or Password");
                }
                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
