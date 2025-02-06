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
    public partial class Order : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
        public Order()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dateTimePicker1.CustomFormat = "";
            }
        }

        private void customer_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into orders values (@Orderid,@Customername,@Food1,@Food2,@Food3,@Orderdate)", con);
            cmd.Parameters.AddWithValue("@Orderid", int.Parse(order_id.Text));
            cmd.Parameters.AddWithValue("@Customername", customer_name.Text);
            cmd.Parameters.AddWithValue("@Food1", food_1.Text);
            cmd.Parameters.AddWithValue("@Food2", food_2.Text);
            cmd.Parameters.AddWithValue("@Food3", food_3.Text);
            cmd.Parameters.AddWithValue("@Orderdate", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customer_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from orders", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            ordergrid.DataSource = dt;
        }

        private void customer_new_Click(object sender, EventArgs e)
        {
            order_id.Text = "";
            customer_name.Text = "";
            food_1.Text = "";
            food_2.Text = "";
            food_3.Text = "";
        }

        private void customer_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update orders set Customername = @Customername,Food1 = @Food1,Food2 = @Food2,Food3 = @Food3,Orderdate = @Orderdate where Orderid = @Orderid", con);
            cmd.Parameters.AddWithValue("@Orderid", int.Parse(order_id.Text));
            cmd.Parameters.AddWithValue("@Customername", customer_name.Text);
            cmd.Parameters.AddWithValue("@Food1", food_1.Text);
            cmd.Parameters.AddWithValue("@Food2", food_2.Text);
            cmd.Parameters.AddWithValue("@Food3", food_3.Text);
            cmd.Parameters.AddWithValue("@Orderdate", dateTimePicker1.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customer_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete orders where Orderid = @Orderid", con);
            cmd.Parameters.AddWithValue("@Orderid", int.Parse(order_id.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customer_display_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from orders", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            ordergrid.DataSource = dt;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from orders", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            ordergrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }

        private void order_id_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Customername,Food1,Food2,Food1,Orderdate from orders where  Orderid = @Orderid", con);
            cmd.Parameters.AddWithValue("@Orderid", order_id.Text);
            SqlDataReader dp = cmd.ExecuteReader();
            while (dp.Read())
            {
                customer_name.Text = dp.IsDBNull(0) ? "" : dp.GetValue(0).ToString();
                food_1.Text = dp.IsDBNull(1) ? "" : dp.GetValue(1).ToString();
                food_2.Text = dp.IsDBNull(2) ? "" : dp.GetValue(2).ToString();
                food_3.Text = dp.IsDBNull(3) ? "" : dp.GetValue(3).ToString();
                dateTimePicker1.Text = dp.IsDBNull(4) ? "" : dp.GetValue(4).ToString();
            }
            con.Close();
        }
    }
}
