using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien busNV = new BUS_NhanVien();
        public GUI_NhanVien()
        {
            InitializeComponent();
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet6.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet6.NhanVien);
            dgvNhanVien.DataSource = busNV.getNhanVien();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                string MaNhanVien = row.Cells[0].Value.ToString();

                // Xóa
                if (busNV.xoaNhanVien(MaNhanVien))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvNhanVien.DataSource = busNV.getNhanVien();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
                // Tạo DTo
                if (txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "" && txtChucVu.Text != "" && txtGioiTinh.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "" && txtNgaySinh.Text != "")
                {
                    // Tạo DTo
                    DTO_NhanVien nv = new DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtChucVu.Text, txtGioiTinh.Text, txtDiaChi.Text, txtDienThoai.Text, txtNgaySinh.Text);

                    // Them
                    if (busNV.themNhanVien(nv))
                    {
                        MessageBox.Show("Thêm thành công");
                        dgvNhanVien.DataSource = busNV.getNhanVien();
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

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.SelectedRows[0];

            // Chuyển giá trị lên form
            txtMaNhanVien.Text = row.Cells[0].Value.ToString();
            txtTenNhanVien.Text = row.Cells[1].Value.ToString();
            txtChucVu.Text = row.Cells[2].Value.ToString();
            txtGioiTinh.Text = row.Cells[3].Value.ToString();
            txtDiaChi.Text = row.Cells[4].Value.ToString();
            txtDienThoai.Text = row.Cells[5].Value.ToString();
            txtNgaySinh.Text = row.Cells[6].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                if (txtMaNhanVien.Text != "" && txtTenNhanVien.Text != "" && txtChucVu.Text != "" && txtGioiTinh.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "" && txtNgaySinh.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvNhanVien.SelectedRows[0];
                    DTO_NhanVien cl = new DTO_NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtChucVu.Text, txtGioiTinh.Text, txtDiaChi.Text, txtDienThoai.Text, txtNgaySinh.Text);

                    // Sửa
                    if (busNV.suaNhanVien(cl))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvNhanVien.DataSource = busNV.getNhanVien();
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
    }
}
