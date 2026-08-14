using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void butOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;
            MessageBox.Show($"xin chào bạn {tenDaNhap}. Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void butSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtSaoChep_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
