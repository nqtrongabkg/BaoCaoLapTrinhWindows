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
    public partial class frmChiTietHoaDon : Form
    {
        private int _maHoaDon;
        private ChuoiKN db;
        private enum ActionState
        {
            Default,
            Adding,
            Editing
        }

        private ActionState _currentState = ActionState.Default;

        private ChiTietHoaDon _editingChiTiet;
        public frmChiTietHoaDon(int maHoaDon)
        {
            _maHoaDon = maHoaDon;
            db = new ChuoiKN();
            InitializeComponent();
            LoadData();
            LoadComboBoxes();
        }

        private void LoadData()
        {
            var data = db.ChiTietHoaDons
                .Where(c => c.MaHoaDon == _maHoaDon)
                .Select(c => new
                {
                    c.MaChiTietHoaDon,
                    c.MaHoaDon,
                    c.ThucAn.TenThucAn,
                    c.ThucAn.LoaiThucAn.TenLoaiThucAn,
                    c.SoLuong,
                    c.ThanhTien
                })
                .ToList();

            dgvDanhSach.DataSource = data;
        }

        private void LoadComboBoxes()
        {
            cbTenThucAn.DataSource = db.ThucAns.ToList();
            cbTenThucAn.DisplayMember = "TenThucAn";
            cbTenThucAn.ValueMember = "MaThucAn";

            cbTenLoaiThucAn.DataSource = db.LoaiThucAns.ToList();
            cbTenLoaiThucAn.DisplayMember = "TenLoaiThucAn";
            cbTenLoaiThucAn.ValueMember = "MaLoaiThucAn";
        }

        private void cbTenLoaiThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedLoaiThucAnID = Convert.ToInt32(cbTenLoaiThucAn.SelectedValue);
            var thucAnsOfSelectedLoai = db.ThucAns.Where(t => t.LoaiThucAn.MaLoaiThucAn == selectedLoaiThucAnID).ToList();
            cbTenThucAn.DataSource = thucAnsOfSelectedLoai;
            cbTenThucAn.DisplayMember = "TenThucAn";
            cbTenThucAn.ValueMember = "MaThucAn";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _currentState = ActionState.Adding;
            cbTenLoaiThucAn.Enabled = true;
            txtMaChiTietHoaDon.Clear();
            txtSoLuong.Clear();
            txtSoLuong.Enabled = true;
            cbTenThucAn.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                var maChiTiet = int.Parse(dgvDanhSach.SelectedRows[0].Cells["MaChiTietHoaDon"].Value.ToString());
                var chiTiet = db.ChiTietHoaDons.SingleOrDefault(c => c.MaChiTietHoaDon == maChiTiet);

                if (chiTiet != null)
                {
                    db.ChiTietHoaDons.Remove(chiTiet);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _currentState = ActionState.Editing;

            if (dgvDanhSach.SelectedRows.Count > 0)
            {
                var maChiTiet = int.Parse(dgvDanhSach.SelectedRows[0].Cells["MaChiTietHoaDon"].Value.ToString());
                _editingChiTiet = db.ChiTietHoaDons.SingleOrDefault(c => c.MaChiTietHoaDon == maChiTiet);
            }

            cbTenLoaiThucAn.Enabled = true;
            cbTenThucAn.Enabled = true;
            txtSoLuong.Enabled = true;
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (_currentState)
            {
                case ActionState.Adding:
                    // Code thêm
                    var thucAn = db.ThucAns.SingleOrDefault(t => t.TenThucAn == cbTenThucAn.Text);
                    if (thucAn != null)
                    {
                        var chiTiet = new ChiTietHoaDon
                        {
                            MaHoaDon = _maHoaDon,
                            MaThucAn = thucAn.MaThucAn,
                            SoLuong = int.Parse(txtSoLuong.Text),
                            ThanhTien = decimal.Parse(txtThanhTien.Text)
                        };

                        db.ChiTietHoaDons.Add(chiTiet);
                    }
                    break;

                case ActionState.Editing:
                    // Code sửa
                    if (_editingChiTiet != null)
                    {
                        var thucAnEdit = db.ThucAns.SingleOrDefault(t => t.TenThucAn == cbTenThucAn.Text);
                        if (thucAnEdit != null)
                        {
                            _editingChiTiet.MaThucAn = thucAnEdit.MaThucAn;
                            _editingChiTiet.SoLuong = int.Parse(txtSoLuong.Text);
                            _editingChiTiet.ThanhTien = decimal.Parse(txtThanhTien.Text);
                        }
                    }
                    break;
            }

            db.SaveChanges();
            MessageBox.Show("Đã lưu thành công");

            _currentState = ActionState.Default;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;

            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMaChiTietHoaDon.Text = row.Cells["MaChiTietHoaDon"].Value.ToString();
                txtMaHoaDon.Text = row.Cells["MaHoaDon"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();

                // Retrieve the value first and store in a local variable
                string tenThucAn = row.Cells["TenThucAn"].Value.ToString();

                cbTenThucAn.SelectedItem = tenThucAn;

                // Use the local variable in the LINQ query
                var thucAn = db.ThucAns.SingleOrDefault(t => t.TenThucAn == tenThucAn);
                if (thucAn != null)
                {
                    cbTenLoaiThucAn.SelectedItem = thucAn.LoaiThucAn.TenLoaiThucAn;
                }
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}

