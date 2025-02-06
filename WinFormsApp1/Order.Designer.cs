namespace WinFormsApp1
{
    partial class Order
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
            food_2 = new TextBox();
            food_1 = new TextBox();
            customer_name = new TextBox();
            order_id = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            food_3 = new TextBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ordergrid = new DataGridView();
            customer_display = new Button();
            customer_delete = new Button();
            customer_update = new Button();
            customer_new = new Button();
            customer_add = new Button();
            customer_save = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordergrid).BeginInit();
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
            panel1.Size = new Size(827, 49);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(763, 3);
            button1.Name = "button1";
            button1.Size = new Size(57, 38);
            button1.TabIndex = 30;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 1;
            label1.Text = "CUSTOMER'S ORDER";
            // 
            // food_2
            // 
            food_2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_2.Location = new Point(149, 202);
            food_2.Name = "food_2";
            food_2.Size = new Size(241, 27);
            food_2.TabIndex = 23;
            // 
            // food_1
            // 
            food_1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_1.Location = new Point(149, 162);
            food_1.Name = "food_1";
            food_1.Size = new Size(241, 27);
            food_1.TabIndex = 22;
            // 
            // customer_name
            // 
            customer_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customer_name.Location = new Point(149, 118);
            customer_name.Name = "customer_name";
            customer_name.Size = new Size(241, 27);
            customer_name.TabIndex = 21;
            // 
            // order_id
            // 
            order_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            order_id.Location = new Point(149, 80);
            order_id.Name = "order_id";
            order_id.Size = new Size(241, 27);
            order_id.TabIndex = 20;
            order_id.TextChanged += order_id_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 248);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 19;
            label6.Text = "Food - 3 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 205);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 18;
            label4.Text = "Food - 2 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 17;
            label3.Text = "Food - 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 121);
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
            label5.Location = new Point(12, 83);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 15;
            label5.Text = "Order ID :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.berger;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(422, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 180);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // food_3
            // 
            food_3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_3.Location = new Point(149, 245);
            food_3.Name = "food_3";
            food_3.Size = new Size(241, 27);
            food_3.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 295);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 27;
            label7.Text = "Order Date :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(149, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 28;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // ordergrid
            // 
            ordergrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ordergrid.BackgroundColor = Color.Lavender;
            ordergrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordergrid.Location = new Point(9, 383);
            ordergrid.Name = "ordergrid";
            ordergrid.Size = new Size(811, 251);
            ordergrid.TabIndex = 41;
            // 
            // customer_display
            // 
            customer_display.BackColor = Color.CornflowerBlue;
            customer_display.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_display.Location = new Point(712, 340);
            customer_display.Name = "customer_display";
            customer_display.Size = new Size(108, 37);
            customer_display.TabIndex = 40;
            customer_display.Text = "DISPLAY";
            customer_display.UseVisualStyleBackColor = false;
            customer_display.Click += customer_display_Click;
            // 
            // customer_delete
            // 
            customer_delete.BackColor = Color.CornflowerBlue;
            customer_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_delete.Location = new Point(575, 340);
            customer_delete.Name = "customer_delete";
            customer_delete.Size = new Size(108, 37);
            customer_delete.TabIndex = 39;
            customer_delete.Text = "DELETE";
            customer_delete.UseVisualStyleBackColor = false;
            customer_delete.Click += customer_delete_Click;
            // 
            // customer_update
            // 
            customer_update.BackColor = Color.CornflowerBlue;
            customer_update.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_update.Location = new Point(434, 340);
            customer_update.Name = "customer_update";
            customer_update.Size = new Size(108, 37);
            customer_update.TabIndex = 38;
            customer_update.Text = "UPDATE";
            customer_update.UseVisualStyleBackColor = false;
            customer_update.Click += customer_update_Click;
            // 
            // customer_new
            // 
            customer_new.BackColor = Color.CornflowerBlue;
            customer_new.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_new.Location = new Point(282, 340);
            customer_new.Name = "customer_new";
            customer_new.Size = new Size(108, 37);
            customer_new.TabIndex = 37;
            customer_new.Text = "NEW";
            customer_new.UseVisualStyleBackColor = false;
            customer_new.Click += customer_new_Click;
            // 
            // customer_add
            // 
            customer_add.BackColor = Color.CornflowerBlue;
            customer_add.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_add.Location = new Point(149, 340);
            customer_add.Name = "customer_add";
            customer_add.Size = new Size(108, 37);
            customer_add.TabIndex = 36;
            customer_add.Text = "ADD";
            customer_add.UseVisualStyleBackColor = false;
            customer_add.Click += customer_add_Click;
            // 
            // customer_save
            // 
            customer_save.BackColor = Color.CornflowerBlue;
            customer_save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customer_save.Location = new Point(9, 340);
            customer_save.Name = "customer_save";
            customer_save.Size = new Size(108, 37);
            customer_save.TabIndex = 35;
            customer_save.Text = "SAVE";
            customer_save.UseVisualStyleBackColor = false;
            customer_save.Click += customer_save_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 636);
            Controls.Add(ordergrid);
            Controls.Add(customer_display);
            Controls.Add(customer_delete);
            Controls.Add(customer_update);
            Controls.Add(customer_new);
            Controls.Add(customer_add);
            Controls.Add(customer_save);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(food_3);
            Controls.Add(pictureBox1);
            Controls.Add(food_2);
            Controls.Add(food_1);
            Controls.Add(customer_name);
            Controls.Add(order_id);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Order";
            Text = "Order";
            Load += Order_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordergrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox food_2;
        private TextBox food_1;
        private TextBox customer_name;
        private TextBox order_id;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox food_3;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private DataGridView ordergrid;
        private Button customer_display;
        private Button customer_delete;
        private Button customer_update;
        private Button customer_new;
        private Button customer_add;
        private Button customer_save;
    }
}