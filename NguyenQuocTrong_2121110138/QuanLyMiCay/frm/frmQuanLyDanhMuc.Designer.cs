namespace QuanLyMiCay.frm
{
    partial class frmQuanLyDanhMuc
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaLoaiThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiThucAn = new System.Windows.Forms.TextBox();
            this.txtMaLoaiThucAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiThucAn,
            this.TenLoaiThucAn});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(537, 439);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // MaLoaiThucAn
            // 
            this.MaLoaiThucAn.DataPropertyName = "MaLoaiThucAn";
            this.MaLoaiThucAn.HeaderText = "Mã loại";
            this.MaLoaiThucAn.MinimumWidth = 6;
            this.MaLoaiThucAn.Name = "MaLoaiThucAn";
            // 
            // TenLoaiThucAn
            // 
            this.TenLoaiThucAn.DataPropertyName = "TenLoaiThucAn";
            this.TenLoaiThucAn.HeaderText = "Tên loại";
            this.TenLoaiThucAn.MinimumWidth = 6;
            this.TenLoaiThucAn.Name = "TenLoaiThucAn";
            // 
            // grbox
            // 
            this.grbox.Controls.Add(this.txtTenLoaiThucAn);
            this.grbox.Controls.Add(this.txtMaLoaiThucAn);
            this.grbox.Controls.Add(this.label2);
            this.grbox.Controls.Add(this.lbel1);
            this.grbox.Location = new System.Drawing.Point(12, 15);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(277, 460);
            this.grbox.TabIndex = 3;
            this.grbox.TabStop = false;
            this.grbox.Text = "Thông tin";
            // 
            // txtTenLoaiThucAn
            // 
            this.txtTenLoaiThucAn.Enabled = false;
            this.txtTenLoaiThucAn.Location = new System.Drawing.Point(9, 149);
            this.txtTenLoaiThucAn.Name = "txtTenLoaiThucAn";
            this.txtTenLoaiThucAn.Size = new System.Drawing.Size(244, 22);
            this.txtTenLoaiThucAn.TabIndex = 1;
            // 
            // txtMaLoaiThucAn
            // 
            this.txtMaLoaiThucAn.Enabled = false;
            this.txtMaLoaiThucAn.Location = new System.Drawing.Point(6, 67);
            this.txtMaLoaiThucAn.Name = "txtMaLoaiThucAn";
            this.txtMaLoaiThucAn.Size = new System.Drawing.Size(247, 22);
            this.txtMaLoaiThucAn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại thức ăn";
            // 
            // lbel1
            // 
            this.lbel1.AutoSize = true;
            this.lbel1.Location = new System.Drawing.Point(6, 38);
            this.lbel1.Name = "lbel1";
            this.lbel1.Size = new System.Drawing.Size(96, 16);
            this.lbel1.TabIndex = 0;
            this.lbel1.Text = "Mã loại thức ăn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(295, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 460);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(21, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(158, 42);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(21, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(158, 42);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(21, 237);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(158, 42);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(21, 165);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(158, 42);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sữa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(501, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 460);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 479);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQuanLyDanhMuc";
            this.Text = "frmQuanLyDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.TextBox txtTenLoaiThucAn;
        private System.Windows.Forms.TextBox txtMaLoaiThucAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucAn;
    }
}