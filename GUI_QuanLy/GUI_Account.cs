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
    public partial class GUI_Account : Form
    {
        BUS_Account busAC = new BUS_Account();
        public GUI_Account()
        {
            InitializeComponent();
        }

        private void GUI_Account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet4.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet4.Account);
            dgvAccount.DataSource = busAC.getAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                // Tạo DTo
                DTO_Account ac = new DTO_Account(txtTaiKhoan.Text, txtMatKhau.Text, txtMaNhanVien.Text);

                // Them
                if (busAC.themAccount(ac))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvAccount.DataSource = busAC.getAccount();
                }
                else
                {
                    MessageBox.Show("Thêm ko thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập đầy đủ");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvAccount.SelectedRows[0];
                    DTO_Account ac = new DTO_Account(txtTaiKhoan.Text, txtMatKhau.Text, txtMaNhanVien.Text);

                    // Sửa
                    if (busAC.suaAccount(ac))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvAccount.DataSource = busAC.getAccount();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvAccount.SelectedRows[0];
                string MaNhanVien = row.Cells[2].Value.ToString();

                // Xóa
                if (busAC.xoaAccount(MaNhanVien))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvAccount.DataSource = busAC.getAccount();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAccount_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvAccount.SelectedRows[0];

            // Chuyển giá trị lên form
            txtTaiKhoan.Text = row.Cells[0].Value.ToString();
            txtMatKhau.Text = row.Cells[1].Value.ToString();
            txtMaNhanVien.Text = row.Cells[2].Value.ToString();
        }
    }
}
