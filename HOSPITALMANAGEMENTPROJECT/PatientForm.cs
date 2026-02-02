using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace HOSPITALMANAGEMENTPROJECT
{
    public partial class PatientForm : Form
    {
        
        public PatientForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True");
        void populate()
        {
            con.Open();
            string query = "select * from PatientTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
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
                if (Patid.Text == "" || PatName.Text == "" ||PatPhone.Text == "" || PatAge.Text == ""|| PatGender.Text == "" || PatAge.Text == "" || PatAddress.Text == "" || Patblo.Text == ""||Patdie.Text=="" )

                {
                    MessageBox.Show("Please Fill All The Details");
                    return;
                }
                con.Open();

                // Added single quotes '' around the text values to prevent SQL errors
                string query = "insert into PatientTable values('" + Patid.Text + "', '" + PatName.Text + "', '" + PatPhone.Text + "','" + PatPhone.Text + "', '" + PatAge.Text + "' ,'" + PatGender.SelectedItem.ToString() + "','" + Patblo.SelectedItem.ToString() + "','" + Patdie.Text + "' )";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Added Successfully!");
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

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Patid.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAddress.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            Patdie.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Patid.Text == "")
            {
                MessageBox.Show("Please Enter The Patient ID");

            }
            else
            {
                con.Open();
                string query = "delete from PatientTable where Patid='" + Patid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient  Deleted Successfully!");
                con.Close();
                populate();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE PatientTable SET PatName='" + PatName.Text + "', PatAddress='" + PatAddress.Text + "', PatPhone='" + PatPhone.Text + "'  , PatAge='" + PatAge.Text + "' , PatGender='" + PatGender.SelectedItem.ToString() + "' , Patblo='" + Patblo.SelectedItem.ToString() + "' , Patdie='" + Patdie.Text + "'  WHERE Patid=" + Patid.Text;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Updated Successfully!");
            con.Close();
            populate();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}

