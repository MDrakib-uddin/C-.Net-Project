using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAKIB\SQLEXPRESS;Initial Catalog=Resturent;Integrated Security=True;Trust Server Certificate=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttn_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
        }
        public bool emptyFields()
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (emptyFields())
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string loginQuery = "SELECT * FROM Users WHERE username = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(loginQuery, con))
                {

                    cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.HasRows)
                        {
                            reader.Read();
                            string userRole = reader["role"].ToString();

                            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            if (userRole == "Customer")
                            {
                                Main adminForm = new Main();
                                adminForm.Show();
                                this.Hide();
                            }

                            else
                            {
                                MessageBox.Show("Invalid user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select password from users where username = @username", con);
            cmd.Parameters.AddWithValue("@username", login_username.Text);
            SqlDataReader dp = cmd.ExecuteReader();
            while (dp.Read())
            {
                login_password.Text = dp.GetValue(0).ToString();
               
            }
            con.Close();
        }
    }
}
