﻿namespace STOCK_MANAGEMENT_SYSTEM_01
{
    partial class Admin_dashboard
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button7 = new Button();
            label1 = new Label();
            button1 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(52, 204);
            button2.Name = "button2";
            button2.Size = new Size(194, 29);
            button2.TabIndex = 1;
            button2.Text = "Manage Suppliers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(370, 204);
            button3.Name = "button3";
            button3.Size = new Size(160, 29);
            button3.TabIndex = 2;
            button3.Text = "Manage Customers";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(647, 204);
            button4.Name = "button4";
            button4.Size = new Size(118, 29);
            button4.TabIndex = 3;
            button4.Text = "billpayments";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button7
            // 
            button7.Location = new Point(144, 267);
            button7.Name = "button7";
            button7.Size = new Size(176, 29);
            button7.TabIndex = 6;
            button7.Text = "product_details";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 31);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 7;
            label1.Text = "ADMIN  DASHBOARD";
            // 
            // button1
            // 
            button1.Location = new Point(477, 267);
            button1.Name = "button1";
            button1.Size = new Size(189, 29);
            button1.TabIndex = 8;
            button1.Text = "Finanace operations";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(265, 344);
            button5.Name = "button5";
            button5.Size = new Size(293, 29);
            button5.TabIndex = 9;
            button5.Text = "plannings to improvements";
            button5.UseVisualStyleBackColor = true;
            // 
            // Admin_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Admin_dashboard";
            Text = "Admin_dashboard";
            Load += Admin_dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button7;
        private Label label1;
        private Button button1;
        private Button button5;
    }
}