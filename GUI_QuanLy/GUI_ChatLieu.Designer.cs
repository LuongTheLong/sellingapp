namespace GUI_QuanLy
{
    partial class GUI_ChatLieu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenChatLieu = new System.Windows.Forms.TextBox();
            this.txtMaChatLieu = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvChatLieu = new System.Windows.Forms.DataGridView();
            this.maChatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChatLieuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quan_Ly_Ban_HangDataSet1 = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet1();
            this.chatLieuTableAdapter = new GUI_QuanLy.Quan_Ly_Ban_HangDataSet1TableAdapters.ChatLieuTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenChatLieu);
            this.groupBox1.Controls.Add(this.txtMaChatLieu);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chất Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Chất Liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Chất Liệu";
            // 
            // txtTenChatLieu
            // 
            this.txtTenChatLieu.Location = new System.Drawing.Point(101, 65);
            this.txtTenChatLieu.Name = "txtTenChatLieu";
            this.txtTenChatLieu.Size = new System.Drawing.Size(280, 20);
            this.txtTenChatLieu.TabIndex = 1;
            // 
            // txtMaChatLieu
            // 
            this.txtMaChatLieu.Location = new System.Drawing.Point(101, 19);
            this.txtMaChatLieu.Name = "txtMaChatLieu";
            this.txtMaChatLieu.Size = new System.Drawing.Size(280, 20);
            this.txtMaChatLieu.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 44);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(423, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 44);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(289, 132);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 44);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(155, 132);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 44);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // dgvChatLieu
            // 
            this.dgvChatLieu.AutoGenerateColumns = false;
            this.dgvChatLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChatLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChatLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maChatLieuDataGridViewTextBoxColumn,
            this.tenChatLieuDataGridViewTextBoxColumn});
            this.dgvChatLieu.DataSource = this.chatLieuBindingSource;
            this.dgvChatLieu.Location = new System.Drawing.Point(12, 192);
            this.dgvChatLieu.Name = "dgvChatLieu";
            this.dgvChatLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChatLieu.Size = new System.Drawing.Size(776, 246);
            this.dgvChatLieu.TabIndex = 9;
            this.dgvChatLieu.Click += new System.EventHandler(this.dgvChatLieu_Click);
            // 
            // maChatLieuDataGridViewTextBoxColumn
            // 
            this.maChatLieuDataGridViewTextBoxColumn.DataPropertyName = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.HeaderText = "MaChatLieu";
            this.maChatLieuDataGridViewTextBoxColumn.Name = "maChatLieuDataGridViewTextBoxColumn";
            // 
            // tenChatLieuDataGridViewTextBoxColumn
            // 
            this.tenChatLieuDataGridViewTextBoxColumn.DataPropertyName = "TenChatLieu";
            this.tenChatLieuDataGridViewTextBoxColumn.HeaderText = "TenChatLieu";
            this.tenChatLieuDataGridViewTextBoxColumn.Name = "tenChatLieuDataGridViewTextBoxColumn";
            // 
            // chatLieuBindingSource
            // 
            this.chatLieuBindingSource.DataMember = "ChatLieu";
            this.chatLieuBindingSource.DataSource = this.quan_Ly_Ban_HangDataSet1;
            // 
            // quan_Ly_Ban_HangDataSet1
            // 
            this.quan_Ly_Ban_HangDataSet1.DataSetName = "Quan_Ly_Ban_HangDataSet1";
            this.quan_Ly_Ban_HangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chatLieuTableAdapter
            // 
            this.chatLieuTableAdapter.ClearBeforeFill = true;
            // 
            // GUI_ChatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChatLieu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "GUI_ChatLieu";
            this.Text = "GUI_ChatLieu";
            this.Load += new System.EventHandler(this.GUI_ChatLieu_Load);
            this.Click += new System.EventHandler(this.dgvChatLieu_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChatLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quan_Ly_Ban_HangDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenChatLieu;
        private System.Windows.Forms.TextBox txtMaChatLieu;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvChatLieu;
        private Quan_Ly_Ban_HangDataSet1 quan_Ly_Ban_HangDataSet1;
        private System.Windows.Forms.BindingSource chatLieuBindingSource;
        private Quan_Ly_Ban_HangDataSet1TableAdapters.ChatLieuTableAdapter chatLieuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maChatLieuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChatLieuDataGridViewTextBoxColumn;
    }
}