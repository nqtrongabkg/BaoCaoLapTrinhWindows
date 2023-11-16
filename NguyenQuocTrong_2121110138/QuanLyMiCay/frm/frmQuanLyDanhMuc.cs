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
    public partial class frmQuanLyDanhMuc : Form
    {
        private ChuoiKN _context = new ChuoiKN(); 
        private bool isEditing = false;
        public frmQuanLyDanhMuc()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvDanhSach.DataSource = _context.LoaiThucAns.Select(l => new
            {
                MaLoaiThucAn = l.MaLoaiThucAn,
                TenLoaiThucAn = l.TenLoaiThucAn
            }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaLoaiThucAn.Clear();
            txtTenLoaiThucAn.Clear();
            txtTenLoaiThucAn.Focus();
            txtTenLoaiThucAn.Enabled = true;
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
                    var loaiThucAn = _context.LoaiThucAns.Find(id);
                    if (loaiThucAn != null)
                    {
                        _context.LoaiThucAns.Remove(loaiThucAn);
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
                txtMaLoaiThucAn.Text = dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString();
                txtTenLoaiThucAn.Text = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
                txtTenLoaiThucAn.Enabled = true; // Cho phép chỉnh sửa
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoaiThucAn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại thức ăn!");
                return;
            }

            if (isEditing) // Nếu đang ở trạng thái chỉnh sửa
            {
                int id = Convert.ToInt32(txtMaLoaiThucAn.Text);
                var loaiThucAn = _context.LoaiThucAns.Find(id);
                if (loaiThucAn != null)
                {
                    loaiThucAn.TenLoaiThucAn = txtTenLoaiThucAn.Text;
                    _context.SaveChanges();
                    LoadData();
                }
            }
            else
            {
                var newLoaiThucAn = new LoaiThucAn() { TenLoaiThucAn = txtTenLoaiThucAn.Text };
                _context.LoaiThucAns.Add(newLoaiThucAn);
                _context.SaveChanges();
                LoadData();
            }

            txtTenLoaiThucAn.Enabled = false;
            isEditing = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaLoaiThucAn.Text = selectedRow.Cells["MaLoaiThucAn"].Value.ToString();
                txtTenLoaiThucAn.Text = selectedRow.Cells["TenLoaiThucAn"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaLoaiThucAn.Text = selectedRow.Cells["MaLoaiThucAn"].Value.ToString();
                txtTenLoaiThucAn.Text = selectedRow.Cells["TenLoaiThucAn"].Value.ToString();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
