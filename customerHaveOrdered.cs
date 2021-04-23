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
    public partial class customerHaveOrdered : Form
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

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM fooditems", connecti);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);

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
            string query = "SELECT * FROM orderups WHERE no_table LIKE '%" + search + "%'";
            SqlDataAdapter sdad = new SqlDataAdapter(query, connecti);
            DataTable dt = new DataTable();
            sdad.Fill(dt);
            dataGridView1.DataSource = dt;
            connecti.Close();
        }
        void updateOrder()
        {
            try
            {
                //untuk after save, delete, or update, ini bakal hasil updateannya
                SqlConnection connecti1 = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");

                connecti1.Open();

                //open datagrid of fooditems
                SqlDataAdapter sdap = new SqlDataAdapter("SELECT * FROM orderups", connecti1);
                DataTable dtbl1 = new DataTable();
                sdap.Fill(dtbl1);

                dataGridView1.DataSource = dtbl1;
                connecti1.Close();

            }
            catch (Exception y)
            {
                MessageBox.Show(y.Message, "Error");
            }

        }


        public customerHaveOrdered()
        {
            InitializeComponent();
        }

        private void customerHaveOrdered_Load(object sender, EventArgs e)
        {
            updateOrder();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            string query = "SELECT * FROM notable";
            //memanggil 2 table dari Categories dan notable dimana dibutuhkan kolum category dan kolum no_table
            try
            {
                connecti.Open();

                SqlCommand cmd = new SqlCommand(query, connecti);
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    notab.Items.Add(rdr["no_table"]);

                }
               
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            timer1.Start();

            SqlDataAdapter sdaa = new SqlDataAdapter("SELECT * FROM orderups", connecti);
            DataTable dta = new DataTable();
            sdaa.Fill(dta);
            dataGridView1.DataSource = dta;

           

        }
       

        
        private void notab_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchDatacombo(notab.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            adminpage admp = new adminpage();
            this.Close();
            admp.Show();
        }

        private void servedtoclear_Click(object sender, EventArgs e)
        {


            List<reciepts> reciept = new List<reciepts>();
            //BLOM SLSAI
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    reciept.Add(new reciepts
                    {
                        Name = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        Price = dataGridView1.Rows[i].Cells[4].Value.ToString(),
                        Qty = dataGridView1.Rows[i].Cells[5].Value.ToString(),
                        Total_price = dataGridView1.Rows[i].Cells[6].Value.ToString(),
                        Time_order = dataGridView1.Rows[i].Cells[8].Value.ToString()

                    });
                }
            }
            Reciept res = new Reciept();
            res.Values = reciept;
            res.Show();
            
            
        }
       
        private void filtered_Click(object sender, EventArgs e)
        {
            
           
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            SqlConnection connecti = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
            DateTime fromdate = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime todate = Convert.ToDateTime(dateTimePicker2.Text); 

            if(fromdate <= todate)
            {
                TimeSpan timespan = todate.Subtract(fromdate);
                SqlCommand sda = new SqlCommand("SELECT * FROM [dbo].[orderups] WHERE Time_order between '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "'", connecti);
                connecti.Open();
                DataTable dta = new DataTable();
                dta.Load(sda.ExecuteReader());
                dataGridView1.DataSource = dta;
                connecti.Close();
                
            }
            else
            {
                MessageBox.Show("From date must be before To Date");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetm = DateTime.Now;

            time.Text = datetm.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i= 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    sum += Convert.ToInt32(dataGridView1.Rows[i].Cells["Total_price"].Value);
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }

        
            try
            {

                totprice.Text = Convert.ToString(sum);

            }
            catch(Exception ep)
            {
                MessageBox.Show(ep.Message, "Error");
            }
        }

        private void dataGridView1_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {
            
        }
    }
}



