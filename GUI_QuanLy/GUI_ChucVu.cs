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
    public partial class GUI_ChucVu : Form
    {
        BUS_ChucVu busCV = new BUS_ChucVu();
        public GUI_ChucVu()
        {
            InitializeComponent();
        }

        private void GUI_ChucVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet5.ChucVu' table. You can move, or remove it, as needed.
            this.chucVuTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet5.ChucVu);
            dgvChucVu.DataSource = busCV.getChucVu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIDCV.Text != "" && txtChucVu.Text != "" && txtTaiKhoan.Text != "")
            {
                // Tạo DTo
                DTO_ChucVu cv = new DTO_ChucVu(txtIDCV.Text, txtChucVu.Text, txtTaiKhoan.Text);

                // Them
                if (busCV.themChucVu(cv))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvChucVu.DataSource = busCV.getChucVu();
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
            if (dgvChucVu.SelectedRows.Count > 0)
            {
                if (txtIDCV.Text != "" && txtChucVu.Text != "" && txtTaiKhoan.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvChucVu.SelectedRows[0];


                    // Tạo DTo
                    DTO_ChucVu cv = new DTO_ChucVu(txtIDCV.Text, txtChucVu.Text, txtTaiKhoan.Text);

                    // Sửa
                    if (busCV.suaChucVu(cv))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvChucVu.DataSource = busCV.getChucVu();
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
            if (dgvChucVu.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvChucVu.SelectedRows[0];
                string IDCV = row.Cells[0].Value.ToString();

                // Xóa
                if (busCV.xoaChucVu(IDCV))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvChucVu.DataSource = busCV.getChucVu();
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

        private void dgvChucVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvChucVu.SelectedRows[0];

            // Chuyển giá trị lên form
            txtIDCV.Text = row.Cells[0].Value.ToString();
            txtChucVu.Text = row.Cells[1].Value.ToString();
            txtTaiKhoan.Text = row.Cells[2].Value.ToString();
        }
    }
}
