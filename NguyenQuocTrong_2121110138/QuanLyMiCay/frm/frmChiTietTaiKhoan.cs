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
    public partial class frmChiTietTaiKhoan : Form
    {
        public static TaiKhoan taikhoan = null;
        public frmChiTietTaiKhoan()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setInfo()
        {
            txtTentaiKhoan.Text = frmTrangChu.taikhoan.TenTaiKhoan;
            txtMatKhau.Text = frmTrangChu.taikhoan.MatKhau;
        }
        public void closeBtnDangNhap()
        {
            btnOpenFrmDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
        }
        private void frmChiTietTaiKhoan_Load(object sender, EventArgs e)
        {
            if(frmTrangChu.taikhoan != null)
            {
                btnOpenFrmDangNhap.Enabled = true;
                txtTentaiKhoan.Text = frmTrangChu.taikhoan.TenTaiKhoan;
                txtMatKhau.Text = frmTrangChu.taikhoan.MatKhau;
                if(frmTrangChu.taikhoan.TenTaiKhoan == "admin")
                {
                    button1.Enabled = false;
                }
            }
            else
            {
                btnDangXuat.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTentaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào trước khi cập nhật
            if (string.IsNullOrEmpty(txtTentaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm câu hỏi xác nhận
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin tài khoản không?",
                                                "Xác nhận cập nhật",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                using (ChuoiKN db = new ChuoiKN())
                {
                    // Tìm tài khoản cần cập nhật trong cơ sở dữ liệu
                    var userToUpdate = db.TaiKhoans.Find(frmTrangChu.taikhoan.MaTaiKhoan);

                    if (userToUpdate != null)
                    {
                        userToUpdate.TenTaiKhoan = txtTentaiKhoan.Text;
                        userToUpdate.MatKhau = txtMatKhau.Text;

                        db.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu

                        // Cập nhật đối tượng taikhoan trong frmTrangChu
                        frmTrangChu.taikhoan.TenTaiKhoan = txtTentaiKhoan.Text;
                        frmTrangChu.taikhoan.MatKhau = txtMatKhau.Text;

                        MessageBox.Show("Thông tin tài khoản đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Khóa lại các ô nhập để người dùng không chỉnh sửa tiếp
                        txtTentaiKhoan.Enabled = false;
                        txtMatKhau.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi cập nhật thông tin tài khoản. Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Người dùng chọn "No", không thực hiện gì thêm
            }
        }


        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Xóa thông tin tài khoản hiện tại
                frmTrangChu.taikhoan = null;

                // Tìm form TrangChu và vô hiệu hóa các controls
                Form frmTrangChuOpen = Application.OpenForms["frmTrangChu"];
                if (frmTrangChuOpen != null)
                {
                    (frmTrangChuOpen as frmTrangChu).DisableControls();
                    //đóng các tab
                    (frmTrangChuOpen as frmTrangChu).CloseAllTabPages();
                }

                this.Close(); // Hoặc this.Hide();
            }
        }

        private void btnOpenFrmDangNhap_Click(object sender, EventArgs e)
        {
            Form frm = new frmDangNhap();
            frm.ShowDialog();
        }
    }
}
