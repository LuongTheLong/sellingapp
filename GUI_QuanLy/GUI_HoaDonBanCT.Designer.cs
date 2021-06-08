namespace GUI_QuanLy
{
    partial class GUI_HoaDonBanCT
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHoaDonBanCT = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBanCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quan_Ly_Ban_HangDataSet3 = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet3();
            this.hoaDonBanCTTableAdapter = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet3TableAdapters.HoaDonBanCTTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtGiamGia);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 239);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn bán chi tiết";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(418, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 44);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(284, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 44);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(150, 170);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 44);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 44);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(444, 71);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(303, 20);
            this.txtGiamGia.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(444, 29);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(303, 20);
            this.txtDonGia.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(78, 109);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(296, 20);
            this.txtSoLuong.TabIndex = 8;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(78, 71);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(296, 20);
            this.txtMaHang.TabIndex = 7;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(78, 29);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(296, 20);
            this.txtMaHoaDon.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giảm giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // dgvHoaDonBanCT
            // 
            this.dgvHoaDonBanCT.AutoGenerateColumns = false;
            this.dgvHoaDonBanCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonBanCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBanCT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.maHangDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.giamGiaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dgvHoaDonBanCT.DataSource = this.hoaDonBanCTBindingSource;
            this.dgvHoaDonBanCT.Location = new System.Drawing.Point(13, 259);
            this.dgvHoaDonBanCT.Name = "dgvHoaDonBanCT";
            this.dgvHoaDonBanCT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonBanCT.Size = new System.Drawing.Size(775, 179);
            this.dgvHoaDonBanCT.TabIndex = 1;
            this.dgvHoaDonBanCT.Click += new System.EventHandler(this.dgvHoaDonBanCT_Click);
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // giamGiaDataGridViewTextBoxColumn
            // 
            this.giamGiaDataGridViewTextBoxColumn.DataPropertyName = "GiamGia";
            this.giamGiaDataGridViewTextBoxColumn.HeaderText = "GiamGia";
            this.giamGiaDataGridViewTextBoxColumn.Name = "giamGiaDataGridViewTextBoxColumn";
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            // 
            // hoaDonBanCTBindingSource
            // 
            this.hoaDonBanCTBindingSource.DataMember = "HoaDonBanCT";
            this.hoaDonBanCTBindingSource.DataSource = this.quan_Ly_Ban_HangDataSet3;
            // 
            // quan_Ly_Ban_HangDataSet3
            // 
            this.quan_Ly_Ban_HangDataSet3.DataSetName = "Quan_Ly_Ban_HangDataSet3";
            this.quan_Ly_Ban_HangDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBanCTTableAdapter
            // 
            this.hoaDonBanCTTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_HoaDonBanCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHoaDonBanCT);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_HoaDonBanCT";
            this.Text = "GUI_HoaDonBanCT";
            this.Load += new System.EventHandler(this.GUI_HoaDonBanCT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvHoaDonBanCT;
        private Quan_Ly_Ban_HangDataSet3 quan_Ly_Ban_HangDataSet3;
        private System.Windows.Forms.BindingSource hoaDonBanCTBindingSource;
        private Quan_Ly_Ban_HangDataSet3TableAdapters.HoaDonBanCTTableAdapter hoaDonBanCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
    }
}