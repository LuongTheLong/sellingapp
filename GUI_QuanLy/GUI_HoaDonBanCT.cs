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
    public partial class GUI_HoaDonBanCT : Form
    {
        BUS_HoaDonBanCT busHDBCT = new BUS_HoaDonBanCT();
        public GUI_HoaDonBanCT()
        {
            InitializeComponent();
        }

        private void GUI_HoaDonBanCT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet3.HoaDonBanCT' table. You can move, or remove it, as needed.
            this.hoaDonBanCTTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet3.HoaDonBanCT);
            dgvHoaDonBanCT.DataSource = busHDBCT.getHoaDonBanCT();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text != "" && txtMaHang.Text != "" && txtSoLuong.Text != "" && txtDonGia.Text != "" && txtGiamGia.Text != "")
            {
                float ThanhTien = 0;
                ThanhTien = (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text)) * (1 - Convert.ToSingle(txtGiamGia.Text) / 100 );
                // Tạo DTo
                DTO_HoaDonBanCT hdbct = new DTO_HoaDonBanCT(txtMaHoaDon.Text, txtMaHang.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text), Convert.ToSingle(txtGiamGia.Text), ThanhTien);

                // Them
                if (busHDBCT.themHoaDonBanCT(hdbct))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvHoaDonBanCT.DataSource = busHDBCT.getHoaDonBanCT();
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
            // Kiểm tra nếu có chọn table rồi
            if (dgvHoaDonBanCT.SelectedRows.Count > 0)
            {
                if (txtMaHoaDon.Text != "" && txtMaHang.Text != "" && txtSoLuong.Text != "" && txtDonGia.Text != "" && txtGiamGia.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvHoaDonBanCT.SelectedRows[0];
                    //string MaChatLieu = (row.Cells[0].Value.ToString());
                    float ThanhTien = 0;
                    ThanhTien = (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text)) * (1 - Convert.ToSingle(txtGiamGia.Text) / 100);
                    // Tạo DTo
                    DTO_HoaDonBanCT hdbct = new DTO_HoaDonBanCT(txtMaHoaDon.Text, txtMaHang.Text, Convert.ToInt32(txtSoLuong.Text), Convert.ToInt32(txtDonGia.Text), Convert.ToSingle(txtGiamGia.Text), ThanhTien);
                    // Sửa
                    if (busHDBCT.suaHoaDonBanCT(hdbct))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvHoaDonBanCT.DataSource = busHDBCT.getHoaDonBanCT(); // refresh datagridview
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
            // Kiểm tra nếu có chọn table rồi
            if (dgvHoaDonBanCT.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvHoaDonBanCT.SelectedRows[0];
                string MaHoaDon = row.Cells[0].Value.ToString();

                // Xóa
                if (busHDBCT.xoaHoaDonBanCT(MaHoaDon))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvHoaDonBanCT.DataSource = busHDBCT.getHoaDonBanCT();
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

        private void dgvHoaDonBanCT_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHoaDonBanCT.SelectedRows[0];

            // Chuyển giá trị lên form
            txtMaHoaDon.Text = row.Cells[0].Value.ToString();
            txtMaHang.Text = row.Cells[1].Value.ToString();
            txtSoLuong.Text = row.Cells[2].Value.ToString();
            txtDonGia.Text = row.Cells[3].Value.ToString();
            txtGiamGia.Text = row.Cells[4].Value.ToString();
        }
    }
}
