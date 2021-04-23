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
    public partial class customerEdit : Form
    {
        int i;
        string config = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        void updateDatabasefood()
        {
            try
            {
                //untuk after save, delete, or update, ini bakal hasil updateannya
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti.Open();

                //open datagrid of fooditems
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM fooditems", connecti);
                DataTable dtbl = new DataTable();

                dataGridView1.DataSource = dtbl;
                sda.Fill(dtbl);
                connecti.Close();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message, "Error");
            }
        }
        void updateDatabaseorder()
        {
            try
            {
                //untuk after save, delete, or update, ini bakal hasil updateannya
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti.Open();

                //open datagrid of custorder
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM customerorders", connecti);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                

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

        customerpage cm;
        public customerEdit(customerpage cmp)
        {
            InitializeComponent();
            this.cm = cmp;
        }

        private void customerEdit_Load(object sender, EventArgs e)
        {
            timer1.Start();
            updateDatabasefood();
            updateDatabaseorder();
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            string query = "SELECT * FROM Categories;SELECT * FROM notable";
            //memanggil 2 table dari Categories dan notable dimana dibutuhkan kolum category dan kolum no_table
            try
            {
                connecti.Open();

                SqlCommand cmd = new SqlCommand(query, connecti);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    catg.Items.Add(rdr["Category"]);

                }

                if (rdr.NextResult())
                {
                    while (rdr.Read())
                    {
                        notabedit.Items.Add(rdr["no_table"]);

                    }
                }


                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void qtyedit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void qtyedit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (priceedit.Text == "")
                {
                    totalpricebfraddedit.Text = "";
                }
                else
                {
                    totalpricebfraddedit.Text = (Int32.Parse(priceedit.Text) * Int32.Parse(qtyedit.Text)).ToString();
                }
            }
            catch
            {

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void commentedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentedit_Leave(object sender, EventArgs e)
        {

           
        }

        private void commentedit_Enter(object sender, EventArgs e)
        {
            
        }

        private void editbut_Click(object sender, EventArgs e)
        {
            
            try
            {

                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                connecti.Open();
                SqlCommand sdaa = new SqlCommand("UPDATE customerorders SET no_table = '" + notabedit.Text + "', Name = '" + nameedit.Text + "', Qty = '" + qtyedit.Text + "', Price = '" + priceedit.Text + "', Total_Price = '"+ totalpricebfraddedit.Text + "', Cust_comment = '" + commentedit.Text + "' WHERE ID_Cust = '" + i + "'", connecti);
                
                sdaa.ExecuteNonQuery();
                MessageBox.Show("Order is Successfully updated");
                connecti.Close();
                updateDatabaseorder();
                nameedit.Clear();
                totalpricebfraddedit.Clear();
                


            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }
            

            customerpage cmp = new customerpage();
            this.Close();
            cmp.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetm = DateTime.Now;
            time.Text = datetm.ToString();
            
        }

        private void catg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void canbutt_Click(object sender, EventArgs e)
        {
            
            customerpage cmp = new customerpage();
            this.Close();
            cmp.Show();
        }

        private void priceedit_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbar_TextChanged_1(object sender, EventArgs e)
        {
            searchData(searchbar.Text);
        }

        private void catg_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            searchDatacombo(catg.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            nameedit.Text = row.Cells["Name"].Value.ToString();
            catg.Text = row.Cells["Category"].Value.ToString();
            priceedit.Text = row.Cells["Price"].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            nameedit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceedit.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            catg.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
