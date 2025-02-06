using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
        public dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
        }
        public void display()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from food", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                food_count.Text = Convert.ToString(count.ToString());

            }
            else
            {
                food_count.Text = "0";
            }
            con.Close();
        }
        public void display1()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from customer", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                customer_count.Text = Convert.ToString(count.ToString());

            }
            else
            {
                customer_count.Text = "0";
            }
            con.Close();
        }
        public void display2()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(*) from orders", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                orders_count.Text = Convert.ToString(count.ToString());

            }
            else
            {
                orders_count.Text = "0";
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }
    }
}
