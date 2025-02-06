namespace WinFormsApp1
{
    partial class Food
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
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            food_id = new TextBox();
            food_name = new TextBox();
            food_price = new TextBox();
            food_quantity = new TextBox();
            food_status = new ComboBox();
            pictureBox1 = new PictureBox();
            food_save = new Button();
            food_add = new Button();
            food_new = new Button();
            food_update = new Button();
            food_delete = new Button();
            food_display = new Button();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            panel1.Size = new Size(823, 49);
            panel1.TabIndex = 0;
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
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 1;
            label1.Text = "FOOD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 79);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 5;
            label5.Text = "Food ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 6;
            label2.Text = "Food Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 158);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 7;
            label3.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 194);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantity :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 230);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 9;
            label6.Text = "Status :";
            // 
            // food_id
            // 
            food_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_id.Location = new Point(122, 76);
            food_id.Name = "food_id";
            food_id.Size = new Size(241, 27);
            food_id.TabIndex = 10;
            food_id.TextChanged += food_id_TextChanged;
            // 
            // food_name
            // 
            food_name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_name.Location = new Point(122, 114);
            food_name.Name = "food_name";
            food_name.Size = new Size(241, 27);
            food_name.TabIndex = 11;
            // 
            // food_price
            // 
            food_price.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_price.Location = new Point(122, 158);
            food_price.Name = "food_price";
            food_price.Size = new Size(241, 27);
            food_price.TabIndex = 12;
            // 
            // food_quantity
            // 
            food_quantity.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_quantity.Location = new Point(122, 194);
            food_quantity.Name = "food_quantity";
            food_quantity.Size = new Size(241, 27);
            food_quantity.TabIndex = 13;
            // 
            // food_status
            // 
            food_status.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            food_status.FormattingEnabled = true;
            food_status.Items.AddRange(new object[] { "Available", "Unavailable" });
            food_status.Location = new Point(122, 231);
            food_status.Name = "food_status";
            food_status.Size = new Size(241, 28);
            food_status.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.berger;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(396, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 180);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // food_save
            // 
            food_save.BackColor = Color.CornflowerBlue;
            food_save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food_save.Location = new Point(12, 304);
            food_save.Name = "food_save";
            food_save.Size = new Size(108, 37);
            food_save.TabIndex = 16;
            food_save.Text = "SAVE";
            food_save.UseVisualStyleBackColor = false;
            food_save.Click += food_save_Click;
            // 
            // food_add
            // 
            food_add.BackColor = Color.CornflowerBlue;
            food_add.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food_add.Location = new Point(150, 304);
            food_add.Name = "food_add";
            food_add.Size = new Size(108, 37);
            food_add.TabIndex = 17;
            food_add.Text = "ADD";
            food_add.UseVisualStyleBackColor = false;
            food_add.Click += food_add_Click;
            // 
            // food_new
            // 
            food_new.BackColor = Color.CornflowerBlue;
            food_new.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food_new.Location = new Point(292, 304);
            food_new.Name = "food_new";
            food_new.Size = new Size(108, 37);
            food_new.TabIndex = 18;
            food_new.Text = "NEW";
            food_new.UseVisualStyleBackColor = false;
            food_new.Click += food_new_Click;
            // 
            // food_update
            // 
            food_update.BackColor = Color.CornflowerBlue;
            food_update.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food_update.Location = new Point(435, 304);
            food_update.Name = "food_update";
            food_update.Size = new Size(108, 37);
            food_update.TabIndex = 19;
            food_update.Text = "UPDATE";
            food_update.UseVisualStyleBackColor = false;
            food_update.Click += food_update_Click;
            // 
            // food_delete
            // 
            food_delete.BackColor = Color.CornflowerBlue;
            food_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food_delete.Location = new Point(576, 304);
            food_delete.Name = "food_delete";
            food_delete.Size = new Size(108, 37);
            food_delete.TabIndex = 20;
            food_delete.Text = "DELETE";
            food_delete.UseVisualStyleBackColor = false;
            food_delete.Click += food_delete_Click;
            // 
            // food_display
            // 
            food_display.BackColor = Color.CornflowerBlue;
            food_display.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food_display.Location = new Point(715, 304);
            food_display.Name = "food_display";
            food_display.Size = new Size(108, 37);
            food_display.TabIndex = 21;
            food_display.Text = "DISPLAY";
            food_display.UseVisualStyleBackColor = false;
            food_display.Click += food_display_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 366);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(799, 202);
            dataGridView1.TabIndex = 22;
            // 
            // Food
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 595);
            Controls.Add(dataGridView1);
            Controls.Add(food_display);
            Controls.Add(food_delete);
            Controls.Add(food_update);
            Controls.Add(food_new);
            Controls.Add(food_add);
            Controls.Add(food_save);
            Controls.Add(pictureBox1);
            Controls.Add(food_status);
            Controls.Add(food_quantity);
            Controls.Add(food_price);
            Controls.Add(food_name);
            Controls.Add(food_id);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Food";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Food";
            Load += Food_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox food_id;
        private TextBox food_name;
        private TextBox food_price;
        private TextBox food_quantity;
        private ComboBox food_status;
        private PictureBox pictureBox1;
        private Button food_save;
        private Button food_add;
        private Button food_new;
        private Button food_update;
        private Button food_delete;
        private Button food_display;
        private DataGridView dataGridView1;
        private Button button1;
    }
}