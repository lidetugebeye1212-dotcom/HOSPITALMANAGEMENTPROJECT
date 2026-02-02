using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HOSPITALMANAGEMENTPROJECT
{
    public partial class DOCTERSFORM : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True");
        public DOCTERSFORM()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
        }
        void populate()
        {
            con.Open();
            string query = "select * from DocTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void DOCTERSFORM_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            HOME hOME = new HOME();
            hOME.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Docid.Text == "" || DocExx.Text == "" || DocName.Text == "" || DocPass.Text == "")

                {
                    MessageBox.Show("Please Fill All The Details");
                    return;
                }
                con.Open();

                // Added single quotes '' around the text values to prevent SQL errors
                string query = "insert into DocTable values('" + Docid.Text + "', '" + DocExx.Text + "', '" + DocName.Text + "', '" + DocPass.Text + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor Added Successfully!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
            populate();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (Docid.Text == "")
            {
                MessageBox.Show("Please Enter The Doctor ID");

            }
            else
            {
                con.Open();
                string query = "delete from DocTable where Docid='" + Docid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Deleted Successfully!");
                con.Close();
                populate();
            }
        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Docid.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocExx.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query =  "UPDATE DocTable SET DocName='" + DocName.Text + "', DocExp='" + DocExx.Text + "', DocPass='" + DocPass.Text + "' WHERE Docid=" + Docid.Text;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Updated Successfully!");
            con.Close();
            populate(); 
        }
    }
}