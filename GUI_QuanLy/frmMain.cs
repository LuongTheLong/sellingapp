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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }
        private string taikhoan;
        private string chucvu;

        private void hàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Hang a = new GUI_Hang();
            //f.MdiParent = this;
            a.Show();
        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChatLieu a = new GUI_ChatLieu();
            //f.MdiParent = this;
            a.Show();
        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Khach a = new GUI_Khach();
            //f.MdiParent = this;
            a.Show();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBanCT a = new GUI_HoaDonBanCT();
            //f.MdiParent = this;
            a.Show();
        }

        private void hóaĐơnBánChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_HoaDonBan a = new GUI_HoaDonBan();
            //f.MdiParent = this;
            a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(frmLogin.nhanvien == true)
            {
                mnuQuanLy.Visible = false;
            }
        }
   

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhanVien a = new GUI_NhanVien();
            //f.MdiParent = this;
            a.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Account a = new GUI_Account();
            //f.MdiParent = this;
            a.Show();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChucVu a = new GUI_ChucVu();
            a.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword a = new frmChangePassword();
            a.Show();
        }

        //private void tàiKhoảnToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
