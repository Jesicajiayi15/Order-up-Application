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
    public partial class customerpage : Form
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
                sda.Fill(dtbl);

                dataGridView1.DataSource = dtbl;
                
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
                SqlConnection connecti1 = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti1.Open();

                //open datagrid of fooditems
                SqlDataAdapter sdap = new SqlDataAdapter("SELECT * FROM customerorders", connecti1);
                DataTable dtbl1 = new DataTable();
                sdap.Fill(dtbl1);

                dataGridView2.DataSource = dtbl1;
                connecti1.Close();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message, "Error");
            }

        }

        void updateDatabasecustorder()
        {
            try
            {
                //untuk after save, delete, or update, ini bakal hasil updateannya
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti.Open();

                //open datagrid of fooditems
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM orders", connecti);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                connecti.Close();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message, "Error");
            }
        }
        void sum()
        {
            //total harga hbis add

            int sum = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridView2.Rows[i].Cells["Total_Price"].Value);
            }

            totprice.Text = sum.ToString();
        }

        public customerpage()
        {
            InitializeComponent();

            updateDatabaseorder();

        }

        private void customerpage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            updateDatabasefood();
            updateDatabaseorder();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            string query = "SELECT * FROM Categories; SELECT * FROM notable";
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

                //stelah sudah read dari table Categories, akan lanjut ke table notable menggunakan NextResult()
                if (rdr.NextResult())
                {
                    while (rdr.Read())
                    {
                        notab.Items.Add(rdr["no_table"]);

                    }
                }

                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            //waktu
            timer1.Start();

            

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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (comment.Text == "")
            {
                comment.Text = "Comment here for the specification of your order";
                comment.ForeColor = Color.DarkGray;
            }
            else
            {
                comment.ForeColor = Color.Black;
            }
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (comment.Text == "Comment here for the specification of your order")
            {
                comment.Text = null;
                comment.ForeColor = Color.Black;
            }
        }
        //DATAGRID1 - FOOD ITEMS
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            name.Text = row.Cells["Name"].Value.ToString();
            catg.Text = row.Cells["Category"].Value.ToString();
            price.Text = row.Cells["Price"].Value.ToString();
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            catg.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            //dataGridView2.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";

        }



        //DATAGRID2 - CUST_ORDER
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            name.Text = row.Cells["Name"].Value.ToString();
            qty.Text = row.Cells["Qty"].Value.ToString();
            totalpricebfradd.Text = row.Cells["Total_Price"].Value.ToString();
            comment.Text = row.Cells["Cust_comment"].Value.ToString();
            price.Text = row.Cells["Price"].Value.ToString();
            notab.Text = row.Cells["no_table"].Value.ToString();



        }
        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            i = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            name.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            totalpricebfradd.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            notab.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            price.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            qty.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            comment.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_EnabledChanged(object sender, EventArgs e)
        {
            totprice.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            price.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            name.Enabled = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            searchData(searchbar.Text);
        }

        private void catg_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchDatacombo(catg.Text);
        }

        private void qty_ValueChanged(object sender, EventArgs e)
        {

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetm = DateTime.Now;

            time.Text = datetm.ToString();

        }

        private void dellbutt_Click(object sender, EventArgs e)
        {

            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            if (name.Text == "")
            {
                MessageBox.Show("Select the order that want to be cancel");
            }
            else
            {
                if (MessageBox.Show("Do you want to cancel this order?", "Order Successfully deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connecti.Open();
                    string myquery = "DELETE FROM customerorders WHERE ID_Cust='" + i + "';";
                    SqlCommand cmd = new SqlCommand(myquery, connecti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order is Successfully deleted");
                    name.Clear();
                    qty.Clear();
                    comment.Clear();
                    totalpricebfradd.Clear();
                    price.Clear();
                    connecti.Close();
                    updateDatabaseorder();
                }
                else
                {
                    MessageBox.Show("Order is not canceled");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            customerEdit custe = new customerEdit(this);
            this.Hide();
            custe.Show();

            custe.nameedit.Text = this.dataGridView2.CurrentRow.Cells[2].Value.ToString();
            custe.qtyedit.Text = this.dataGridView2.CurrentRow.Cells[3].Value.ToString();
            custe.totalpricebfraddedit.Text = this.dataGridView2.CurrentRow.Cells[5].Value.ToString();
            custe.priceedit.Text = this.dataGridView2.CurrentRow.Cells[4].Value.ToString();
            custe.commentedit.Text = this.dataGridView2.CurrentRow.Cells[6].Value.ToString();
            custe.notabedit.Text = this.dataGridView2.CurrentRow.Cells[1].Value.ToString();

            

            updateDatabaseorder();

        }

        private void qty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void qty_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (price.Text == "")
                {
                    totalpricebfradd.Text = "";
                }
                else
                {
                    totalpricebfradd.Text = (Int32.Parse(price.Text) * Int32.Parse(qty.Text)).ToString();
                }
            }
            catch
            {
                
            }
        }
        

        private void addbutt_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text == "" || catg.Text == "" || price.Text == "" || notab.Text == "" || qty.Text == "")
                {
                    MessageBox.Show("Please fill in the blank or check your no table");
                }
                else
                {

                    SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                    //insert new data (order)
                    connecti.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO customerorders values('" + notab.Text + "','" + name.Text + "','" + price.Text + "','" + qty.Text + "', '"+ totalpricebfradd.Text + "','" + comment.Text +"')", connecti);
                    cmd.ExecuteNonQuery();
                    name.Clear();
                    catg.Items.Clear();
                    price.Clear();
                    totalpricebfradd.Clear();
                    connecti.Close();
                    updateDatabaseorder();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error");
            }
        }

        private void notab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void refrshbutt_Click(object sender, EventArgs e)
        {
            updateDatabaseorder();
            this.dataGridView2.Refresh();
        }

        private void updbut_Click(object sender, EventArgs e)
        {
            try
            {

                if (notab.Text == "" || qty.Text == "")
                {
                    MessageBox.Show("Please check again");
                }
                else
                {
                    SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                    connecti.Open();
                    SqlCommand sdaa = new SqlCommand("UPDATE customerorders SET no_table = '" + notab.Text + "', Name = '" + name.Text + "', Qty = '" + qty.Text + "', Price = '" + price.Text + "', Total_Price = '" + totalpricebfradd.Text + "', Cust_comment = '" + comment.Text + "' WHERE ID_Cust = '" + i + "'", connecti);
                    sdaa.ExecuteNonQuery();
                    MessageBox.Show("Order is Successfully updated");
                    connecti.Close();
                    name.Clear();
                    price.Clear();
                    comment.Clear();
                    qty.Clear();
                    totalpricebfradd.Clear();
                    updateDatabaseorder();


                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
        }
        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void totprice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void totalpricebfradd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            //update amount untuk dibayaar
            int sum = 0;
            try
            {
                for(int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    sum += Convert.ToInt32(dataGridView2.Rows[i].Cells[5].Value);
                }

                totprice.Text = Convert.ToString(sum);
              
            }
            catch
            {

            }
        }
        //cancel ALL = DELETE ALL
        private void cancelbutt_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Do you want to cancel ALL the order?", "Order Successfully cleared", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                connecti.Open();
                string myquery = "DELETE FROM customerorders;";
                SqlCommand cmd = new SqlCommand(myquery, connecti);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ALL Order is Successfully canceled");
                name.Clear();
                qty.Clear();
                comment.Clear();          
                totalpricebfradd.Clear();
                price.Clear();
                totprice.Clear();
                connecti.Close();
                updateDatabaseorder();
            }

        }

        private void orderbutt_Click(object sender, EventArgs e)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            SqlConnection sqlcon = new SqlConnection(config);

            try
            {
                //for(int i = 0; i > dataGridView2.Rows.Count; i++)
                //{
                //   SqlCommand sda = new SqlCommand(@"INSERT INTO orderups VALUES ('" + dataGridView2.Rows[i].Cells[1].Value + "', '" + dataGridView2.Rows[i].Cells[2].Value + "', '" + dataGridView2.Rows[i].Cells[3].Value + "', '" + dataGridView2.Rows[i].Cells[4].Value + "', '" + dataGridView2.Rows[i].Cells[5].Value + "', '" + dataGridView2.Rows[i].Cells[6].Value + "', '" + dataGridView2.Rows[i].Cells[7].Value + "')", connecti);
                //   connecti.Open();
                //   sda.ExecuteNonQuery();
                //   connecti.Close();

                //}
                foreach (DataGridViewRow dt in dataGridView2.Rows)
                {
                    string myquery1 = "INSERT INTO [dbo].[orderups] VALUES(@no_table, @Name, @Price, @Qty, @Total_price,@Cust_comment,@Time_order)";
                    SqlCommand sda = new SqlCommand(myquery1, connecti);
                    sda.Parameters.AddWithValue("@no_table", dt.Cells["no_table"].Value ?? DBNull.Value);
                    sda.Parameters.AddWithValue("@Name", dt.Cells["Name"].Value ?? DBNull.Value);
                    sda.Parameters.AddWithValue("@Price", dt.Cells["Price"].Value ?? DBNull.Value);
                    sda.Parameters.AddWithValue("@Qty", dt.Cells["Qty"].Value ?? DBNull.Value);
                    sda.Parameters.AddWithValue("@Total_price", dt.Cells["Total_price"].Value ?? DBNull.Value);
                    sda.Parameters.AddWithValue("@Cust_comment", dt.Cells["Cust_comment"].Value ?? DBNull.Value);
                    sda.Parameters.AddWithValue("@Time_order", time.Text);

                    connecti.Open();
                    sda.ExecuteNonQuery();
                    connecti.Close();

                }

                connecti.Open();
                string myquery = "DELETE FROM customerorders;";
                SqlCommand cmd1 = new SqlCommand(myquery, connecti);
                cmd1.ExecuteNonQuery();
                connecti.Close();
                MessageBox.Show("Thank you for your order");
                updateDatabaseorder();
            }   
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }

            
        }

        private void totpricetext_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    
}
