using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "21000";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "22000";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdTrang_CheckedChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = "20000";
        }

        private void butTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = int.Parse (txtDonGia.Text) * int.Parse (txtSoLuong.Text);
            lbSoTien.Text = soTien.ToString ();
        }
    }
}
