using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Draft_4
{
    public partial class Other_Employee_Assets : Form
    {
        private string connString = ConfigurationManager.ConnectionStrings["Draft_4.Properties.Settings.GLEN1"].ConnectionString;// Arthur:CodingByAdnanQurban (https://youtu.be/hgARKgpg2uE?si=NyQv7fxtcEHVFc4a) (accessed 19th of December) idea of storing the database credetials for better security 
        private int _empId;

        public Other_Employee_Assets(int empId)
        {
            InitializeComponent();
            _empId = empId;
        }

        private void Other_Employee_Assets_Load(object sender, EventArgs e)
        {
         
            LoadEmployeeAssets();
            LoadSoftwareAssets();
        }

        private void LoadEmployeeAssets()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM GLEN.Assets WHERE EmpID = @EmpID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmpID", _empId);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable assetsTable = new DataTable();
                        adapter.Fill(assetsTable);
                        dataGridView1.DataSource = assetsTable; 
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void LoadSoftwareAssets()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM GLEN.SoftAssets";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable softwareTable = new DataTable();
                        adapter.Fill(softwareTable);
                        dataGridView1.DataSource = softwareTable; 
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)//exit buttons
        {
            Application.Exit();
        }
    }
}
