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
    public partial class loginpage : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-4HS2IC6A\SQLEXPRESS;Initial Catalog=Databaseuassem2;Integrated Security=True");
        public loginpage()
        {
            InitializeComponent();
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.Open();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill your username and password");
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Username, Password FROM login1 WHERE Username = '" + textBox1.Text + "' AND Password = '" + textBox2.Text + "'", connect);
                DataTable dta = new DataTable();
                sda.Fill(dta);

                if (dta.Rows.Count > 0)
                {
                   foreach(DataRow dt in dta.Rows)
                    {
                        if(dt["Password"].ToString() == "admin" || dt["Username"].ToString() == "Jesica" )
                        {
                            this.Hide();
                            MessageBox.Show("Login Successfully");
                            adminpage admins = new adminpage();
                            admins.Show();
                        }
                        else if (dt["Password"].ToString() == "user")
                        {
                            this.Hide();
                            MessageBox.Show("Login Successfully");
                            customerpage cust = new customerpage();
                            cust.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password, please try again");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                connect.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
