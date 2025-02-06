namespace WinFormsApp1
{
    partial class register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            buttn = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            register_username = new TextBox();
            label6 = new Label();
            register_password = new TextBox();
            label7 = new Label();
            register_Cpassword = new TextBox();
            register_Showpass = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 492);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.Screenshot_2025_01_12_115031;
            pictureBox1.Location = new Point(87, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 188);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 2;
            label2.Text = "RESTURENT NAME";
            // 
            // buttn
            // 
            buttn.BackColor = Color.CornflowerBlue;
            buttn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttn.Location = new Point(27, 385);
            buttn.Name = "buttn";
            buttn.Size = new Size(236, 41);
            buttn.TabIndex = 1;
            buttn.Text = "SIGN IN";
            buttn.UseVisualStyleBackColor = false;
            buttn.Click += buttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 345);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 0;
            label1.Text = "Already have an Account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(628, 9);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 2;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.MediumAquamarine;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(328, 65);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = "SIGN UP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(329, 109);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 4;
            label5.Text = "Username :";
            // 
            // register_username
            // 
            register_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_username.Location = new Point(329, 147);
            register_username.Name = "register_username";
            register_username.Size = new Size(241, 27);
            register_username.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(328, 193);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 6;
            label6.Text = "Password :";
            // 
            // register_password
            // 
            register_password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_password.Location = new Point(328, 231);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.Size = new Size(241, 27);
            register_password.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(328, 279);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 8;
            label7.Text = "Confirm Password :";
            // 
            // register_Cpassword
            // 
            register_Cpassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            register_Cpassword.Location = new Point(329, 316);
            register_Cpassword.Name = "register_Cpassword";
            register_Cpassword.PasswordChar = '*';
            register_Cpassword.Size = new Size(241, 27);
            register_Cpassword.TabIndex = 9;
            // 
            // register_Showpass
            // 
            register_Showpass.AutoSize = true;
            register_Showpass.BackColor = Color.WhiteSmoke;
            register_Showpass.Location = new Point(329, 352);
            register_Showpass.Name = "register_Showpass";
            register_Showpass.Size = new Size(108, 19);
            register_Showpass.TabIndex = 10;
            register_Showpass.Text = "Show Password";
            register_Showpass.UseVisualStyleBackColor = false;
            register_Showpass.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(328, 389);
            button1.Name = "button1";
            button1.Size = new Size(108, 37);
            button1.TabIndex = 11;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.gourmet_food_shot_with_restaurant_background_proper_for_menu_design_G07CWH;
            ClientSize = new Size(664, 492);
            Controls.Add(button1);
            Controls.Add(register_Showpass);
            Controls.Add(register_Cpassword);
            Controls.Add(label7);
            Controls.Add(register_password);
            Controls.Add(label6);
            Controls.Add(register_username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "register";
            Text = "register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button buttn;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox register_username;
        private Label label6;
        private TextBox register_password;
        private Label label7;
        private TextBox register_Cpassword;
        private CheckBox register_Showpass;
        private Button button1;
    }
}