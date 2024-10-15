namespace Tutorial3_1
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
            label4 = new Label();
            txtDayofweek = new TextBox();
            txtday = new TextBox();
            txtmonth = new TextBox();
            txtyear = new TextBox();
            lblshow = new Label();
            btnshow = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(55, 85);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(82, 163);
            label2.Name = "label2";
            label2.Size = new Size(69, 35);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(82, 240);
            label3.Name = "label3";
            label3.Size = new Size(69, 35);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 20F);
            label4.Location = new Point(82, 312);
            label4.Name = "label4";
            label4.Size = new Size(69, 35);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtDayofweek
            // 
            txtDayofweek.Font = new Font("Microsoft JhengHei UI", 22F);
            txtDayofweek.Location = new Point(279, 75);
            txtDayofweek.Name = "txtDayofweek";
            txtDayofweek.Size = new Size(224, 45);
            txtDayofweek.TabIndex = 4;
            // 
            // txtday
            // 
            txtday.Font = new Font("Microsoft JhengHei UI", 22F);
            txtday.Location = new Point(279, 153);
            txtday.Name = "txtday";
            txtday.Size = new Size(224, 45);
            txtday.TabIndex = 5;
            // 
            // txtmonth
            // 
            txtmonth.Font = new Font("Microsoft JhengHei UI", 22F);
            txtmonth.Location = new Point(279, 230);
            txtmonth.Name = "txtmonth";
            txtmonth.Size = new Size(224, 45);
            txtmonth.TabIndex = 6;
            // 
            // txtyear
            // 
            txtyear.Font = new Font("Microsoft JhengHei UI", 22F);
            txtyear.Location = new Point(279, 302);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(224, 45);
            txtyear.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 20F);
            lblshow.Location = new Point(55, 376);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(448, 81);
            lblshow.TabIndex = 8;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(55, 484);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(113, 46);
            btnshow.TabIndex = 20;
            btnshow.Text = "顯示完整日期";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(223, 484);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(113, 46);
            btnclear.TabIndex = 21;
            btnclear.Text = "清空內容";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(390, 484);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(113, 46);
            btnexit.TabIndex = 22;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 579);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshow);
            Controls.Add(lblshow);
            Controls.Add(txtyear);
            Controls.Add(txtmonth);
            Controls.Add(txtday);
            Controls.Add(txtDayofweek);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox txtDayofweek;
        private TextBox txtday;
        private TextBox txtmonth;
        private TextBox txtyear;
        private Label lblshow;
        private Button btnshow;
        private Button btnclear;
        private Button btnexit;
    }
}
