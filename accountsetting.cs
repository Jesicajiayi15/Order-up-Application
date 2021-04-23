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

    public partial class accountsetting : Form
    {
        int i;
        string config = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public accountsetting()
        {
            InitializeComponent();
        }
        
     
        void updateDatabase()
        {
            try
            {
                //untuk after save, delete, or update, ini bakal hasil updateannya
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti.Open();

                //open datagrid of login1
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM login1", connecti);
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
            string query = "SELECT * FROM login1 WHERE Username LIKE '%" +search+ "%'";
            SqlDataAdapter sdad = new SqlDataAdapter(query, connecti);
            DataTable dt = new DataTable();
            sdad.Fill(dt);
            dataGridView1.DataSource = dt;
            connecti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (name.Text == "" || pass.Text == "" || phone.Text == "" )
                {
                    MessageBox.Show("Please fill in the blank");
                }
                else
                {
                    SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                    //insert new data (user)
                    connecti.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO login1 values('" + name.Text + "','" + pass.Text + "','" + phone.Text + "')", connecti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User successfully saved");
                    name.Clear();
                    pass.Clear();
                    phone.Clear();
                    connecti.Close();
                    updateDatabase();
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error");
            }
        }

        private void accountsetting_Load(object sender, EventArgs e)
        {
            updateDatabase();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            if (name.Text == "")
            {
                MessageBox.Show("Select Username to delete");
            }
            else
            {
                if(MessageBox.Show("Do you want to delete this user?", "User Successfully deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connecti.Open();
                    string myquery = "DELETE FROM login1 WHERE password='" + pass.Text + "';";
                    SqlCommand cmd = new SqlCommand(myquery, connecti);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully deleted");
                    name.Clear();
                    pass.Clear();
                    phone.Clear();
                    connecti.Close();
                    updateDatabase();
                }
                else
                {
                    MessageBox.Show("User not deleted");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show data in textboxs
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            name.Text = row.Cells["Username"].Value.ToString();
            pass.Text = row.Cells["Password"].Value.ToString();
            phone.Text = row.Cells["Phnum"].Value.ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            searchData(searchbar.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
                connecti.Open();
                SqlCommand sdaa = new SqlCommand("UPDATE login1 SET Username = '" + name.Text + "', Password = '" + pass.Text + "', Phnum = '" + phone.Text + "' WHERE UserID = '" + i + "'", connecti);
                sdaa.ExecuteNonQuery();
                MessageBox.Show("User Successfully updated");
                connecti.Close();

                name.Clear();
                pass.Clear();
                phone.Clear();
                updateDatabase();


            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "Error");
            }
          
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //show data in textboxs
            
            //name.Text = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
            //pass.Text = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString();
            //phone.Text = dataGridView1.SelectedRows[0].Cells["Phnum"].Value.ToString();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //i = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            //name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //pass.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            //phone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pass.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            phone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminpage admp = new adminpage();
            this.Hide();
            admp.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
