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
    public partial class adminitems : Form
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
        public adminitems()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminpage adms = new adminpage();
            this.Hide();
            adms.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            name.Text = row.Cells["Name"].Value.ToString();
            catg.Text = row.Cells["Category"].Value.ToString();
            price.Text = row.Cells["Price"].Value.ToString();

        }

        private void adminitems_Load(object sender, EventArgs e)
        {
            updateDatabase();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            connecti.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Categories", connecti);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                catg.Items.Add(sdr["Category"]);
                catgsear.Items.Add(sdr["Category"]);
            }
            connecti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" || catg.Text == "" || price.Text == "")
                {
                    MessageBox.Show("Please fill in the blank");
                }
                else
                {

                    SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                    //insert new data (fooditem)
                    connecti.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO fooditems values('" + name.Text + "','" + price.Text + "','" + catg.Text + "')", connecti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food item is successfully saved");
                    name.Clear();
                    catg.Items.Clear();
                    price.Clear();
                    connecti.Close();
                    updateDatabase();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            updateDatabase();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void picture_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            if (name.Text == "")
            {
                MessageBox.Show("Select Food item to delete");
            }
            else
            {
                if (MessageBox.Show("Do you want to delete this food item?", "Food Item Successfully deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connecti.Open();
                    string myquery = "DELETE FROM fooditems WHERE Name='" + name.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, connecti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food Item Successfully deleted");
                    name.Clear();
                    catg.Items.Clear();
                    price.Clear();
                    connecti.Close();
                    updateDatabase();
                }
                else
                {
                    MessageBox.Show("Food Item not deleted");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                connecti.Open();
                SqlCommand sdaa = new SqlCommand("UPDATE fooditems SET Name = '" + name.Text + "', Price = '" + price.Text + "', Category = '" + catg.Text + "' WHERE ID_food = '" + i + "'", connecti);
                sdaa.ExecuteNonQuery();
                MessageBox.Show("Food Item Successfully updated");
                connecti.Close();

                name.Clear();
                catg.Items.Clear();
                price.Clear();
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
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            catg.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            searchData(searchbar.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchDatacombo(catgsear.Text);
        }

        private void catg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}