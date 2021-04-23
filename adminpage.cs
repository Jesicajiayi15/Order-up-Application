using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASSEM1
{
    public partial class adminpage : Form
    {
        public adminpage()
        {
            InitializeComponent();
            DateTime dates = DateTime.Now;
            label2.Text = "Today's date : " + dates;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admincatg aditems = new admincatg();
            this.Close();
            aditems.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            accountsetting acset = new accountsetting();
            this.Hide();
            acset.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categories catg = new categories();
            this.Hide();
            catg.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tables_Management tabma = new Tables_Management();
            this.Hide();
            tabma.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerHaveOrdered cho = new customerHaveOrdered();
            this.Hide();
            cho.Show();
        }
    }
}
