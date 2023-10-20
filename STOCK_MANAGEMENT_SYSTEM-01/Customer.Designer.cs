namespace STOCK_MANAGEMENT_SYSTEM_01
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 215);
            label2.Name = "label2";
            label2.Size = new Size(198, 27);
            label2.TabIndex = 1;
            label2.Text = "CUSTOMER NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 274);
            label3.Name = "label3";
            label3.Size = new Size(111, 27);
            label3.TabIndex = 2;
            label3.Text = "ADDRESS";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 338);
            label4.Name = "label4";
            label4.Size = new Size(80, 27);
            label4.TabIndex = 3;
            label4.Text = "EMAIL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 401);
            label5.Name = "label5";
            label5.Size = new Size(177, 27);
            label5.TabIndex = 4;
            label5.Text = "MOBILE PHONE";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(224, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(224, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(224, 338);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(224, 401);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(199, 509);
            button1.Name = "button1";
            button1.Size = new Size(128, 46);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(9, 159);
            label1.Name = "label1";
            label1.Size = new Size(159, 27);
            label1.TabIndex = 11;
            label1.Text = "CUSTOMER ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 159);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSalmon;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(22, 509);
            button2.Name = "button2";
            button2.Size = new Size(130, 46);
            button2.TabIndex = 13;
            button2.Text = "view";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(371, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(607, 437);
            dataGridView1.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(44, 34);
            button3.Name = "button3";
            button3.Size = new Size(108, 36);
            button3.TabIndex = 15;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(413, 34);
            label7.Name = "label7";
            label7.Size = new Size(168, 36);
            label7.TabIndex = 17;
            label7.Text = "CUSTOMER";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1002, 589);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Customer";
            Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private DataGridView dataGridView1;
        private Button button3;
        private Label label7;
    }
}