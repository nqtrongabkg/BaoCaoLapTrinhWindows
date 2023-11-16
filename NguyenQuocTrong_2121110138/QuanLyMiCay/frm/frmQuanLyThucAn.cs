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
    public partial class frmQuanLyThucAn : Form
    {
        private ChuoiKN _context = new ChuoiKN();
        private bool isEditing = false;

        public frmQuanLyThucAn()
        {
            InitializeComponent();
            LoadData();
            LoadLoaiThucAn();
        }

        private void LoadData()
        {
            dgvDanhSach.DataSource = _context.ThucAns.Select(t => new
            {
                MaThucAn = t.MaThucAn,
                TenThucAn = t.TenThucAn,
                GiaThucAn = t.GiaThucAn,
                TenLoaiThucAn = t.LoaiThucAn.TenLoaiThucAn
            }).ToList();
        }

        private void LoadLoaiThucAn()
        {
            cbLoaiThucAn.DataSource = _context.LoaiThucAns.ToList();
            cbLoaiThucAn.DisplayMember = "TenLoaiThucAn";
            cbLoaiThucAn.ValueMember = "MaLoaiThucAn";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isEditing = false;
            txtMaThucAn.Clear();
            txtTenThucAn.Enabled = true;
            txtGiaThucAn.Enabled = true;
            txtTenThucAn.Clear();
            txtGiaThucAn.Clear();
            txtTenThucAn.Focus();
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
                    var thucAn = _context.ThucAns.Find(id);
                    if (thucAn != null)
                    {
                        _context.ThucAns.Remove(thucAn);
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
                txtMaThucAn.Text = dgvDanhSach.SelectedRows[0].Cells[0].Value.ToString();
                txtTenThucAn.Text = dgvDanhSach.SelectedRows[0].Cells[1].Value.ToString();
                txtGiaThucAn.Text = dgvDanhSach.SelectedRows[0].Cells[2].Value.ToString();
                txtTenThucAn.Enabled = true;
                txtGiaThucAn.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenThucAn.Text) || string.IsNullOrWhiteSpace(txtGiaThucAn.Text))
            {
                MessageBox.Show("Vui lòng nhập tên thức ăn và giá!");
                return;
            }
            decimal giaThucAn;
            if (!decimal.TryParse(txtGiaThucAn.Text, out giaThucAn) || giaThucAn <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá thức ăn là một số hợp lệ lớn hơn 0!");
                return;
            }
            int selectedLoaiThucAnID = Convert.ToInt32(cbLoaiThucAn.SelectedValue);

            if (isEditing)
            {
                int id = Convert.ToInt32(txtMaThucAn.Text);
                var thucAn = _context.ThucAns.Find(id);
                if (thucAn != null)
                {
                    thucAn.TenThucAn = txtTenThucAn.Text;
                    thucAn.GiaThucAn = decimal.Parse(txtGiaThucAn.Text);
                    thucAn.MaLoaiThucAn = selectedLoaiThucAnID;  // Cập nhật Loại Thức Ăn
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
                var newThucAn = new ThucAn()
                {
                    TenThucAn = txtTenThucAn.Text,
                    GiaThucAn = decimal.Parse(txtGiaThucAn.Text),
                    MaLoaiThucAn = selectedLoaiThucAnID   // Thêm Loại Thức Ăn cho Thực Ăn mới
                };
                _context.ThucAns.Add(newThucAn);
                _context.SaveChanges();
                LoadData();
            }

            txtTenThucAn.Enabled = false;
            txtGiaThucAn.Enabled = false;
            isEditing = false;
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaThucAn.Text = selectedRow.Cells["MaThucAn"].Value.ToString();
                txtTenThucAn.Text = selectedRow.Cells["TenThucAn"].Value.ToString();
                txtGiaThucAn.Text = selectedRow.Cells["GiaThucAn"].Value.ToString();

                // Thiết lập giá trị cho cbLoaiThucAn dựa vào cột "TenLoaiThucAn"
                cbLoaiThucAn.Text = selectedRow.Cells["TenLoaiThucAn"].Value.ToString();

                txtTenThucAn.Enabled = false;
                txtGiaThucAn.Enabled = false;
                btnSua.Enabled = true; 
                btnXoa.Enabled = true;
            }
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaThucAn.Text = selectedRow.Cells["MaThucAn"].Value.ToString();
                txtTenThucAn.Text = selectedRow.Cells["TenThucAn"].Value.ToString();
                txtGiaThucAn.Text = selectedRow.Cells["GiaThucAn"].Value.ToString();

                // Thiết lập giá trị cho cbLoaiThucAn dựa vào cột "TenLoaiThucAn"
                cbLoaiThucAn.Text = selectedRow.Cells["TenLoaiThucAn"].Value.ToString();

                txtTenThucAn.Enabled = false;
                txtGiaThucAn.Enabled = false;
                btnSua.Enabled = true; 
                btnXoa.Enabled = true;
            }
        }

        private void dgvDanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvDanhSach.Rows[e.RowIndex];
                txtMaThucAn.Text = selectedRow.Cells["MaThucAn"].Value.ToString();
                txtTenThucAn.Text = selectedRow.Cells["TenThucAn"].Value.ToString();
                txtGiaThucAn.Text = selectedRow.Cells["GiaThucAn"].Value.ToString();

                // Thiết lập giá trị cho cbLoaiThucAn dựa vào cột "TenLoaiThucAn"
                cbLoaiThucAn.Text = selectedRow.Cells["TenLoaiThucAn"].Value.ToString();

                txtTenThucAn.Enabled = false;
                txtGiaThucAn.Enabled = false;
                btnSua.Enabled = true;  
                btnXoa.Enabled = true;
            }
        }
    }
}

