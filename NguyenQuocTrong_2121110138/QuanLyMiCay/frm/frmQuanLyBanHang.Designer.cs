namespace QuanLyMiCay.frm
{
    partial class frmQuanLyBanHang
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
            this.grbBanAn = new System.Windows.Forms.GroupBox();
            this.grbHoaDon = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHoaDon = new System.Windows.Forms.ListBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyBan = new System.Windows.Forms.Button();
            this.btnHuyMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.grbMonAn = new System.Windows.Forms.GroupBox();
            this.lbMonAn = new System.Windows.Forms.ListBox();
            this.cbLoaiThucAn = new System.Windows.Forms.ComboBox();
            this.grbHoaDon.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grbMonAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBanAn
            // 
            this.grbBanAn.Location = new System.Drawing.Point(6, 5);
            this.grbBanAn.Name = "grbBanAn";
            this.grbBanAn.Size = new System.Drawing.Size(277, 469);
            this.grbBanAn.TabIndex = 0;
            this.grbBanAn.TabStop = false;
            this.grbBanAn.Text = "Bàn ăn";
            // 
            // grbHoaDon
            // 
            this.grbHoaDon.Controls.Add(this.txtTongTien);
            this.grbHoaDon.Controls.Add(this.label4);
            this.grbHoaDon.Controls.Add(this.lbHoaDon);
            this.grbHoaDon.Controls.Add(this.txtTenBan);
            this.grbHoaDon.Controls.Add(this.label3);
            this.grbHoaDon.Location = new System.Drawing.Point(289, 5);
            this.grbHoaDon.Name = "grbHoaDon";
            this.grbHoaDon.Size = new System.Drawing.Size(258, 469);
            this.grbHoaDon.TabIndex = 1;
            this.grbHoaDon.TabStop = false;
            this.grbHoaDon.Text = "Hóa đơn";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(9, 441);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(243, 22);
            this.txtTongTien.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền";
            // 
            // lbHoaDon
            // 
            this.lbHoaDon.FormattingEnabled = true;
            this.lbHoaDon.ItemHeight = 16;
            this.lbHoaDon.Location = new System.Drawing.Point(6, 62);
            this.lbHoaDon.Name = "lbHoaDon";
            this.lbHoaDon.Size = new System.Drawing.Size(246, 356);
            this.lbHoaDon.TabIndex = 3;
            this.lbHoaDon.SelectedIndexChanged += new System.EventHandler(this.lbHoaDon_SelectedIndexChanged);
            // 
            // txtTenBan
            // 
            this.txtTenBan.Enabled = false;
            this.txtTenBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.Location = new System.Drawing.Point(87, 16);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(156, 34);
            this.txtTenBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtSoLuong);
            this.groupBox3.Controls.Add(this.txtTenMon);
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.btnHuyBan);
            this.groupBox3.Controls.Add(this.btnHuyMon);
            this.groupBox3.Controls.Add(this.btnThemMon);
            this.groupBox3.Location = new System.Drawing.Point(553, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 467);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên món";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(6, 158);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(226, 34);
            this.txtSoLuong.TabIndex = 1;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Enabled = false;
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(6, 71);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(226, 34);
            this.txtTenMon.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(34, 415);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(177, 34);
            this.btnThanhToan.TabIndex = 0;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuyBan
            // 
            this.btnHuyBan.Location = new System.Drawing.Point(34, 364);
            this.btnHuyBan.Name = "btnHuyBan";
            this.btnHuyBan.Size = new System.Drawing.Size(177, 34);
            this.btnHuyBan.TabIndex = 0;
            this.btnHuyBan.Text = "Hủy bàn";
            this.btnHuyBan.UseVisualStyleBackColor = true;
            this.btnHuyBan.Click += new System.EventHandler(this.btnHuyBan_Click);
            // 
            // btnHuyMon
            // 
            this.btnHuyMon.Location = new System.Drawing.Point(34, 309);
            this.btnHuyMon.Name = "btnHuyMon";
            this.btnHuyMon.Size = new System.Drawing.Size(177, 34);
            this.btnHuyMon.TabIndex = 0;
            this.btnHuyMon.Text = "Hủy món";
            this.btnHuyMon.UseVisualStyleBackColor = true;
            this.btnHuyMon.Click += new System.EventHandler(this.btnHuyMon_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(34, 252);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(177, 34);
            this.btnThemMon.TabIndex = 0;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // grbMonAn
            // 
            this.grbMonAn.Controls.Add(this.lbMonAn);
            this.grbMonAn.Controls.Add(this.cbLoaiThucAn);
            this.grbMonAn.Location = new System.Drawing.Point(797, 4);
            this.grbMonAn.Name = "grbMonAn";
            this.grbMonAn.Size = new System.Drawing.Size(248, 469);
            this.grbMonAn.TabIndex = 3;
            this.grbMonAn.TabStop = false;
            this.grbMonAn.Text = "Món";
            // 
            // lbMonAn
            // 
            this.lbMonAn.FormattingEnabled = true;
            this.lbMonAn.ItemHeight = 16;
            this.lbMonAn.Location = new System.Drawing.Point(6, 87);
            this.lbMonAn.Name = "lbMonAn";
            this.lbMonAn.Size = new System.Drawing.Size(236, 372);
            this.lbMonAn.TabIndex = 1;
            this.lbMonAn.SelectedIndexChanged += new System.EventHandler(this.lbMonAn_SelectedIndexChanged);
            // 
            // cbLoaiThucAn
            // 
            this.cbLoaiThucAn.FormattingEnabled = true;
            this.cbLoaiThucAn.Location = new System.Drawing.Point(18, 35);
            this.cbLoaiThucAn.Name = "cbLoaiThucAn";
            this.cbLoaiThucAn.Size = new System.Drawing.Size(210, 24);
            this.cbLoaiThucAn.TabIndex = 0;
            this.cbLoaiThucAn.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThucAn_SelectedIndexChanged);
            // 
            // frmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 479);
            this.Controls.Add(this.grbMonAn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbHoaDon);
            this.Controls.Add(this.grbBanAn);
            this.Name = "frmQuanLyBanHang";
            this.Text = "frmQuanLyBanHang";
            this.Load += new System.EventHandler(this.frmQuanLyBanHang_Load);
            this.grbHoaDon.ResumeLayout(false);
            this.grbHoaDon.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grbMonAn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBanAn;
        private System.Windows.Forms.GroupBox grbHoaDon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grbMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyBan;
        private System.Windows.Forms.Button btnHuyMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbHoaDon;
        private System.Windows.Forms.ListBox lbMonAn;
        private System.Windows.Forms.ComboBox cbLoaiThucAn;
    }
}