namespace QuanLyMiCay.frm
{
    partial class frmTrangChu
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
            System.Windows.Forms.Button btnDongUngDung;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.btnQuanLyThucAn = new System.Windows.Forms.Button();
            this.btnQuanLyBanAn = new System.Windows.Forms.Button();
            this.btnQuanLyHoaDon = new System.Windows.Forms.Button();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.btnQuanLyBanHang = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.btnChiTietTaiKhoan = new System.Windows.Forms.PictureBox();
            btnDongUngDung = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTietTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(btnDongUngDung);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnChiTietTaiKhoan);
            this.groupBox1.Controls.Add(this.lblTenTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(-130, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 303);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox2";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(13, 108);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(110, 26);
            this.lblTenTaiKhoan.TabIndex = 0;
            this.lblTenTaiKhoan.Text = "Tài Khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(293, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuanLyTaiKhoan);
            this.groupBox2.Controls.Add(this.btnQuanLyThucAn);
            this.groupBox2.Controls.Add(this.btnQuanLyBanAn);
            this.groupBox2.Controls.Add(this.btnQuanLyHoaDon);
            this.groupBox2.Controls.Add(this.btnQuanLyDanhMuc);
            this.groupBox2.Controls.Add(this.btnQuanLyBanHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng quản lý";
            // 
            // btnQuanLyTaiKhoan
            // 
            this.btnQuanLyTaiKhoan.BackColor = System.Drawing.Color.Cyan;
            this.btnQuanLyTaiKhoan.Enabled = false;
            this.btnQuanLyTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyTaiKhoan.Location = new System.Drawing.Point(908, 22);
            this.btnQuanLyTaiKhoan.Name = "btnQuanLyTaiKhoan";
            this.btnQuanLyTaiKhoan.Size = new System.Drawing.Size(153, 50);
            this.btnQuanLyTaiKhoan.TabIndex = 0;
            this.btnQuanLyTaiKhoan.Text = "Tài Khoản";
            this.btnQuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.btnQuanLyTaiKhoan.Click += new System.EventHandler(this.btnQuanLyTaiKhoan_Click);
            // 
            // btnQuanLyThucAn
            // 
            this.btnQuanLyThucAn.BackColor = System.Drawing.Color.Cyan;
            this.btnQuanLyThucAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyThucAn.Location = new System.Drawing.Point(543, 22);
            this.btnQuanLyThucAn.Name = "btnQuanLyThucAn";
            this.btnQuanLyThucAn.Size = new System.Drawing.Size(153, 50);
            this.btnQuanLyThucAn.TabIndex = 0;
            this.btnQuanLyThucAn.Text = "Thức Ăn";
            this.btnQuanLyThucAn.UseVisualStyleBackColor = false;
            this.btnQuanLyThucAn.Click += new System.EventHandler(this.btnQuanLyThucAn_Click);
            // 
            // btnQuanLyBanAn
            // 
            this.btnQuanLyBanAn.BackColor = System.Drawing.Color.Cyan;
            this.btnQuanLyBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBanAn.Location = new System.Drawing.Point(362, 22);
            this.btnQuanLyBanAn.Name = "btnQuanLyBanAn";
            this.btnQuanLyBanAn.Size = new System.Drawing.Size(153, 50);
            this.btnQuanLyBanAn.TabIndex = 0;
            this.btnQuanLyBanAn.Text = "Bàn Ăn";
            this.btnQuanLyBanAn.UseVisualStyleBackColor = false;
            this.btnQuanLyBanAn.Click += new System.EventHandler(this.btnQuanLyBanAn_Click);
            // 
            // btnQuanLyHoaDon
            // 
            this.btnQuanLyHoaDon.BackColor = System.Drawing.Color.Cyan;
            this.btnQuanLyHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyHoaDon.Location = new System.Drawing.Point(722, 22);
            this.btnQuanLyHoaDon.Name = "btnQuanLyHoaDon";
            this.btnQuanLyHoaDon.Size = new System.Drawing.Size(153, 50);
            this.btnQuanLyHoaDon.TabIndex = 0;
            this.btnQuanLyHoaDon.Text = "Hóa Đơn";
            this.btnQuanLyHoaDon.UseVisualStyleBackColor = false;
            this.btnQuanLyHoaDon.Click += new System.EventHandler(this.btnQuanLyHoaDon_Click);
            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.BackColor = System.Drawing.Color.Cyan;
            this.btnQuanLyDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyDanhMuc.Location = new System.Drawing.Point(187, 22);
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.Size = new System.Drawing.Size(153, 50);
            this.btnQuanLyDanhMuc.TabIndex = 0;
            this.btnQuanLyDanhMuc.Text = "Danh Mục";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = false;
            this.btnQuanLyDanhMuc.Click += new System.EventHandler(this.btnQuanLyDanhMuc_Click);
            // 
            // btnQuanLyBanHang
            // 
            this.btnQuanLyBanHang.BackColor = System.Drawing.Color.Cyan;
            this.btnQuanLyBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanLyBanHang.Location = new System.Drawing.Point(3, 22);
            this.btnQuanLyBanHang.Name = "btnQuanLyBanHang";
            this.btnQuanLyBanHang.Size = new System.Drawing.Size(153, 50);
            this.btnQuanLyBanHang.TabIndex = 0;
            this.btnQuanLyBanHang.Text = "Bán Hàng";
            this.btnQuanLyBanHang.UseVisualStyleBackColor = false;
            this.btnQuanLyBanHang.Click += new System.EventHandler(this.btnQuanLyBanHang_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Location = new System.Drawing.Point(13, 252);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1067, 526);
            this.tabControlMain.TabIndex = 2;
            // 
            // btnDongUngDung
            // 
            btnDongUngDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            btnDongUngDung.Image = global::QuanLyMiCay.Properties.Resources.quitIcon;
            btnDongUngDung.Location = new System.Drawing.Point(951, 25);
            btnDongUngDung.Name = "btnDongUngDung";
            btnDongUngDung.Size = new System.Drawing.Size(100, 100);
            btnDongUngDung.TabIndex = 2;
            btnDongUngDung.UseVisualStyleBackColor = true;
            btnDongUngDung.Click += new System.EventHandler(this.btnDongUngDung_Click);
            // 
            // btnChiTietTaiKhoan
            // 
            this.btnChiTietTaiKhoan.Image = global::QuanLyMiCay.Properties.Resources.iconUser;
            this.btnChiTietTaiKhoan.Location = new System.Drawing.Point(29, 35);
            this.btnChiTietTaiKhoan.Name = "btnChiTietTaiKhoan";
            this.btnChiTietTaiKhoan.Size = new System.Drawing.Size(64, 64);
            this.btnChiTietTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnChiTietTaiKhoan.TabIndex = 1;
            this.btnChiTietTaiKhoan.TabStop = false;
            this.btnChiTietTaiKhoan.Click += new System.EventHandler(this.btnChiTietTaiKhoan_Click);
            this.btnChiTietTaiKhoan.MouseEnter += new System.EventHandler(this.btnChiTietTaiKhoan_MouseEnter);
            this.btnChiTietTaiKhoan.MouseLeave += new System.EventHandler(this.btnChiTietTaiKhoan_MouseLeave);
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 790);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChiTietTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox btnChiTietTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnQuanLyThucAn;
        private System.Windows.Forms.Button btnQuanLyBanAn;
        private System.Windows.Forms.Button btnQuanLyHoaDon;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
        private System.Windows.Forms.Button btnQuanLyBanHang;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}