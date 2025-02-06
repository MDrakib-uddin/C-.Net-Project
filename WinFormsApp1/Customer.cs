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
    public partial class Customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
        public Customer()
        {
            InitializeComponent();
        }

        private void food_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into customer values (@Customerid,@Customername,@Phone,@Email,@Address)", con);
            cmd.Parameters.AddWithValue("@Customerid", int.Parse(customer_id.Text));
            cmd.Parameters.AddWithValue("@Customername", customer_name.Text);
            cmd.Parameters.AddWithValue("@Phone", customer_phone.Text);
            cmd.Parameters.AddWithValue("@Email", customer_email.Text);
            cmd.Parameters.AddWithValue("@Address", customer_address.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customer_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            customergrid.DataSource = dt;
        }

        private void customer_new_Click(object sender, EventArgs e)
        {
            customer_id.Text = "";
            customer_name.Text = "";
            customer_phone.Text = "";
            customer_email.Text = "";
            customer_address.Text = "";
        }

        private void customer_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update customer set Customername = @Customername,Phone = @Phone,Email = @Email,Address = @Address where Customerid = @Customerid", con);
            cmd.Parameters.AddWithValue("@Customerid", int.Parse(customer_id.Text));
            cmd.Parameters.AddWithValue("@Customername", customer_name.Text);
            cmd.Parameters.AddWithValue("@Phone", customer_phone.Text);
            cmd.Parameters.AddWithValue("@Email", customer_email.Text);
            cmd.Parameters.AddWithValue("@Address", customer_address.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customer_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete customer where Customerid = @Customerid", con);
            cmd.Parameters.AddWithValue("@Customer_id", int.Parse(customer_id.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void customer_display_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            customergrid.DataSource = dt;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            customergrid.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }

        private void customer_id_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Customername,Phone,Email,Address from customer where  Customerid = @Customerid", con);
            cmd.Parameters.AddWithValue("@Customerid", customer_id.Text);
            SqlDataReader dp = cmd.ExecuteReader();
            while (dp.Read())
            {
                customer_name.Text = dp.IsDBNull(0) ? "" : dp.GetValue(0).ToString();
                customer_phone.Text = dp.IsDBNull(1) ? "" : dp.GetValue(1).ToString();
                customer_email.Text = dp.IsDBNull(2) ? "" : dp.GetValue(2).ToString();
                customer_address.Text = dp.IsDBNull(3) ? "" : dp.GetValue(3).ToString();
            }
            con.Close();
        }
    }
}
