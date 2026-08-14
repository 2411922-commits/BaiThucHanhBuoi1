namespace BaiTapThietKeForm
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.butChonHang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.butBoHang = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butTinhTien = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.butChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 390);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hàng hóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím ",
            "Máy in",
            "USB Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(113, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 164);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // butChonHang
            // 
            this.butChonHang.Location = new System.Drawing.Point(310, 146);
            this.butChonHang.Name = "butChonHang";
            this.butChonHang.Size = new System.Drawing.Size(128, 29);
            this.butChonHang.TabIndex = 2;
            this.butChonHang.Text = "Chọn hàng >";
            this.butChonHang.UseVisualStyleBackColor = true;
            this.butChonHang.Click += new System.EventHandler(this.butChonHang_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbSoTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.butTinhTien);
            this.panel2.Controls.Add(this.butBoHang);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(476, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 390);
            this.panel2.TabIndex = 3;
            // 
            // butBoHang
            // 
            this.butBoHang.Location = new System.Drawing.Point(17, 146);
            this.butBoHang.Name = "butBoHang";
            this.butBoHang.Size = new System.Drawing.Size(128, 29);
            this.butBoHang.TabIndex = 2;
            this.butBoHang.Text = "< Bỏ hàng";
            this.butBoHang.UseVisualStyleBackColor = true;
            this.butBoHang.Click += new System.EventHandler(this.butBoHang_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(162, 77);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(178, 164);
            this.listBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Các mặt hàng khách đã mua";
            // 
            // butTinhTien
            // 
            this.butTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butTinhTien.Location = new System.Drawing.Point(232, 269);
            this.butTinhTien.Name = "butTinhTien";
            this.butTinhTien.Size = new System.Drawing.Size(108, 34);
            this.butTinhTien.TabIndex = 3;
            this.butTinhTien.Text = "Tính tiền";
            this.butTinhTien.UseVisualStyleBackColor = true;
            this.butTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền thanh toán";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.ForeColor = System.Drawing.Color.Blue;
            this.lbSoTien.Location = new System.Drawing.Point(227, 336);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(23, 25);
            this.lbSoTien.TabIndex = 5;
            this.lbSoTien.Text = "0";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 431);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button butBoHang;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butChonHang;
        private System.Windows.Forms.Button butTinhTien;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label label3;
    }
}