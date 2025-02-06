namespace WinFormsApp1
{
    partial class Payment
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
            payment_food3 = new TextBox();
            payment_food2 = new TextBox();
            payment_food1 = new TextBox();
            payment_Cname = new TextBox();
            payment_id = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            payment_amount = new TextBox();
            payment_method = new ComboBox();
            payment_display = new Button();
            payment_delete = new Button();
            payment_update = new Button();
            payment_new = new Button();
            payment_add = new Button();
            payment_save = new Button();
            paymentgrid = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentgrid).BeginInit();
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
            panel1.Size = new Size(866, 49);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(795, 8);
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
            label1.Location = new Point(337, 8);
            label1.Name = "label1";
            label1.Size = new Size(127, 32);
            label1.TabIndex = 1;
            label1.Text = "PAYMENT";
            // 
            // payment_food3
            // 
            payment_food3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_food3.Location = new Point(153, 243);
            payment_food3.Name = "payment_food3";
            payment_food3.Size = new Size(241, 27);
            payment_food3.TabIndex = 36;
            // 
            // payment_food2
            // 
            payment_food2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_food2.Location = new Point(153, 200);
            payment_food2.Name = "payment_food2";
            payment_food2.Size = new Size(241, 27);
            payment_food2.TabIndex = 35;
            // 
            // payment_food1
            // 
            payment_food1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_food1.Location = new Point(153, 160);
            payment_food1.Name = "payment_food1";
            payment_food1.Size = new Size(241, 27);
            payment_food1.TabIndex = 34;
            // 
            // payment_Cname
            // 
            payment_Cname.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_Cname.Location = new Point(153, 116);
            payment_Cname.Name = "payment_Cname";
            payment_Cname.Size = new Size(241, 27);
            payment_Cname.TabIndex = 33;
            // 
            // payment_id
            // 
            payment_id.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_id.Location = new Point(153, 78);
            payment_id.Name = "payment_id";
            payment_id.Size = new Size(241, 27);
            payment_id.TabIndex = 32;
            payment_id.TextChanged += payment_id_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 250);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 31;
            label6.Text = "Food - 3 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 207);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 30;
            label4.Text = "Food - 2 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 167);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 29;
            label3.Text = "Food - 1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 123);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 28;
            label2.Text = "Customer Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.WhiteSmoke;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 85);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 27;
            label5.Text = "Payment ID :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.m;
            pictureBox1.Location = new Point(431, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(423, 272);
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(18, 289);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 38;
            label7.Text = "Amount :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.WhiteSmoke;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 335);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 39;
            label8.Text = "Payment Method:";
            // 
            // payment_amount
            // 
            payment_amount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_amount.Location = new Point(153, 286);
            payment_amount.Name = "payment_amount";
            payment_amount.Size = new Size(241, 27);
            payment_amount.TabIndex = 40;
            // 
            // payment_method
            // 
            payment_method.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_method.FormattingEnabled = true;
            payment_method.Items.AddRange(new object[] { "Cash", "Card" });
            payment_method.Location = new Point(153, 330);
            payment_method.Name = "payment_method";
            payment_method.Size = new Size(241, 25);
            payment_method.TabIndex = 41;
            // 
            // payment_display
            // 
            payment_display.BackColor = Color.CornflowerBlue;
            payment_display.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_display.Location = new Point(744, 369);
            payment_display.Name = "payment_display";
            payment_display.Size = new Size(108, 37);
            payment_display.TabIndex = 47;
            payment_display.Text = "DISPLAY";
            payment_display.UseVisualStyleBackColor = false;
            payment_display.Click += payment_display_Click;
            // 
            // payment_delete
            // 
            payment_delete.BackColor = Color.CornflowerBlue;
            payment_delete.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_delete.Location = new Point(599, 369);
            payment_delete.Name = "payment_delete";
            payment_delete.Size = new Size(108, 37);
            payment_delete.TabIndex = 46;
            payment_delete.Text = "DELETE";
            payment_delete.UseVisualStyleBackColor = false;
            payment_delete.Click += payment_delete_Click;
            // 
            // payment_update
            // 
            payment_update.BackColor = Color.CornflowerBlue;
            payment_update.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_update.Location = new Point(448, 369);
            payment_update.Name = "payment_update";
            payment_update.Size = new Size(108, 37);
            payment_update.TabIndex = 45;
            payment_update.Text = "UPDATE";
            payment_update.UseVisualStyleBackColor = false;
            // 
            // payment_new
            // 
            payment_new.BackColor = Color.CornflowerBlue;
            payment_new.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_new.Location = new Point(298, 369);
            payment_new.Name = "payment_new";
            payment_new.Size = new Size(108, 37);
            payment_new.TabIndex = 44;
            payment_new.Text = "NEW";
            payment_new.UseVisualStyleBackColor = false;
            // 
            // payment_add
            // 
            payment_add.BackColor = Color.CornflowerBlue;
            payment_add.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_add.Location = new Point(153, 369);
            payment_add.Name = "payment_add";
            payment_add.Size = new Size(108, 37);
            payment_add.TabIndex = 43;
            payment_add.Text = "ADD";
            payment_add.UseVisualStyleBackColor = false;
            payment_add.Click += payment_add_Click;
            // 
            // payment_save
            // 
            payment_save.BackColor = Color.CornflowerBlue;
            payment_save.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payment_save.Location = new Point(18, 369);
            payment_save.Name = "payment_save";
            payment_save.Size = new Size(108, 37);
            payment_save.TabIndex = 42;
            payment_save.Text = "SAVE";
            payment_save.UseVisualStyleBackColor = false;
            payment_save.Click += payment_save_Click;
            // 
            // paymentgrid
            // 
            paymentgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentgrid.BackgroundColor = Color.Lavender;
            paymentgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentgrid.Location = new Point(18, 424);
            paymentgrid.Name = "paymentgrid";
            paymentgrid.Size = new Size(836, 244);
            paymentgrid.TabIndex = 48;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 669);
            Controls.Add(paymentgrid);
            Controls.Add(payment_display);
            Controls.Add(payment_delete);
            Controls.Add(payment_update);
            Controls.Add(payment_new);
            Controls.Add(payment_add);
            Controls.Add(payment_save);
            Controls.Add(payment_method);
            Controls.Add(payment_amount);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(payment_food3);
            Controls.Add(payment_food2);
            Controls.Add(payment_food1);
            Controls.Add(payment_Cname);
            Controls.Add(payment_id);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(panel1);
            Name = "Payment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += Payment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentgrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private TextBox payment_food3;
        private TextBox payment_food2;
        private TextBox payment_food1;
        private TextBox payment_Cname;
        private TextBox payment_id;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
        private TextBox payment_amount;
        private ComboBox payment_method;
        private Button payment_display;
        private Button payment_delete;
        private Button payment_update;
        private Button payment_new;
        private Button payment_add;
        private Button payment_save;
        private DataGridView paymentgrid;
    }
}