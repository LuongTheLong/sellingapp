namespace GUI_QuanLy
{
    partial class GUI_Hang
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.quan_Ly_Ban_HangDataSet8 = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet8();
            this.hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangTableAdapter = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet8TableAdapters.HangTableAdapter();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maChatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(662, 138);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 30);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(455, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 30);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(243, 138);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 30);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(46, 138);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtDonGiaBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDonGiaNhap);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaChatLieu);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 111);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ghi Chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(580, 19);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(163, 76);
            this.txtGhiChu.TabIndex = 10;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(368, 76);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(134, 20);
            this.txtDonGiaBan.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Đơn Giá Bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Đơn Giá Nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Lượng";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(368, 47);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(134, 20);
            this.txtDonGiaNhap.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(368, 20);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(134, 20);
            this.txtSoLuong.TabIndex = 4;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(102, 75);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(134, 20);
            this.txtTenHang.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Chất Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hàng";
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(101, 46);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(134, 20);
            this.txtMaChatLieu.TabIndex = 1;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(101, 19);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(134, 20);
            this.txtMaHang.TabIndex = 0;
            // 
            // dgvHang
            // 
            this.dgvHang.AutoGenerateColumns = false;
            this.dgvHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.maChatLieuDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaNhapDataGridViewTextBoxColumn,
            this.donGiaBanDataGridViewTextBoxColumn,
            this.ghiChuDataGridViewTextBoxColumn});
            this.dgvHang.DataSource = this.hangBindingSource;
            this.dgvHang.Location = new System.Drawing.Point(12, 174);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHang.Size = new System.Drawing.Size(776, 264);
            this.dgvHang.TabIndex = 22;
            this.dgvHang.Click += new System.EventHandler(this.dgvHang_Click);
            // 
            // quan_Ly_Ban_HangDataSet8
            // 
            this.quan_Ly_Ban_HangDataSet8.DataSetName = "Quan_Ly_Ban_HangDataSet8";
            this.quan_Ly_Ban_HangDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangBindingSource
            // 
            this.hangBindingSource.DataMember = "Hang";
            this.hangBindingSource.DataSource = this.quan_Ly_Ban_HangDataSet8;
            // 
            // hangTableAdapter
            // 
            this.hangTableAdapter.ClearBeforeFill = true;
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            // 
            // maChatLieuDataGridViewTextBoxColumn
            // 
            this.maChatLieuDataGridViewTextBoxColumn.DataPropertyName = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.HeaderText = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.Name = "maChatLieuDataGridViewTextBoxColumn";
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donGiaNhapDataGridViewTextBoxColumn
            // 
            this.donGiaNhapDataGridViewTextBoxColumn.DataPropertyName = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.HeaderText = "DonGiaNhap";
            this.donGiaNhapDataGridViewTextBoxColumn.Name = "donGiaNhapDataGridViewTextBoxColumn";
            // 
            // donGiaBanDataGridViewTextBoxColumn
            // 
            this.donGiaBanDataGridViewTextBoxColumn.DataPropertyName = "DonGiaBan";
            this.donGiaBanDataGridViewTextBoxColumn.HeaderText = "DonGiaBan";
            this.donGiaBanDataGridViewTextBoxColumn.Name = "donGiaBanDataGridViewTextBoxColumn";
            // 
            // ghiChuDataGridViewTextBoxColumn
            // 
            this.ghiChuDataGridViewTextBoxColumn.DataPropertyName = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.HeaderText = "GhiChu";
            this.ghiChuDataGridViewTextBoxColumn.Name = "ghiChuDataGridViewTextBoxColumn";
            // 
            // GUI_Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_Hang";
            this.Text = "GUI_Hang";
            this.Load += new System.EventHandler(this.GUI_Hang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.DataGridView dgvHang;
        private Quan_Ly_Ban_HangDataSet8 quan_Ly_Ban_HangDataSet8;
        private System.Windows.Forms.BindingSource hangBindingSource;
        private Quan_Ly_Ban_HangDataSet8TableAdapters.HangTableAdapter hangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChatLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChuDataGridViewTextBoxColumn;
    }
}