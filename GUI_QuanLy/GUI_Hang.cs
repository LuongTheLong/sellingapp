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
using DTO_QuanLy;

namespace GUI_QuanLy
{
    public partial class GUI_Hang : Form
    {
        BUS_Hang busH = new BUS_Hang();
        public GUI_Hang()
        {
            InitializeComponent();
        }

        private void GUI_Hang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet8.Hang' table. You can move, or remove it, as needed.
            this.hangTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet8.Hang);
            dgvHang.DataSource = busH.getHang();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text != "" && txtMaChatLieu.Text != "" && txtTenHang.Text != "" && txtSoLuong.Text != "" && txtDonGiaNhap.Text != "" && txtDonGiaBan.Text != "")
            {
                // Tạo DTo
                DTO_Hang h = new DTO_Hang(txtMaHang.Text, txtMaChatLieu.Text, txtTenHang.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGiaNhap.Text), Convert.ToInt32(txtDonGiaBan.Text), txtGhiChu.Text);

                // Them
                if (busH.themHang(h))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvHang.DataSource = busH.getHang();
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
            if (dgvHang.SelectedRows.Count > 0)
            {
                if (txtMaHang.Text != "" && txtMaChatLieu.Text != "" && txtTenHang.Text != "" && txtSoLuong.Text != "" && txtDonGiaNhap.Text != "" && txtDonGiaBan.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvHang.SelectedRows[0];
                    // string MaChatLieu = (row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_Hang h = new DTO_Hang(txtMaHang.Text, txtMaChatLieu.Text, txtTenHang.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGiaNhap.Text), Convert.ToInt32(txtDonGiaBan.Text), txtGhiChu.Text);

                    // Sửa
                    if (busH.suaHang(h))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvHang.DataSource = busH.getHang();
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
            if (dgvHang.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvHang.SelectedRows[0];
                string MaHang = row.Cells[0].Value.ToString();

                // Xóa
                if (busH.xoaHang(MaHang))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHang.DataSource = busH.getHang();
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

        private void dgvHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHang.SelectedRows[0];

            // Chuyển giá trị lên form
            txtMaHang.Text = row.Cells[0].Value.ToString();
            txtMaChatLieu.Text = row.Cells[1].Value.ToString();
            txtTenHang.Text = row.Cells[2].Value.ToString();
            txtSoLuong.Text = row.Cells[3].Value.ToString();
            txtDonGiaNhap.Text = row.Cells[4].Value.ToString();
            txtDonGiaBan.Text = row.Cells[5].Value.ToString();
            txtGhiChu.Text = row.Cells[6].Value.ToString();
        }
    }
}
