namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Stock_Data
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            button4 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(111, 39);
            button1.TabIndex = 0;
            button1.Text = "view stocks";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(476, 400);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(519, 149);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 2;
            label1.Text = "stock_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(519, 199);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 3;
            label2.Text = "Product_ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(519, 250);
            label3.Name = "label3";
            label3.Size = new Size(103, 27);
            label3.TabIndex = 4;
            label3.Text = "Quantity";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(695, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(695, 253);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 27);
            textBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(519, 424);
            button2.Name = "button2";
            button2.Size = new Size(237, 44);
            button2.TabIndex = 8;
            button2.Text = "Get Product_details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(617, 305);
            button3.Name = "button3";
            button3.Size = new Size(104, 39);
            button3.TabIndex = 9;
            button3.Text = "ADD";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Info;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(695, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSalmon;
            button4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(794, 424);
            button4.Name = "button4";
            button4.Size = new Size(103, 44);
            button4.TabIndex = 11;
            button4.Text = "back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Tan;
            label4.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(390, 41);
            label4.Name = "label4";
            label4.Size = new Size(231, 43);
            label4.TabIndex = 12;
            label4.Text = "STOCK DATA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._16;
            pictureBox1.Location = new Point(2, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1007, 595);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Stock_Data
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 589);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Stock_Data";
            Text = "Stock_Data";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private Button button4;
        private Label label4;
        private PictureBox pictureBox1;
    }
}