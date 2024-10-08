namespace Tutorial2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ptxback = new PictureBox();
            ptxfront = new PictureBox();
            btnshowback = new Button();
            btnshowfront = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            SuspendLayout();
            // 
            // ptxback
            // 
            ptxback.Image = (Image)resources.GetObject("ptxback.Image");
            ptxback.Location = new Point(96, 49);
            ptxback.Name = "ptxback";
            ptxback.Size = new Size(180, 231);
            ptxback.SizeMode = PictureBoxSizeMode.Zoom;
            ptxback.TabIndex = 0;
            ptxback.TabStop = false;
            ptxback.Visible = false;
            // 
            // ptxfront
            // 
            ptxfront.Image = (Image)resources.GetObject("ptxfront.Image");
            ptxfront.Location = new Point(375, 49);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(180, 231);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 1;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // btnshowback
            // 
            btnshowback.Font = new Font("Microsoft JhengHei UI", 25F);
            btnshowback.Location = new Point(127, 345);
            btnshowback.Name = "btnshowback";
            btnshowback.Size = new Size(119, 59);
            btnshowback.TabIndex = 2;
            btnshowback.Text = "背面";
            btnshowback.UseVisualStyleBackColor = true;
            btnshowback.Click += btnshowback_Click;
            // 
            // btnshowfront
            // 
            btnshowfront.Font = new Font("Microsoft JhengHei UI", 25F);
            btnshowfront.Location = new Point(408, 345);
            btnshowfront.Name = "btnshowfront";
            btnshowfront.Size = new Size(119, 59);
            btnshowfront.TabIndex = 3;
            btnshowfront.Text = "正面";
            btnshowfront.UseVisualStyleBackColor = true;
            btnshowfront.Click += btnshowfront_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 20F);
            btnExit.Location = new Point(96, 445);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(459, 51);
            btnExit.TabIndex = 4;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 539);
            Controls.Add(btnExit);
            Controls.Add(btnshowfront);
            Controls.Add(btnshowback);
            Controls.Add(ptxfront);
            Controls.Add(ptxback);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxback).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxback;
        private PictureBox ptxfront;
        private Button btnshowback;
        private Button btnshowfront;
        private Button btnExit;
    }
}
