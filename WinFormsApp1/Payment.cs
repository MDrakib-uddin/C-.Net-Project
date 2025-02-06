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
    public partial class Payment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }

        private void payment_save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into payment values (@Pid,@Customername,@Food1,@Food2,@Food3,@PaymentMethod,@Amount)", con);
            cmd.Parameters.AddWithValue("@Pid", int.Parse(payment_id.Text));
            cmd.Parameters.AddWithValue("@Customername", payment_Cname.Text);
            cmd.Parameters.AddWithValue("@Food1", payment_food1.Text);
            cmd.Parameters.AddWithValue("@Food2", payment_food2.Text);
            cmd.Parameters.AddWithValue("@Food3", payment_food3.Text);
            cmd.Parameters.AddWithValue("@PaymentMethod", payment_method.Text);
            cmd.Parameters.AddWithValue("@Amount", payment_amount.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void payment_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from payment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            paymentgrid.DataSource = dt;
        }

        private void payment_new_Click(object sender, EventArgs e)
        {
            
                payment_id.Text = "";
                payment_Cname.Text = "";
                payment_food1.Text = "";
                payment_food2.Text = "";
                payment_food3.Text = "";
                payment_method.Text = "";
                payment_amount.Text = "";          
        }

        private void payment_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update payment set Customername = @Customername,Food1 = @Food1,Food2 = @Food2,Food3 = @Food3,PaymentMethod = @PaymentMethod,Amount = @Amount where Pid = @Pid", con);
            cmd.Parameters.AddWithValue("@Pid", int.Parse(payment_id.Text));
            cmd.Parameters.AddWithValue("@Customername", payment_Cname.Text);
            cmd.Parameters.AddWithValue("@Food1", payment_food1.Text);
            cmd.Parameters.AddWithValue("@Food2", payment_food2.Text);
            cmd.Parameters.AddWithValue("@Food3", payment_food3.Text);
            cmd.Parameters.AddWithValue("@PaymentMethod", payment_method.Text);
            cmd.Parameters.AddWithValue("@Amount", decimal.Parse(payment_amount.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void payment_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete payment where Pid = @Pid", con);
            cmd.Parameters.AddWithValue("@Pid", int.Parse(payment_id.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void payment_display_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from payment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            paymentgrid.DataSource = dt;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from payment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            paymentgrid.DataSource = dt;
        }

        private void payment_id_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Customername,Food1, Food2, Food3,PaymentMethod,Amount from payment where  Pid = @Pid", con);
            cmd.Parameters.AddWithValue("@Pid", payment_id.Text);
            SqlDataReader dp = cmd.ExecuteReader();
            while (dp.Read())
            {
                payment_Cname.Text = dp.IsDBNull(0) ? "" : dp.GetValue(0).ToString();
                payment_food1.Text = dp.IsDBNull(1) ? "" : dp.GetValue(1).ToString();
                payment_food2.Text = dp.IsDBNull(2) ? "" : dp.GetValue(2).ToString();
                payment_food3.Text = dp.IsDBNull(3) ? "" : dp.GetValue(3).ToString();
                payment_method.Text = dp.IsDBNull(4) ? "" : dp.GetValue(4).ToString();
                payment_amount.Text = dp.IsDBNull(5) ? "" : dp.GetValue(5).ToString();
            }
            con.Close();
        }
    }
}
