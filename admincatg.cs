using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace UASSEM1
{
    public partial class admincatg : Form
    {
        void updateDatabase()
        {
            try
            {
                //untuk after save, delete, or update, ini bakal hasil updateannya
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti.Open();

                //open datagrid of login1
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM fooditems", connecti);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                connecti.Close();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message, "Error");
            }
        }
        void searchData(string search)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

            connecti.Open();
            string query = "SELECT * FROM fooditems WHERE Name LIKE '%" + search + "%'";
            SqlDataAdapter sdad = new SqlDataAdapter(query, connecti);
            DataTable dt = new DataTable();
            sdad.Fill(dt);
            dataGridView1.DataSource = dt;
            connecti.Close();
        }
        void searchDatacombo(string search)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

            connecti.Open();
            string query = "SELECT * FROM fooditems WHERE Name LIKE '%" + search + "%'";
            SqlDataAdapter sdad = new SqlDataAdapter(query, connecti);
            DataTable dt = new DataTable();
            sdad.Fill(dt);
            dataGridView1.DataSource = dt;
            connecti.Close();
        }
        public admincatg()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admincatg_Load(object sender, EventArgs e)
        {
            updateDatabase();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            updateDatabase();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            connecti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", connecti);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                catgsear.Items.Add(sdr["Category"]);
            }
            connecti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminitems adi = new adminitems();
            this.Hide();
            adi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminpage adp = new adminpage();
            this.Close();
            adp.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(textBox1.Text);
        }

        private void catgsear_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchDatacombo(catgsear.Text);
        }
    }
}
