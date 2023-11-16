namespace QuanLyMiCay.frm
{
    partial class frmQuanLyThucAn
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
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.MaThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiThucAn = new System.Windows.Forms.ComboBox();
            this.txtGiaThucAn = new System.Windows.Forms.TextBox();
            this.txtTenThucAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaThucAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThucAn,
            this.TenThucAn,
            this.GiaThucAn,
            this.TenLoaiThucAn});
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 18);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.Size = new System.Drawing.Size(584, 445);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick_1);
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // MaThucAn
            // 
            this.MaThucAn.DataPropertyName = "MaThucAn";
            this.MaThucAn.HeaderText = "Mã";
            this.MaThucAn.MinimumWidth = 6;
            this.MaThucAn.Name = "MaThucAn";
            // 
            // TenThucAn
            // 
            this.TenThucAn.DataPropertyName = "TenThucAn";
            this.TenThucAn.HeaderText = "Tên";
            this.TenThucAn.MinimumWidth = 6;
            this.TenThucAn.Name = "TenThucAn";
            // 
            // GiaThucAn
            // 
            this.GiaThucAn.DataPropertyName = "GiaThucAn";
            this.GiaThucAn.HeaderText = "Giá";
            this.GiaThucAn.MinimumWidth = 6;
            this.GiaThucAn.Name = "GiaThucAn";
            // 
            // TenLoaiThucAn
            // 
            this.TenLoaiThucAn.DataPropertyName = "TenLoaiThucAn";
            this.TenLoaiThucAn.HeaderText = "Loại";
            this.TenLoaiThucAn.MinimumWidth = 6;
            this.TenLoaiThucAn.Name = "TenLoaiThucAn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLoaiThucAn);
            this.groupBox1.Controls.Add(this.txtGiaThucAn);
            this.groupBox1.Controls.Add(this.txtTenThucAn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaThucAn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 466);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbLoaiThucAn
            // 
            this.cbLoaiThucAn.FormattingEnabled = true;
            this.cbLoaiThucAn.Location = new System.Drawing.Point(6, 146);
            this.cbLoaiThucAn.Name = "cbLoaiThucAn";
            this.cbLoaiThucAn.Size = new System.Drawing.Size(247, 24);
            this.cbLoaiThucAn.TabIndex = 2;
            // 
            // txtGiaThucAn
            // 
            this.txtGiaThucAn.Enabled = false;
            this.txtGiaThucAn.Location = new System.Drawing.Point(9, 309);
            this.txtGiaThucAn.Name = "txtGiaThucAn";
            this.txtGiaThucAn.Size = new System.Drawing.Size(244, 22);
            this.txtGiaThucAn.TabIndex = 1;
            // 
            // txtTenThucAn
            // 
            this.txtTenThucAn.Enabled = false;
            this.txtTenThucAn.Location = new System.Drawing.Point(9, 227);
            this.txtTenThucAn.Name = "txtTenThucAn";
            this.txtTenThucAn.Size = new System.Drawing.Size(244, 22);
            this.txtTenThucAn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thức ăn";
            // 
            // txtMaThucAn
            // 
            this.txtMaThucAn.Enabled = false;
            this.txtMaThucAn.Location = new System.Drawing.Point(6, 67);
            this.txtMaThucAn.Name = "txtMaThucAn";
            this.txtMaThucAn.Size = new System.Drawing.Size(247, 22);
            this.txtMaThucAn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại thức ăn";
            // 
            // lbel1
            // 
            this.lbel1.AutoSize = true;
            this.lbel1.Location = new System.Drawing.Point(6, 38);
            this.lbel1.Name = "lbel1";
            this.lbel1.Size = new System.Drawing.Size(71, 16);
            this.lbel1.TabIndex = 0;
            this.lbel1.Text = "Mã thức ăn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(272, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 466);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 25);
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
            this.btnXoa.Location = new System.Drawing.Point(6, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(158, 42);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(6, 238);
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
            this.btnSua.Location = new System.Drawing.Point(6, 170);
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
            this.groupBox3.Location = new System.Drawing.Point(457, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 466);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // frmQuanLyThucAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 479);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmQuanLyThucAn";
            this.Text = "frmQuanLyThucAn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaThucAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGiaThucAn;
        private System.Windows.Forms.TextBox txtTenThucAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoaiThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThucAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucAn;
    }
}