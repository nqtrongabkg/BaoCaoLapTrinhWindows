using QuanLyMiCay.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyMiCay.frm
{
    public partial class frmTrangChu : Form
    {
        public static TaiKhoan taikhoan = null;
        public frmTrangChu()
        {
            InitializeComponent();
            btnChiTietTaiKhoan.MouseEnter += new EventHandler(btnChiTietTaiKhoan_MouseEnter);
            btnChiTietTaiKhoan.MouseLeave += new EventHandler(btnChiTietTaiKhoan_MouseLeave);
        }
        public void EnableControls()
        {
            btnQuanLyDanhMuc.Enabled = true;
            btnQuanLyBanHang.Enabled = true;
            btnQuanLyBanAn.Enabled = true;
            btnQuanLyThucAn.Enabled = true;
            btnQuanLyHoaDon.Enabled = true;
            if (taikhoan != null && taikhoan.TenTaiKhoan == "admin")
            {
                btnQuanLyTaiKhoan.Enabled = true;
            }
        }
        public void DisableControls()
        {
            btnQuanLyDanhMuc.Enabled = false;
            btnQuanLyBanHang.Enabled = false;
            btnQuanLyBanAn.Enabled = false;
            btnQuanLyThucAn.Enabled = false;
            btnQuanLyHoaDon.Enabled = false;
            btnQuanLyTaiKhoan.Enabled = false;
        }

        public void CloseAllTabPages()
        {
            // Đóng tất cả các TabPage
            while (tabControlMain.TabPages.Count > 0)
            {
                TabPage currentTab = tabControlMain.TabPages[0];
                tabControlMain.TabPages.Remove(currentTab);
                   //giải phóng các dữ liệu
                (currentTab.Controls[0] as Form).Close();
            }
        }


        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if(taikhoan == null)
            {
                btnQuanLyDanhMuc.Enabled = false;
                btnQuanLyBanHang.Enabled = false;
                btnQuanLyBanAn.Enabled = false;
                btnQuanLyThucAn.Enabled = false;
                btnQuanLyHoaDon.Enabled = false;
                btnQuanLyTaiKhoan.Enabled = false;
            }
            if(taikhoan != null && taikhoan.TenTaiKhoan == "admin")
            {
                btnQuanLyTaiKhoan.Enabled = true;
            }
        }
        private void btnChiTietTaiKhoan_Click(object sender, EventArgs e)
        {
            Form frm = new frmChiTietTaiKhoan();
            frm.ShowDialog();
        }
        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpTaiKhoan"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý tài khoản";
                tabPage.Name = "tpTaiKhoan";
                tabPage.ImageIndex = 0;

                Form frm = new frmQuanLyTaiKhoan();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();

                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpTaiKhoan"];
            }
        }
        private void btnQuanLyBanHang_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpBanHang"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý bán hàng";
                tabPage.Name = "tpBanHang";
                tabPage.ImageIndex = 0;
                Form frm = new frmQuanLyBanHang();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();
                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpBanHang"];
            }
        }
        private bool ExistTabPage(TabControl tabControl, string tabPageName)
        {
            return tabControl.TabPages.ContainsKey(tabPageName);
        }
        private void btnQuanLyDanhMuc_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpDanhMuc"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý danh mục";
                tabPage.Name = "tpDanhMuc";
                tabPage.ImageIndex = 0;

                Form frm = new frmQuanLyDanhMuc();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();

                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpDanhMuc"];
            }
        }
        private void btnQuanLyBanAn_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpBanAn"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý bàn ăn";
                tabPage.Name = "tpBanAn";
                tabPage.ImageIndex = 0;

                Form frm = new frmQuanLyBanAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();

                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpBanAn"];
            }
        }
        private void btnQuanLyThucAn_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpThucAn"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý thức ăn";
                tabPage.Name = "tpThucAn";
                tabPage.ImageIndex = 0;

                Form frm = new frmQuanLyThucAn();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();

                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);
            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpThucAn"];
            }
        }
        private void btnQuanLyHoaDon_Click(object sender, EventArgs e)
        {
            if (!ExistTabPage(tabControlMain, "tpHoaDon"))
            {
                TabPage tabPage = new TabPage();
                tabPage.Text = "Quản lý hóa đơn";
                tabPage.Name = "tpHoaDon";
                tabPage.ImageIndex = 0;

                Form frm = new frmQuanLyHoaDon();
                frm.TopLevel = false;
                frm.Parent = tabPage;
                frm.Dock = DockStyle.Fill;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Show();

                tabPage.Controls.Add(frm);
                tabControlMain.TabPages.Add(tabPage);

            }
            else
            {
                tabControlMain.SelectedTab = tabControlMain.TabPages["tpHoaDon"];
                tabControlMain.TabPages["tpHoaDon"].Refresh();
            }
        }

        private void btnChiTietTaiKhoan_MouseEnter(object sender, EventArgs e)
        {
            btnChiTietTaiKhoan.BackColor = Color.LightBlue;
        }

        private void btnChiTietTaiKhoan_MouseLeave(object sender, EventArgs e)
        {
            btnChiTietTaiKhoan.BackColor = SystemColors.Control;
        }

        private void btnDongUngDung_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất và THOÁT?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
