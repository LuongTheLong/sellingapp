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
    public partial class GUI_ChatLieu : Form
    {
        BUS_ChatLieu busCL = new BUS_ChatLieu();
        public GUI_ChatLieu()
        {
            InitializeComponent();
        }

        private void GUI_ChatLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet1.ChatLieu' table. You can move, or remove it, as needed.
            this.chatLieuTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet1.ChatLieu);
            dgvChatLieu.DataSource = busCL.getChatLieu();
            // TODO: This line of code loads data into the 'quan_Ly_Ban_HangDataSet.ChatLieu' table. You can move, or remove it, as needed.
            //this.chatLieuTableAdapter.Fill(this.quan_Ly_Ban_HangDataSet.ChatLieu);

        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtMaChatLieu.Text != "" && txtTenChatLieu.Text != "")
            {
                // Tạo DTo
                DTO_ChatLieu cl = new DTO_ChatLieu(txtMaChatLieu.Text, txtTenChatLieu.Text); 

                // Them
                if (busCL.themChatLieu(cl))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvChatLieu.DataSource = busCL.getChatLieu();
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
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvChatLieu.SelectedRows.Count > 0)
            {
                if (txtMaChatLieu.Text != "" && txtTenChatLieu.Text != "")
                {
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvChatLieu.SelectedRows[0];
                   //string MaChatLieu = (row.Cells[0].Value.ToString());

                    // Tạo DTo
                    DTO_ChatLieu cl = new DTO_ChatLieu(txtMaChatLieu.Text, txtTenChatLieu.Text); 

                    // Sửa
                    if (busCL.suaChatLieu(cl))
                    {
                        MessageBox.Show("Sửa thành công");
                        dgvChatLieu.DataSource = busCL.getChatLieu(); // refresh datagridview
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dgvChatLieu.SelectedRows.Count > 0)
            {

                // Lấy row hiện tại
                DataGridViewRow row = dgvChatLieu.SelectedRows[0];
                string MaChatLieu = row.Cells[0].Value.ToString();

                // Xóa
                if (busCL.xoaChatLieu(MaChatLieu))
                {
                    MessageBox.Show("Xóa thành công");
                    dgvChatLieu.DataSource = busCL.getChatLieu(); 
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

        private void dgvChatLieu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvChatLieu.SelectedRows[0];

            // Chuyển giá trị lên form
            txtMaChatLieu.Text = row.Cells[0].Value.ToString();
            txtTenChatLieu.Text = row.Cells[1].Value.ToString();
        }

    }
}
