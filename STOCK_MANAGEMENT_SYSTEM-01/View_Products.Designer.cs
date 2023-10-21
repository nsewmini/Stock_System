namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class View_Products
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();

            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            GenButton = new Button();
            sqlDataRecordBindingSource = new BindingSource(components);
            sqlDataRecordBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource1).BeginInit();

            SuspendLayout();
            // 
            // button1
            // 

            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(399, 62);
            button1.Name = "button1";
            button1.Size = new Size(212, 51);

            
            button1.Margin = new Padding(3, 2, 3, 2);
            
            

            button1.TabIndex = 0;
            button1.Text = "view products";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dataGridView1.Location = new Point(75, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(849, 423);

          
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            
            
            
            
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 

            button2.BackColor = Color.Tomato;
            button2.Location = new Point(32, 45);
            button2.Name = "button2";
            button2.Size = new Size(96, 40);

           
            button2.Margin = new Padding(3, 2, 3, 2);
            
           
            button2.TabIndex = 2;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 

            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._12;
            pictureBox1.Location = new Point(2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1009, 590);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;

            // GenButton
            // 
            GenButton.Location = new Point(571, 40);
            GenButton.Name = "GenButton";
            GenButton.Size = new Size(75, 23);
            GenButton.TabIndex = 3;
            GenButton.Text = "Generate ";
            GenButton.UseVisualStyleBackColor = true;
            GenButton.Click += button3_Click;
            // 
            // sqlDataRecordBindingSource
            // 
            sqlDataRecordBindingSource.DataSource = typeof(Microsoft.SqlServer.Server.SqlDataRecord);
            // 
            // sqlDataRecordBindingSource1
            // 
            sqlDataRecordBindingSource1.DataSource = typeof(Microsoft.SqlServer.Server.SqlDataRecord);

            // 
            // View_Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            ClientSize = new Size(1002, 589);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
          
            Controls.Add(GenButton);
            
            
           
            Margin = new Padding(3, 2, 3, 2);
            Name = "View_Products";
            Text = "View_Products";
            Load += View_Products_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource1).EndInit();

            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;

        private PictureBox pictureBox1;

        private Button GenButton;
        private BindingSource sqlDataRecordBindingSource;
        private BindingSource sqlDataRecordBindingSource1;

    }
}