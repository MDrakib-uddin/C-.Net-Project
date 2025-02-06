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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Food : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
        public Food()
        {
            InitializeComponent();
        }

        private void food_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into food values (@Foodid,@Foodname,@Price,@Quantity,@Status)", con);
            cmd.Parameters.AddWithValue("@Foodid", int.Parse(food_id.Text));
            cmd.Parameters.AddWithValue("@Foodname", food_name.Text);
            cmd.Parameters.AddWithValue("@Price", food_price.Text);
            cmd.Parameters.AddWithValue("@Quantity", food_quantity.Text);
            cmd.Parameters.AddWithValue("@Status", food_status.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void food_add_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void food_new_Click(object sender, EventArgs e)
        {
            food_id.Text = "";
            food_name.Text = "";
            food_price.Text = "";
            food_quantity.Text = "";
            food_status.Text = "";
        }

        private void food_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update food set Foodname = @Foodname,price = @Price,quantity = @Quantity,status = @Status where foodid = @Foodid", con);
            cmd.Parameters.AddWithValue("@Foodid", int.Parse(food_id.Text));
            cmd.Parameters.AddWithValue("@Foodname", food_name.Text);
            cmd.Parameters.AddWithValue("@Price", food_price.Text);
            cmd.Parameters.AddWithValue("@Quantity", food_quantity.Text);
            cmd.Parameters.AddWithValue("@Status", food_status.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void food_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("delete food where foodid = @Foodid", con);
            cmd.Parameters.AddWithValue("@Foodid", int.Parse(food_id.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void food_display_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Food_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from food", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
            this.Hide();
        }

        private void food_id_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Foodname,Price,Quantity,Status from food where Foodid = @Foodid", con);
            cmd.Parameters.AddWithValue("@Foodid", food_id.Text);
            SqlDataReader dp = cmd.ExecuteReader();
            while (dp.Read())
            {
                food_name.Text = dp.GetValue(0).ToString();
                food_price.Text = dp.GetValue(1).ToString();
                food_quantity.Text = dp.GetValue(1).ToString();
                food_status.Text = dp.GetValue(1).ToString();
            }
            con.Close();
        }
      
    }
}
