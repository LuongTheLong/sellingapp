using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QuanLy;
using BUS_QuanLy;

namespace GUI_QuanLy
{
    public partial class frmLogin : Form
    {
        public string taikhoan = "";
        public string chucvu;
        public static string MANHANVIEN = "";
        public static bool nhanvien = false; // admin
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            #region ktra_rbuoc
            //kiểm tra ràng buộc
            if (cbbChucVu.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Tài khoản không được để trống");
                txtTaiKhoan.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống");
                txtMatKhau.Select();
                return;
            }
            #endregion

            taikhoan = txtTaiKhoan.Text;
            chucvu = "";

            #region swtk
            switch (cbbChucVu.Text)
            {
                case "ADMIN":
                    chucvu = "ADMIN";
                    break;
                case "MEMBER":
                    chucvu = "MEMBER"; nhanvien = true;
                    break;
            }
            #endregion
            
            MANHANVIEN = BUS_Login.dangnhap(txtTaiKhoan.Text, txtMatKhau.Text, cbbChucVu.Text);
            if (MANHANVIEN != "")
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hãy kiểm tra kỹ lại !");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
