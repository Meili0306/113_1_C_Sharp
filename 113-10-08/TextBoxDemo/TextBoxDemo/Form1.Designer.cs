﻿namespace TextBoxDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnconfirm = new Button();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            lblshow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(60, 86);
            label1.Name = "label1";
            label1.Size = new Size(158, 35);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(60, 193);
            label2.Name = "label2";
            label2.Size = new Size(156, 35);
            label2.TabIndex = 1;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(60, 294);
            label3.Name = "label3";
            label3.Size = new Size(149, 35);
            label3.TabIndex = 2;
            label3.Text = "Full Name:";
            // 
            // btnconfirm
            // 
            btnconfirm.Font = new Font("Microsoft JhengHei UI", 15F);
            btnconfirm.Location = new Point(323, 384);
            btnconfirm.Name = "btnconfirm";
            btnconfirm.Size = new Size(152, 54);
            btnconfirm.TabIndex = 3;
            btnconfirm.Text = "Confirm";
            btnconfirm.UseVisualStyleBackColor = true;
            btnconfirm.Click += button1_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft JhengHei UI", 25F);
            txtFirstName.Location = new Point(269, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(287, 50);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft JhengHei UI", 25F);
            txtLastName.Location = new Point(269, 193);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(287, 50);
            txtLastName.TabIndex = 5;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 25F);
            lblshow.Location = new Point(269, 294);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(287, 46);
            lblshow.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblshow);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(btnconfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnconfirm;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label lblshow;
    }
}
