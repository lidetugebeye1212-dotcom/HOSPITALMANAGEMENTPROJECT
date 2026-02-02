using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace HOSPITALMANAGEMENTPROJECT
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True");
        void populatecombo()
        {
            string sql = "Select * from PatientTable";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("Patid", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);

                PatID.ValueMember = "PatId";
                PatID.DisplayMember = "PatId";
                PatID.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }
        string patinetname;
        void fetchpatinetname()
        {
            con.Open();
            string mysql = "select * from PatientTable  where Patid=" + PatID.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patinetname = dr["PatName"].ToString();
                PatName.Text = patinetname;
            }


            con.Close();
        }
        void populate()
        {
            con.Open();
            string query = "select * from DiagnosisTb";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            con.Close();
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
                if (DiagID.Text == "" ||
                    Medicine.Text == "" ||
                    Diagnosis.Text == "" ||
                    PatID.Text == "")
                {
                    MessageBox.Show("Please Fill All The Details");
                    return;
                }
                con.Open();


                string query =
"insert into DiagnosisTb (PatID, PatName, Diagnosis, Medicine, Symptom) " +
"values ('" +
PatID.SelectedValue.ToString() + "', '" +
PatName.Text + "', '" +
Diagnosis.Text + "', '" +
Medicine.Text + "', '" +
Symptom.Text + "')";



                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Patient Added Successfully!");


                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                if (con.State == ConnectionState.Open)
                    con.Close();


            }
        }

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void PatID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchpatinetname();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (DiagID.Text == "")
            {
                MessageBox.Show("Please Enter The Diagnosis ID");

            }
            else
            {
                con.Open();
                string query = "delete from DiagnosisTb where DiagID=" + DiagID.Text;

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Deleted Successfully!");
                con.Close();
                populate();
            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagID.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatID.Text = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatName.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Medicine.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptom.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptomlbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Medicinelbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE DiagnosisTb SET PatID='" +
PatID.SelectedValue.ToString() + "', PatName='" + PatName.Text + "', Diagnosis='" + Diagnosis.Text + "'  , Medicine='" + Medicine.Text + "' , Symptom='" + Symptom.Text + "'   WHERE Patid=" + DiagID.Text;

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Updated Successfully!");
            con.Close();
            populate();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawString(
                "Diagnosis Summary",
                new Font("Lucida Handwriting", 28, FontStyle.Bold),
                new SolidBrush(Color.DarkSlateBlue),
                new PointF(120, 80)
            );

            
            string patientInfo =
                "Patient Name: " + PatientNamelbl.Text + "\n\n" +
                "Symptoms: " + Symptomlbl.Text + "\n\n" +
                "Diagnosis: " + Diagnosislbl.Text + "\n\n" +
                "Medicine: " + Medicinelbl.Text;

            e.Graphics.DrawString(
                patientInfo,
                new Font("Lucida Handwriting", 24, FontStyle.Regular),
                new SolidBrush(Color.Teal),
                new PointF(100, 150)
            );

            
            e.Graphics.DrawString(
                label11.Text,
                new Font("Lucida Handwriting", 20, FontStyle.Italic),
                new SolidBrush(Color.Red),
                new PointF(100, 480)
            );

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}




