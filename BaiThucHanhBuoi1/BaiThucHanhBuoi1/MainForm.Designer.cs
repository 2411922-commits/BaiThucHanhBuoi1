namespace BaiThucHanhBuoi1
{
    partial class MainForm
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
            this.lbNhapTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.butOK = new System.Windows.Forms.Button();
            this.lbDaNhap = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.butSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNhapTen
            // 
            this.lbNhapTen.AutoSize = true;
            this.lbNhapTen.Location = new System.Drawing.Point(60, 35);
            this.lbNhapTen.Name = "lbNhapTen";
            this.lbNhapTen.Size = new System.Drawing.Size(115, 16);
            this.lbNhapTen.TabIndex = 0;
            this.lbNhapTen.Text = "Nhập tên của bạn:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(181, 32);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(188, 22);
            this.txtTen.TabIndex = 1;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // butOK
            // 
            this.butOK.Location = new System.Drawing.Point(181, 86);
            this.butOK.Name = "butOK";
            this.butOK.Size = new System.Drawing.Size(75, 23);
            this.butOK.TabIndex = 2;
            this.butOK.Text = "Xử lý";
            this.butOK.UseVisualStyleBackColor = true;
            this.butOK.Click += new System.EventHandler(this.butOK_Click);
            // 
            // lbDaNhap
            // 
            this.lbDaNhap.AutoSize = true;
            this.lbDaNhap.Location = new System.Drawing.Point(60, 162);
            this.lbDaNhap.Name = "lbDaNhap";
            this.lbDaNhap.Size = new System.Drawing.Size(86, 16);
            this.lbDaNhap.TabIndex = 3;
            this.lbDaNhap.Text = "Bạn đã nhập:";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(181, 159);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.ReadOnly = true;
            this.txtSaoChep.Size = new System.Drawing.Size(188, 22);
            this.txtSaoChep.TabIndex = 4;
            this.txtSaoChep.TextChanged += new System.EventHandler(this.txtSaoChep_TextChanged);
            // 
            // butSaoChep
            // 
            this.butSaoChep.Location = new System.Drawing.Point(181, 226);
            this.butSaoChep.Name = "butSaoChep";
            this.butSaoChep.Size = new System.Drawing.Size(75, 23);
            this.butSaoChep.TabIndex = 5;
            this.butSaoChep.Text = "Sao chép";
            this.butSaoChep.UseVisualStyleBackColor = true;
            this.butSaoChep.Click += new System.EventHandler(this.butSaoChep_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.butSaoChep);
            this.Controls.Add(this.lbDaNhap);
            this.Controls.Add(this.butOK);
            this.Controls.Add(this.lbNhapTen);
            this.Name = "MainForm";
            this.Text = "Chương trình đầu tiên";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNhapTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button butOK;
        private System.Windows.Forms.Label lbDaNhap;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button butSaoChep;
    }
}

