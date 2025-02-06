namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            login_username = new TextBox();
            label6 = new Label();
            login_password = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 464);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
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
            label2.Location = new Point(63, 168);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 2;
            label2.Text = "Resturent Name";
            // 
            // buttn
            // 
            buttn.BackColor = Color.CornflowerBlue;
            buttn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttn.Location = new Point(27, 385);
            buttn.Name = "buttn";
            buttn.Size = new Size(236, 41);
            buttn.TabIndex = 1;
            buttn.Text = "REGISTER";
            buttn.UseVisualStyleBackColor = false;
            buttn.Click += buttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(63, 344);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Create an Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(598, 9);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 1;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(329, 98);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 2;
            label4.Text = "SIGN IN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(329, 145);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 3;
            label5.Text = "Username :";
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(329, 186);
            login_username.Name = "login_username";
            login_username.Size = new Size(241, 27);
            login_username.TabIndex = 4;
            login_username.TextChanged += login_username_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(329, 232);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 5;
            label6.Text = "Password :";
            // 
            // login_password
            // 
            login_password.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(329, 272);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(241, 27);
            login_password.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.WhiteSmoke;
            checkBox1.Location = new Point(329, 314);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(329, 357);
            button1.Name = "button1";
            button1.Size = new Size(108, 37);
            button1.TabIndex = 8;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            BackgroundImage = Properties.Resources.gourmet_food_shot_with_restaurant_background_proper_for_menu_design_G07CWH;
            ClientSize = new Size(634, 464);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(login_password);
            Controls.Add(label6);
            Controls.Add(login_username);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button buttn;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox login_username;
        private Label label6;
        private TextBox login_password;
        private CheckBox checkBox1;
        private Button button1;
    }
}
