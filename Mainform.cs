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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuly_Click(object sender, EventArgs e)
        {
            var tenDangNhap = txtbName.Text;
            MessageBox.Show($"hello bạn {tenDangNhap}.rất vui được gặp bạn","Thông điệp chào mừng");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDaNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            txtbName2.Text = txtbName.Text;
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbName2_TextChanged(object sender, EventArgs e)
        {
            txtbName2.Text = txtbName.Text;
        }
    }
}
