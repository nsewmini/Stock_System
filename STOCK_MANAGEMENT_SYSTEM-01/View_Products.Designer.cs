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
            button1.Location = new Point(232, 41);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(195, 22);
            button1.TabIndex = 0;
            button1.Text = "view products";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 88);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(647, 190);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(50, 40);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 2;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
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
            ClientSize = new Size(700, 338);
            Controls.Add(GenButton);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "View_Products";
            Text = "View_Products";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)sqlDataRecordBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button GenButton;
        private BindingSource sqlDataRecordBindingSource;
        private BindingSource sqlDataRecordBindingSource1;
    }
}