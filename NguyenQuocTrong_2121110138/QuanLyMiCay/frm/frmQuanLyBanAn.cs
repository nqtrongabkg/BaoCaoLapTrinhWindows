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
    public partial class frmQuanLyBanAn : Form
    {
        private ChuoiKN _context = new ChuoiKN();
        private bool isEditing = false;

        public frmQuanLyBanAn()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvDanhSach.DataSource = _context.BanAns.Select(b => new
            {
                MaBanAn = b.MaBanAn,
                TenBanAn = b.TenBanAn
            }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEditing = false;
            txtMaBanAn.Clear();
            txtTenBanAn.Enabled = true;
            txtTenBanAn.Clear();
            txtTenBanAn.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvDanhSach.SelectedRows[0].Cells[0].Value);
                    var banAn = _context.BanAns.Find(id);
                    if (banAn != null)
                    {
                        _context.BanAns.Remove(banAn);
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
                txtMaBanAn.Text = dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString();
                txtTenBanAn.Text = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
                txtTenBanAn.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenBanAn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn ăn!");
                return;
            }

            if (isEditing)
            {
                int id = Convert.ToInt32(txtMaBanAn.Text);
                var banAn = _context.BanAns.Find(id);
                if (banAn != null)
                {
                    banAn.TenBanAn = txtTenBanAn.Text;
                    _context.SaveChanges();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Bản ghi không tồn tại trong cơ sở dữ liệu.");
                }
            }
            else
            {
                var newBanAn = new BanAn() { TenBanAn = txtTenBanAn.Text };
                _context.BanAns.Add(newBanAn);
                _context.SaveChanges();
                LoadData();
            }

            txtTenBanAn.Enabled = false;
            isEditing = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaBanAn.Text = selectedRow.Cells["MaBanAn"].Value.ToString();
                txtTenBanAn.Text = selectedRow.Cells["TenBanAn"].Value.ToString();
                txtTenBanAn.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

