namespace WinFormsApp1
{
    partial class Customer
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
            button1 = new Button();
            label1 = new Label();
            customer_email = new TextBox();
            customer_phone = new TextBox();
            customer_name = new TextBox();
            customer_id = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            customer_address = new TextBox();
            pictureBox1 = new PictureBox();
            customer_display = new Button();
            customer_delete = new Button();
            customer_update = new Button();
            customer_new = new Button();
            customer_add = new Button();
            customer_save = new Button();
            customergrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customergrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 49);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(767, 3);
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
            label1.Location = new Point(319, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 1;
            label1.Text = "CUSTOMER";
            // 
            // customer_email
            // 
            customer_email.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_email.Location = new Point(159, 207);
            customer_email.Name = "customer_email";
            customer_email.Size = new Size(241, 27);
            customer_email.TabIndex = 23;
            // 
            // customer_phone
            // 
            customer_phone.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_phone.Location = new Point(159, 171);
            customer_phone.Name = "customer_phone";
            customer_phone.Size = new Size(241, 27);
            customer_phone.TabIndex = 22;
            // 
            // customer_name
            // 
            customer_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_name.Location = new Point(159, 130);
            customer_name.Name = "customer_name";
            customer_name.Size = new Size(241, 27);
            customer_name.TabIndex = 21;
            // 
            // customer_id
            // 
            customer_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_id.Location = new Point(159, 92);
            customer_id.Name = "customer_id";
            customer_id.Size = new Size(241, 27);
            customer_id.TabIndex = 20;
            customer_id.TextChanged += customer_id_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(22, 248);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 19;
            label6.Text = "Address :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 214);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 18;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 178);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 17;
            label3.Text = "Phone :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 137);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 16;
            label2.Text = "Customer Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 99);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 15;
            label5.Text = "Customer ID :";
            // 
            // customer_address
            // 
            customer_address.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_address.Location = new Point(159, 245);
            customer_address.Name = "customer_address";
            customer_address.Size = new Size(241, 27);
            customer_address.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MintCream;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.customers_icon_121;
            pictureBox1.Location = new Point(437, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 169);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // customer_display
            // 
            customer_display.BackColor = Color.CornflowerBlue;
            customer_display.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_display.Location = new Point(716, 304);
            customer_display.Name = "customer_display";
            customer_display.Size = new Size(108, 37);
            customer_display.TabIndex = 33;
            customer_display.Text = "DISPLAY";
            customer_display.UseVisualStyleBackColor = false;
            customer_display.Click += customer_display_Click;
            // 
            // customer_delete
            // 
            customer_delete.BackColor = Color.CornflowerBlue;
            customer_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_delete.Location = new Point(577, 304);
            customer_delete.Name = "customer_delete";
            customer_delete.Size = new Size(108, 37);
            customer_delete.TabIndex = 32;
            customer_delete.Text = "DELETE";
            customer_delete.UseVisualStyleBackColor = false;
            customer_delete.Click += customer_delete_Click;
            // 
            // customer_update
            // 
            customer_update.BackColor = Color.CornflowerBlue;
            customer_update.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_update.Location = new Point(436, 304);
            customer_update.Name = "customer_update";
            customer_update.Size = new Size(108, 37);
            customer_update.TabIndex = 31;
            customer_update.Text = "UPDATE";
            customer_update.UseVisualStyleBackColor = false;
            customer_update.Click += customer_update_Click;
            // 
            // customer_new
            // 
            customer_new.BackColor = Color.CornflowerBlue;
            customer_new.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_new.Location = new Point(293, 304);
            customer_new.Name = "customer_new";
            customer_new.Size = new Size(108, 37);
            customer_new.TabIndex = 30;
            customer_new.Text = "NEW";
            customer_new.UseVisualStyleBackColor = false;
            customer_new.Click += customer_new_Click;
            // 
            // customer_add
            // 
            customer_add.BackColor = Color.CornflowerBlue;
            customer_add.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_add.Location = new Point(151, 304);
            customer_add.Name = "customer_add";
            customer_add.Size = new Size(108, 37);
            customer_add.TabIndex = 29;
            customer_add.Text = "ADD";
            customer_add.UseVisualStyleBackColor = false;
            customer_add.Click += customer_add_Click;
            // 
            // customer_save
            // 
            customer_save.BackColor = Color.CornflowerBlue;
            customer_save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_save.Location = new Point(13, 304);
            customer_save.Name = "customer_save";
            customer_save.Size = new Size(108, 37);
            customer_save.TabIndex = 28;
            customer_save.Text = "SAVE";
            customer_save.UseVisualStyleBackColor = false;
            customer_save.Click += food_save_Click;
            // 
            // customergrid
            // 
            customergrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customergrid.BackgroundColor = Color.Lavender;
            customergrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customergrid.Location = new Point(13, 357);
            customergrid.Name = "customergrid";
            customergrid.Size = new Size(811, 251);
            customergrid.TabIndex = 34;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 645);
            Controls.Add(customergrid);
            Controls.Add(customer_display);
            Controls.Add(customer_delete);
            Controls.Add(customer_update);
            Controls.Add(customer_new);
            Controls.Add(customer_add);
            Controls.Add(customer_save);
            Controls.Add(pictureBox1);
            Controls.Add(customer_address);
            Controls.Add(customer_email);
            Controls.Add(customer_phone);
            Controls.Add(customer_name);
            Controls.Add(customer_id);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Customer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += Customer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customergrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox customer_email;
        private TextBox customer_phone;
        private TextBox customer_name;
        private TextBox customer_id;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox customer_address;
        private PictureBox pictureBox1;
        private Button customer_display;
        private Button customer_delete;
        private Button customer_update;
        private Button customer_new;
        private Button customer_add;
        private Button customer_save;
        private DataGridView customergrid;
        private Button button1;
    }
}