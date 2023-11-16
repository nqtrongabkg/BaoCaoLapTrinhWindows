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
    public partial class frmQuanLyTaiKhoan : Form
    {
        private ChuoiKN _context = new ChuoiKN();
        private bool isEditing = false;

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvDanhSach.DataSource = _context.TaiKhoans.Select(t => new
            {
                MaTaiKhoan = t.MaTaiKhoan,
                TenTaiKhoan = t.TenTaiKhoan,
                MatKhau = t.MatKhau
            }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaTaiKhoan.Clear();
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtTenTaiKhoan.Focus();
            txtTenTaiKhoan.Enabled = true;
            txtMatKhau.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            isEditing = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvDanhSach.SelectedRows[0].Cells[0].Value);
                    var taiKhoan = _context.TaiKhoans.Find(id);
                    if (taiKhoan != null)
                    {
                        _context.TaiKhoans.Remove(taiKhoan);
                        _context.SaveChanges();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Bản ghi không tồn tại trong cơ sở dữ liệu.");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                isEditing = true;
                txtMaTaiKhoan.Text = dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString();
                txtTenTaiKhoan.Text = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
                txtMatKhau.Text = dgvDanhSach.SelectedRows[0].Cells[2].Value.ToString();
                txtTenTaiKhoan.Enabled = true;
                txtMatKhau.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTaiKhoan.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tài khoản và mật khẩu!");
                return;
            }

            if (isEditing)
            {
                int id = Convert.ToInt32(txtMaTaiKhoan.Text);
                var taiKhoan = _context.TaiKhoans.Find(id);
                if (taiKhoan != null)
                {
                    taiKhoan.TenTaiKhoan = txtTenTaiKhoan.Text;
                    taiKhoan.MatKhau = txtMatKhau.Text;
                    _context.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                var newTaiKhoan = new TaiKhoan() { TenTaiKhoan = txtTenTaiKhoan.Text, MatKhau = txtMatKhau.Text };
                _context.TaiKhoans.Add(newTaiKhoan);
                _context.SaveChanges();
                LoadData();
            }

            txtTenTaiKhoan.Enabled = false;
            txtMatKhau.Enabled = false;
            isEditing = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = selectedRow.Cells["MaTaiKhoan"].Value.ToString();
                txtTenTaiKhoan.Text = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
                txtMatKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }


        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaTaiKhoan.Text = selectedRow.Cells["MaTaiKhoan"].Value.ToString();
                txtTenTaiKhoan.Text = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
                txtMatKhau.Text = selectedRow.Cells["MatKhau"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
