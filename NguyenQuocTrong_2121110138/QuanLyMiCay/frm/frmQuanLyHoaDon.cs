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
    public partial class frmQuanLyHoaDon : Form
    {
        private ChuoiKN _context = new ChuoiKN();
        
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dgvDanhSach.DataSource = _context.HoaDons.Select(h => new
            {
                MaHoaDon = h.MaHoaDon,
                NgayTao = h.NgayTao,
                NgayKetThuc = h.NgayKetThuc,
                MaBanAn = h.MaBanAn,
                TongTien = h.ChiTietHoaDons
                             .Select(ct => (decimal?)ct.ThanhTien) 
                             .DefaultIfEmpty(0) 
                             .Sum()
            }).ToList();
            dgvDanhSach.Refresh();
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này và tất cả chi tiết liên quan?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int maHoaDon = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaHoaDon"].Value);

                    // Bước 1: Xóa các ChiTietHoaDon liên quan
                    var chiTietHoaDons = _context.ChiTietHoaDons.Where(ct => ct.MaHoaDon == maHoaDon).ToList();
                    _context.ChiTietHoaDons.RemoveRange(chiTietHoaDons);

                    // Bước 2: Xóa HoaDon
                    var hoaDon = _context.HoaDons.FirstOrDefault(h => h.MaHoaDon == maHoaDon);
                    if (hoaDon != null)
                    {
                        _context.HoaDons.Remove(hoaDon);
                    }

                    _context.SaveChanges();
                    LoadData();
                }
            }
        }


        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                int maHoaDon = Convert.ToInt32(dgvDanhSach.CurrentRow.Cells["MaHoaDon"].Value);
                var formChiTiet = new frmChiTietHoaDon(maHoaDon); // Giả sử bạn đã tạo một constructor nhận vào mã hóa đơn cho frmChiTietHoaDon
                formChiTiet.ShowDialog();
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDanhSach.Rows.Count)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMaHoaDon.Text = row.Cells["MaHoaDon"].Value.ToString();
                txtMaBanAn.Text = row.Cells["MaBanAn"].Value.ToString();
                txtTongTien.Text = row.Cells["TongTien"].Value.ToString();
                txtNgayTao.Text = row.Cells["NgayTao"].Value.ToString();
                txtNgayKetThuc.Text = row.Cells["NgayKetThuc"].Value?.ToString() ?? string.Empty;
            }
        }

        private void frmQuanLyHoaDon_MouseHover(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
