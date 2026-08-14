using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if(rdNam.Checked) 
                MessageBox.Show("Bạn chọn giới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
                MessageBox.Show("Bạn chọn giới tính Nữ", "Thông báo");
        }

        private void butToMau_Click(object sender, EventArgs e)
        {
            if(rdTrang.Checked)
                txtHopMau.BackColor = Color.White;
            else
                txtHopMau.BackColor = Color.Black;
        }

        private void txtHopMau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
