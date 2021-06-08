using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != "" && txtMatKhauMoi.Text != "" && txtXNMatKhauMoi.Text != "" & txtMaNhanVien.Text != "")
            {
                if (!((txtMatKhauMoi.Text).Equals(txtXNMatKhauMoi.Text)))
                {
                    MessageBox.Show("Xác nhận mật khẩu không trùng với mật khẩu mới!!!");
                }
                else
                {
                    if (BUS_ChangePassword.xacnhanmatkhau(txtMatKhauCu.Text, txtMaNhanVien.Text))
                    {
                        if (BUS_ChangePassword.doimatkhau(txtMatKhauMoi.Text, txtMaNhanVien.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            MessageBox.Show("Đổi thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy kiểm tra lại mật khẩu và mã nhân viên !!!");
                    }

                }

            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
            Clear();
        }
        private void Clear()
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtXNMatKhauMoi.Text = "";
            txtMaNhanVien.Text = "";
            txtMatKhauCu.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
