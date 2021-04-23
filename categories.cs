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
using System.Configuration;

namespace UASSEM1
{
    public partial class categories : Form
    {
        int i;
        string config = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        void updateDatabase()
        {
            try
            {
                //untuk after save, delete, or update, ini bakal hasil updateannya
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti.Open();

                //open datagrid of fooditems
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Categories", connecti);
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
        void searchDatacombo(string search)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

            connecti.Open();
            string query = "SELECT * FROM Categories WHERE Name LIKE '%" + search + "%'";
            SqlDataAdapter sdad = new SqlDataAdapter(query, connecti);
            DataTable dt = new DataTable();
            sdad.Fill(dt);
            dataGridView1.DataSource = dt;
            connecti.Close();
        }
        public categories()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminpage admp = new adminpage();
            this.Hide();
            admp.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void categories_Load(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            catgry.Text = row.Cells["Category"].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (catgry.Text == "")
                {
                    MessageBox.Show("Please fill in the blank");
                }
                else
                {

                    SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                    //insert new data (user)
                    connecti.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Categories values('" + catgry.Text +  "')", connecti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food item is successfully saved");
                    catgry.Clear();
                    connecti.Close();
                    updateDatabase();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            if (catgry.Text == "")
            {
                MessageBox.Show("Select Category to delete");
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this category?", "Category Successfully deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connecti.Open();
                    string myquery = "DELETE FROM Category WHERE Name='" + catgry.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, connecti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully deleted");
                    catgry.Clear();
                    connecti.Close();
                    updateDatabase();
                }
                else
                {
                    MessageBox.Show("Category not deleted");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                connecti.Open();
                SqlCommand sdaa = new SqlCommand("UPDATE Categories SET Category = '" + catgry.Text + "' WHERE Id_cat = '" + i + "'", connecti);
                sdaa.ExecuteNonQuery();
                MessageBox.Show("Category Successfully updated");
                connecti.Close();
                catgry.Clear();
                updateDatabase();


            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            catgry.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }
    }
}
