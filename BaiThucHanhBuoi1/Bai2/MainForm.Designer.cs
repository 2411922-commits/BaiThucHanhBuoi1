namespace Bai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdDen = new System.Windows.Forms.RadioButton();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.butToMau = new System.Windows.Forms.Button();
            this.txtHopMau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(124, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn giới tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(28, 78);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 1;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(28, 40);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 1;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butToMau);
            this.groupBox2.Controls.Add(this.rdDen);
            this.groupBox2.Controls.Add(this.rdTrang);
            this.groupBox2.Location = new System.Drawing.Point(124, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn màu";
            // 
            // rdDen
            // 
            this.rdDen.AutoSize = true;
            this.rdDen.Location = new System.Drawing.Point(28, 78);
            this.rdDen.Name = "rdDen";
            this.rdDen.Size = new System.Drawing.Size(80, 20);
            this.rdDen.TabIndex = 1;
            this.rdDen.TabStop = true;
            this.rdDen.Text = "Màu đen";
            this.rdDen.UseVisualStyleBackColor = true;
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Checked = true;
            this.rdTrang.Location = new System.Drawing.Point(28, 40);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(87, 20);
            this.rdTrang.TabIndex = 1;
            this.rdTrang.TabStop = true;
            this.rdTrang.Text = "Màu trắng";
            this.rdTrang.UseVisualStyleBackColor = true;
            // 
            // butToMau
            // 
            this.butToMau.Location = new System.Drawing.Point(164, 59);
            this.butToMau.Name = "butToMau";
            this.butToMau.Size = new System.Drawing.Size(75, 23);
            this.butToMau.TabIndex = 2;
            this.butToMau.Text = "Tô màu";
            this.butToMau.UseVisualStyleBackColor = true;
            this.butToMau.Click += new System.EventHandler(this.butToMau_Click);
            // 
            // txtHopMau
            // 
            this.txtHopMau.Location = new System.Drawing.Point(463, 217);
            this.txtHopMau.Multiline = true;
            this.txtHopMau.Name = "txtHopMau";
            this.txtHopMau.ReadOnly = true;
            this.txtHopMau.Size = new System.Drawing.Size(270, 126);
            this.txtHopMau.TabIndex = 2;
            this.txtHopMau.TextChanged += new System.EventHandler(this.txtHopMau_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHopMau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Bài tập 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdDen;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.Button butToMau;
        private System.Windows.Forms.TextBox txtHopMau;
    }
}

