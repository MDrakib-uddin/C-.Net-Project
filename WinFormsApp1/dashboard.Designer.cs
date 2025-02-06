namespace WinFormsApp1
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            food_count = new Label();
            label5 = new Label();
            panel4 = new Panel();
            customer_count = new Label();
            label2 = new Label();
            panel5 = new Panel();
            orders_count = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 57);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(867, 3);
            button1.Name = "button1";
            button1.Size = new Size(57, 38);
            button1.TabIndex = 29;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 1;
            label1.Text = "ADMIN DASHBOARD";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 467);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(215, 173);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(food_count);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(251, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 175);
            panel3.TabIndex = 5;
            // 
            // food_count
            // 
            food_count.AutoSize = true;
            food_count.BackColor = Color.WhiteSmoke;
            food_count.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food_count.Location = new Point(156, 16);
            food_count.Name = "food_count";
            food_count.Size = new Size(19, 21);
            food_count.TabIndex = 29;
            food_count.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 16);
            label5.Name = "label5";
            label5.Size = new Size(71, 21);
            label5.TabIndex = 28;
            label5.Text = "FOODS :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(customer_count);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(474, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 175);
            panel4.TabIndex = 6;
            // 
            // customer_count
            // 
            customer_count.AutoSize = true;
            customer_count.BackColor = Color.WhiteSmoke;
            customer_count.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_count.Location = new Point(167, 16);
            customer_count.Name = "customer_count";
            customer_count.Size = new Size(19, 21);
            customer_count.TabIndex = 30;
            customer_count.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 16);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 29;
            label2.Text = "CUSTOMER :";
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSkyBlue;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(orders_count);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(699, 71);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 175);
            panel5.TabIndex = 7;
            // 
            // orders_count
            // 
            orders_count.AutoSize = true;
            orders_count.BackColor = Color.WhiteSmoke;
            orders_count.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orders_count.Location = new Point(168, 16);
            orders_count.Name = "orders_count";
            orders_count.Size = new Size(19, 21);
            orders_count.TabIndex = 30;
            orders_count.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 16);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 29;
            label3.Text = "ORDERS:";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 524);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "dashboard";
            Text = "dashboard";
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label food_count;
        private Label label5;
        private Label customer_count;
        private Label label2;
        private Label orders_count;
        private Label label3;
    }
}