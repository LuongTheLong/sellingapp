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
    public partial class GUI_Khach : Form
    {
        BUS_Khach busKH = new BUS_Khach();
        public GUI_Khach()
        {
            InitializeComponent();
        }

        private void GUI_Khach_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet2.Khach' table. You can move, or remove it, as needed.
            this.khachTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet2.Khach);
            dgvKhach.DataSource = busKH.getKhach();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaKhach.Text != "" && txtTenKhach.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "")
            {
                // Tạo DTo
                DTO_Khach kh = new DTO_Khach(txtMaKhach.Text, txtTenKhach.Text, txtDiaChi.Text, txtDienThoai.Text);

                // Them
                if (busKH.themKhach(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvKhach.DataSource = busKH.getKhach();
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
            if (dgvKhach.SelectedRows.Count > 0)
            {
                if (txtMaKhach.Text != "" && txtTenKhach.Text != "" && txtDiaChi.Text != "" && txtDienThoai.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvKhach.SelectedRows[0];
                    //string MaChatLieu = (row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_Khach kh = new DTO_Khach(txtMaKhach.Text, txtTenKhach.Text, txtDiaChi.Text, txtDienThoai.Text);

                    // Sửa
                    if (busKH.suaKhach(kh))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvKhach.DataSource = busKH.getKhach(); // refresh datagridview
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
            if (dgvKhach.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvKhach.SelectedRows[0];
                string MaKhach = row.Cells[0].Value.ToString();

                // Xóa
                if (busKH.xoaKhach(MaKhach))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvKhach.DataSource = busKH.getKhach();
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

        private void dgvKhach_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvKhach.SelectedRows[0];

            // Chuyển giá trị lên form
            txtMaKhach.Text = row.Cells[0].Value.ToString();
            txtTenKhach.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            txtDienThoai.Text = row.Cells[3].Value.ToString();
        }
    }
}
