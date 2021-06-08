namespace GUI_QuanLy
{
    partial class GUI_HoaDonBan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.txtNgayBan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.quan_Ly_Ban_HangDataSet7 = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet7();
            this.hoaDonBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoaDonBanTableAdapter = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet7TableAdapters.HoaDonBanTableAdapter();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(551, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 44);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKhach);
            this.groupBox1.Controls.Add(this.txtNgayBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaNhanVien);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 139);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn Bán";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(101, 108);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(280, 20);
            this.txtMaKhach.TabIndex = 6;
            // 
            // txtNgayBan
            // 
            this.txtNgayBan.Location = new System.Drawing.Point(101, 79);
            this.txtNgayBan.Name = "txtNgayBan";
            this.txtNgayBan.Size = new System.Drawing.Size(280, 20);
            this.txtNgayBan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(101, 47);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(280, 20);
            this.txtMaNhanVien.TabIndex = 1;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(101, 19);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(280, 20);
            this.txtMaHoaDon.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(417, 75);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 44);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(551, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 44);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(417, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 44);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.AutoGenerateColumns = false;
            this.dgvHoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.maNhanVienDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn,
            this.maKhachDataGridViewTextBoxColumn});
            this.dgvHoaDonBan.DataSource = this.hoaDonBanBindingSource;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(12, 157);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(776, 281);
            this.dgvHoaDonBan.TabIndex = 18;
            this.dgvHoaDonBan.Click += new System.EventHandler(this.dgvHoaDonBan_Click);
            // 
            // quan_Ly_Ban_HangDataSet7
            // 
            this.quan_Ly_Ban_HangDataSet7.DataSetName = "Quan_Ly_Ban_HangDataSet7";
            this.quan_Ly_Ban_HangDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBanBindingSource
            // 
            this.hoaDonBanBindingSource.DataMember = "HoaDonBan";
            this.hoaDonBanBindingSource.DataSource = this.quan_Ly_Ban_HangDataSet7;
            // 
            // hoaDonBanTableAdapter
            // 
            this.hoaDonBanTableAdapter.ClearBeforeFill = true;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "MaNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            // 
            // maKhachDataGridViewTextBoxColumn
            // 
            this.maKhachDataGridViewTextBoxColumn.DataPropertyName = "MaKhach";
            this.maKhachDataGridViewTextBoxColumn.HeaderText = "MaKhach";
            this.maKhachDataGridViewTextBoxColumn.Name = "maKhachDataGridViewTextBoxColumn";
            // 
            // GUI_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHoaDonBan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "GUI_HoaDonBan";
            this.Text = "GUI_HoaDonBan";
            this.Load += new System.EventHandler(this.GUI_HoaDonBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.TextBox txtNgayBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private Quan_Ly_Ban_HangDataSet7 quan_Ly_Ban_HangDataSet7;
        private System.Windows.Forms.BindingSource hoaDonBanBindingSource;
        private Quan_Ly_Ban_HangDataSet7TableAdapters.HoaDonBanTableAdapter hoaDonBanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachDataGridViewTextBoxColumn;
    }
}