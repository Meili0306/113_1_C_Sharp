namespace Tutorial3_2
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
            txbkm = new TextBox();
            txbliter = new TextBox();
            lblshow = new Label();
            btncalculate = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 20F);
            label1.Location = new Point(75, 49);
            label1.Name = "label1";
            label1.Size = new Size(96, 35);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 20F);
            label2.Location = new Point(48, 142);
            label2.Name = "label2";
            label2.Size = new Size(123, 35);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 20F);
            label3.Location = new Point(10, 234);
            label3.Name = "label3";
            label3.Size = new Size(161, 35);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // txbkm
            // 
            txbkm.Font = new Font("Microsoft JhengHei UI", 20F);
            txbkm.Location = new Point(226, 43);
            txbkm.Name = "txbkm";
            txbkm.Size = new Size(238, 41);
            txbkm.TabIndex = 3;
            // 
            // txbliter
            // 
            txbliter.Font = new Font("Microsoft JhengHei UI", 20F);
            txbliter.Location = new Point(226, 139);
            txbliter.Name = "txbliter";
            txbliter.Size = new Size(238, 41);
            txbliter.TabIndex = 4;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 15F);
            lblshow.Location = new Point(226, 225);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(238, 58);
            lblshow.TabIndex = 6;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btncalculate
            // 
            btncalculate.Font = new Font("Microsoft JhengHei UI", 15F);
            btncalculate.Location = new Point(75, 331);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(138, 67);
            btncalculate.TabIndex = 7;
            btncalculate.Text = "計算";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnexit.Location = new Point(294, 331);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(138, 67);
            btnexit.TabIndex = 8;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 450);
            Controls.Add(btnexit);
            Controls.Add(btncalculate);
            Controls.Add(lblshow);
            Controls.Add(txbliter);
            Controls.Add(txbkm);
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
        private TextBox txbkm;
        private TextBox txbliter;
        private Label lblshow;
        private Button btncalculate;
        private Button btnexit;
    }
}
