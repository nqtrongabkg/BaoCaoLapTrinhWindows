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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            using (ChuoiKN db = new ChuoiKN())
            {
                TaiKhoan user = db.TaiKhoans.FirstOrDefault(tk => tk.TenTaiKhoan == tenDangNhap && tk.MatKhau == matKhau);

                if (user != null)
                {
                    frmTrangChu.taikhoan = user;
                    Form frmTrangChuOpen = Application.OpenForms["frmTrangChu"];
                    if (frmTrangChuOpen != null)
                    {
                        (frmTrangChuOpen as frmTrangChu).EnableControls();
                    }
                    Form frmTkOpen = Application.OpenForms["frmChiTietTaiKhoan"];
                    if (frmTkOpen != null)
                    {
                        (frmTkOpen as frmChiTietTaiKhoan).setInfo();
                        (frmTkOpen as frmChiTietTaiKhoan).closeBtnDangNhap();
                    }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
