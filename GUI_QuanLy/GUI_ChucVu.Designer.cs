namespace GUI_QuanLy
{
    partial class GUI_ChucVu
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
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtIDCV = new System.Windows.Forms.TextBox();
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.iDCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taiKhoanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quan_Ly_Ban_HangDataSet5 = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet5();
            this.chucVuTableAdapter = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet5TableAdapters.ChucVuTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(414, 129);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 44);
            this.btnExit.TabIndex = 21;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(280, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 44);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(146, 129);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 44);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 129);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 44);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtIDCV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 111);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Chức vụ";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(102, 75);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(280, 20);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IDCV";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(101, 46);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(280, 20);
            this.txtChucVu.TabIndex = 1;
            // 
            // txtIDCV
            // 
            this.txtIDCV.Location = new System.Drawing.Point(101, 19);
            this.txtIDCV.Name = "txtIDCV";
            this.txtIDCV.Size = new System.Drawing.Size(280, 20);
            this.txtIDCV.TabIndex = 0;
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.AutoGenerateColumns = false;
            this.dgvChucVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDCVDataGridViewTextBoxColumn,
            this.tenChucVuDataGridViewTextBoxColumn,
            this.taiKhoanDataGridViewTextBoxColumn});
            this.dgvChucVu.DataSource = this.chucVuBindingSource;
            this.dgvChucVu.Location = new System.Drawing.Point(12, 180);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChucVu.Size = new System.Drawing.Size(776, 258);
            this.dgvChucVu.TabIndex = 22;
            this.dgvChucVu.Click += new System.EventHandler(this.dgvChucVu_Click);
            // 
            // iDCVDataGridViewTextBoxColumn
            // 
            this.iDCVDataGridViewTextBoxColumn.DataPropertyName = "IDCV";
            this.iDCVDataGridViewTextBoxColumn.HeaderText = "IDCV";
            this.iDCVDataGridViewTextBoxColumn.Name = "iDCVDataGridViewTextBoxColumn";
            // 
            // tenChucVuDataGridViewTextBoxColumn
            // 
            this.tenChucVuDataGridViewTextBoxColumn.DataPropertyName = "TenChucVu";
            this.tenChucVuDataGridViewTextBoxColumn.HeaderText = "TenChucVu";
            this.tenChucVuDataGridViewTextBoxColumn.Name = "tenChucVuDataGridViewTextBoxColumn";
            // 
            // taiKhoanDataGridViewTextBoxColumn
            // 
            this.taiKhoanDataGridViewTextBoxColumn.DataPropertyName = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.HeaderText = "TaiKhoan";
            this.taiKhoanDataGridViewTextBoxColumn.Name = "taiKhoanDataGridViewTextBoxColumn";
            // 
            // chucVuBindingSource
            // 
            this.chucVuBindingSource.DataMember = "ChucVu";
            this.chucVuBindingSource.DataSource = this.quan_Ly_Ban_HangDataSet5;
            // 
            // quan_Ly_Ban_HangDataSet5
            // 
            this.quan_Ly_Ban_HangDataSet5.DataSetName = "Quan_Ly_Ban_HangDataSet5";
            this.quan_Ly_Ban_HangDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chucVuTableAdapter
            // 
            this.chucVuTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_ChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChucVu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_ChucVu";
            this.Text = "GUI_ChucVu";
            this.Load += new System.EventHandler(this.GUI_ChucVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtIDCV;
        private System.Windows.Forms.DataGridView dgvChucVu;
        private Quan_Ly_Ban_HangDataSet5 quan_Ly_Ban_HangDataSet5;
        private System.Windows.Forms.BindingSource chucVuBindingSource;
        private Quan_Ly_Ban_HangDataSet5TableAdapters.ChucVuTableAdapter chucVuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoanDataGridViewTextBoxColumn;
    }
}