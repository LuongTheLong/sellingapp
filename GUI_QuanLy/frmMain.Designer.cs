namespace GUI_QuanLy
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTacVu = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chấtLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánChiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTacVu,
            this.mnuQuanLy,
            this.bánHàngToolStripMenuItem,
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1137, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTacVu
            // 
            this.mnuTacVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hàngHóaToolStripMenuItem,
            this.chấtLiệuToolStripMenuItem,
            this.kháchToolStripMenuItem});
            this.mnuTacVu.Name = "mnuTacVu";
            this.mnuTacVu.Size = new System.Drawing.Size(53, 20);
            this.mnuTacVu.Text = "&Tác vụ";
            // 
            // hàngHóaToolStripMenuItem
            // 
            this.hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            this.hàngHóaToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            this.hàngHóaToolStripMenuItem.Click += new System.EventHandler(this.hàngHóaToolStripMenuItem_Click);
            // 
            // chấtLiệuToolStripMenuItem
            // 
            this.chấtLiệuToolStripMenuItem.Name = "chấtLiệuToolStripMenuItem";
            this.chấtLiệuToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.chấtLiệuToolStripMenuItem.Text = "Chất liệu";
            this.chấtLiệuToolStripMenuItem.Click += new System.EventHandler(this.chấtLiệuToolStripMenuItem_Click);
            // 
            // kháchToolStripMenuItem
            // 
            this.kháchToolStripMenuItem.Name = "kháchToolStripMenuItem";
            this.kháchToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.kháchToolStripMenuItem.Text = "Khách";
            this.kháchToolStripMenuItem.Click += new System.EventHandler(this.kháchToolStripMenuItem_Click);
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.chứcVụToolStripMenuItem});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(62, 20);
            this.mnuQuanLy.Text = "&Quản Lý";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.chứcVụToolStripMenuItem.Text = "Chức vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnBánToolStripMenuItem,
            this.hóaĐơnBánChiTiếtToolStripMenuItem});
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.bánHàngToolStripMenuItem.Text = "&Bán hàng";
            // 
            // hóaĐơnBánToolStripMenuItem
            // 
            this.hóaĐơnBánToolStripMenuItem.Name = "hóaĐơnBánToolStripMenuItem";
            this.hóaĐơnBánToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.hóaĐơnBánToolStripMenuItem.Text = "Hóa đơn bán";
            this.hóaĐơnBánToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánToolStripMenuItem_Click);
            // 
            // hóaĐơnBánChiTiếtToolStripMenuItem
            // 
            this.hóaĐơnBánChiTiếtToolStripMenuItem.Name = "hóaĐơnBánChiTiếtToolStripMenuItem";
            this.hóaĐơnBánChiTiếtToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.hóaĐơnBánChiTiếtToolStripMenuItem.Text = "Hóa đơn bán chi tiết";
            this.hóaĐơnBánChiTiếtToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánChiTiếtToolStripMenuItem_Click);
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tùyChọnToolStripMenuItem.Text = "&Tùy chọn";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI_QuanLy.Properties.Resources.thiet_ke_phan_mem_quan_ly_ban_hang_1;
            this.ClientSize = new System.Drawing.Size(1137, 589);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTacVu;
        private System.Windows.Forms.ToolStripMenuItem hàngHóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chấtLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánChiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
    }
}