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
    public partial class GUI_HoaDonBan : Form
    {
        BUS_HoaDonBan busHDB = new BUS_HoaDonBan();
        public GUI_HoaDonBan()
        {
            InitializeComponent();
        }

        private void GUI_HoaDonBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet7.HoaDonBan' table. You can move, or remove it, as needed.
            this.hoaDonBanTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet7.HoaDonBan);
            dgvHoaDonBan.DataSource = busHDB.getHoaDonBan();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text != "" && txtMaNhanVien.Text != "" && txtNgayBan.Text != "" && txtMaKhach.Text != "" )
            {
                // Tạo DTo
                DTO_HoaDonBan cl = new DTO_HoaDonBan(txtMaHoaDon.Text, txtMaNhanVien.Text, txtNgayBan.Text, txtMaKhach.Text);

                // Them
                if (busHDB.themHoaDonBan(cl))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvHoaDonBan.DataSource = busHDB.getHoaDonBan();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.SelectedRows.Count > 0)
            {
                if (txtMaHoaDon.Text != "" && txtMaNhanVien.Text != "" && txtNgayBan.Text != "" && txtMaKhach.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvHoaDonBan.SelectedRows[0];
                    DTO_HoaDonBan cl = new DTO_HoaDonBan(txtMaHoaDon.Text, txtMaNhanVien.Text, txtNgayBan.Text, txtMaKhach.Text);

                    // Sửa
                    if (busHDB.suaHoaDonBan(cl))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvHoaDonBan.DataSource = busHDB.getHoaDonBan();
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
            if (dgvHoaDonBan.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvHoaDonBan.SelectedRows[0];
                string MaHoaDon = row.Cells[0].Value.ToString();

                // Xóa
                if (busHDB.xoaHoaDonBan(MaHoaDon))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHoaDonBan.DataSource = busHDB.getHoaDonBan();
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

        private void dgvHoaDonBan_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHoaDonBan.SelectedRows[0];

            // Chuyển giá trị lên form
            txtMaHoaDon.Text = row.Cells[0].Value.ToString();
            txtMaNhanVien.Text = row.Cells[1].Value.ToString();
            txtNgayBan.Text = row.Cells[2].Value.ToString();
            txtMaKhach.Text = row.Cells[3].Value.ToString();
        }
    }
}
