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
    public partial class frmQuanLyBanHang : Form
    {
        private ChuoiKN _context = new ChuoiKN();
        private List<BanAn> _banAns;
        private List<LoaiThucAn> _loaiThucAns;
        private List<ThucAn> _thucAns;
        private BanAn _banAnHienTai;
        private HoaDon _hoaDonHienTai;
       
        public frmQuanLyBanHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            LoadBanAn();
            LoadLoaiThucAn();
        }
        private void LoadBanAn()
        {
            _banAns = _context.BanAns.ToList();

            int xInitial = 10, yInitial = 20, btnWidth = 50, btnHeight = 25, distance = 10;
            int currentX = xInitial, currentY = yInitial;

            foreach (var banAn in _banAns)
            {
                Button btn = new Button
                {
                    Text = banAn.TenBanAn,
                    Width = btnWidth,
                    Height = btnHeight,
                    Location = new Point(currentX, currentY),
                    Tag = banAn  // Để lưu thông tin bàn ăn liên quan đến nút này
                };

                btn.Click += BtnBanAn_Click;  // Gán sự kiện khi nhấn vào nút

                grbBanAn.Controls.Add(btn);  // Thêm nút vào GroupBox grbBanAn

                currentX += btnWidth + distance;
                if (currentX + btnWidth > grbBanAn.Width)
                {
                    currentX = xInitial;
                    currentY += btnHeight + distance;
                }
            }
        }
        private void BtnBanAn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                BanAn selectedBanAn = clickedButton.Tag as BanAn;
                if (selectedBanAn != null)
                {
                    _banAnHienTai = selectedBanAn;

                    // Hiển thị tên bàn trong txtTenBan
                    txtTenBan.Text = selectedBanAn.TenBanAn;

                    EnsureHoaDonExistsForBanAn(selectedBanAn); // Đảm bảo rằng có một hóa đơn tồn tại cho bàn này
                    LoadHoaDonBanAn();
                }
            }
        }

        private void LoadLoaiThucAn()
        {
            _loaiThucAns = _context.LoaiThucAns.ToList();

            cbLoaiThucAn.DataSource = _loaiThucAns;
            cbLoaiThucAn.DisplayMember = "TenLoaiThucAn";
            cbLoaiThucAn.ValueMember = "MaLoaiThucAn";

            // Thêm sự kiện SelectedIndexChanged
            cbLoaiThucAn.SelectedIndexChanged += cbLoaiThucAn_SelectedIndexChanged;
        }
        private void cbLoaiThucAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiThucAn.SelectedValue is int maLoaiThucAn)
            {
                LoadThucAnTheoLoai(maLoaiThucAn);
            }
        }
        private void LoadThucAnTheoLoai(int maLoaiThucAn)
        {
            _thucAns = _context.ThucAns.Where(ta => ta.MaLoaiThucAn == maLoaiThucAn).ToList();

            lbMonAn.DataSource = _thucAns;
            lbMonAn.DisplayMember = "TenThucAn";
        }
        private void LoadHoaDonBanAn()
        {
            _hoaDonHienTai = _context.HoaDons.Include("ChiTietHoaDons").Include("ChiTietHoaDons.ThucAn")
            .FirstOrDefault(hd => hd.MaBanAn == _banAnHienTai.MaBanAn && !hd.IsPaid);

            // Làm sạch danh sách món ăn trước
            lbHoaDon.Items.Clear();

            if (_hoaDonHienTai != null)
            {
                double tongTien = 0;

                foreach (var chiTiet in _hoaDonHienTai.ChiTietHoaDons)
                {
                    // Thêm món ăn và số lượng vào danh sách
                    lbHoaDon.Items.Add($"{chiTiet.ThucAn.TenThucAn} x {chiTiet.SoLuong}");

                    tongTien += Convert.ToDouble(chiTiet.SoLuong * chiTiet.ThucAn.GiaThucAn);
                }

                txtTongTien.Text = $"{tongTien} VND"; // Hiển thị tổng tiền
            }
            else
            {
                txtTongTien.Text = "0 VND";
            }
            lbHoaDon.SelectedIndexChanged += lbHoaDon_SelectedIndexChanged;
        }
        private void lbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHoaDon.SelectedItem != null)
            {
                string selectedItem = lbHoaDon.SelectedItem.ToString();
                string[] parts = selectedItem.Split('x');
                if (parts.Length == 2)
                {
                    txtTenMon.Text = parts[0].Trim();
                    txtSoLuong.Text = parts[1].Trim();
                }
            }
        }
        private void lbMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMonAn.SelectedItem is ThucAn selectedThucAn)
            {
                txtTenMon.Text = selectedThucAn.TenThucAn;
                string tenMon = selectedThucAn.TenThucAn;
            }
        }
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            // 0. Lấy số lượng từ giao diện
            int soLuong;
            if (!int.TryParse(txtSoLuong.Text, out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                return;
            }

            // 1. Kiểm tra hóa đơn hiện tại
            ThucAn selectedThucAn = lbMonAn.SelectedItem as ThucAn;
            if (selectedThucAn == null)
            {
                MessageBox.Show("Vui lòng chọn một món ăn từ danh sách!");
                return;
            }

            // 2. Lấy món ăn được chọn từ lbMonAn (đã kiểm tra ở bước 1 nên không cần kiểm tra lại)

            // 3. Kiểm tra xem món ăn này đã có trong hóa đơn chưa
            ChiTietHoaDon chiTiet = _context.ChiTietHoaDons
                .FirstOrDefault(ct => ct.MaHoaDon == _hoaDonHienTai.MaHoaDon && ct.MaThucAn == selectedThucAn.MaThucAn);

            if (chiTiet != null)
            {
                // Nếu món ăn đã có, cập nhật số lượng
                chiTiet.SoLuong += soLuong;
            }
            else
            {
                // Nếu món ăn chưa có, tạo mới chi tiết hóa đơn
                chiTiet = new ChiTietHoaDon
                {
                    MaHoaDon = _hoaDonHienTai.MaHoaDon,
                    MaThucAn = selectedThucAn.MaThucAn,
                    SoLuong = soLuong,
                    ThanhTien = Convert.ToDecimal(selectedThucAn.GiaThucAn * soLuong),
                };
                _context.ChiTietHoaDons.Add(chiTiet);
            }

            // 4. Lưu thay đổi vào cơ sở dữ liệu
            _context.SaveChanges();

            // 5. Cập nhật lại danh sách hóa đơn hoặc thông tin hiển thị
            LoadHoaDonBanAn();
        }

        private void EnsureHoaDonExistsForBanAn(BanAn banAn)
        {
            _hoaDonHienTai = _context.HoaDons.Include("ChiTietHoaDons").Include("ChiTietHoaDons.ThucAn")
                               .FirstOrDefault(hd => hd.MaBanAn == banAn.MaBanAn && !hd.IsPaid);

            // Nếu không tồn tại hóa đơn, tạo một hóa đơn mới
            if (_hoaDonHienTai == null)
            {
                _hoaDonHienTai = new HoaDon
                {
                    MaBanAn = banAn.MaBanAn,
                    NgayTao = DateTime.Now,
                    IsPaid = false,
                    // Set các thuộc tính khác nếu cần
                };
                _context.HoaDons.Add(_hoaDonHienTai);
                _context.SaveChanges(); // Lưu hóa đơn mới vào cơ sở dữ liệu
            }
        }


        private void btnHuyMon_Click(object sender, EventArgs e)
        {
            if (lbHoaDon.SelectedItem != null && _hoaDonHienTai != null)
            {
                string selectedItem = lbHoaDon.SelectedItem.ToString();
                string tenMon = selectedItem.Split('x')[0].Trim();
                ChiTietHoaDon chiTietHoaDon = _hoaDonHienTai.ChiTietHoaDons.FirstOrDefault(ch => ch.ThucAn.TenThucAn == tenMon);

                if (chiTietHoaDon != null)
                {
                    _context.ChiTietHoaDons.Remove(chiTietHoaDon);
                    _context.SaveChanges();
                    LoadHoaDonBanAn();

                    txtTenMon.Text = "";
                    txtSoLuong.Text = "";
                }
            }
        }

        private void btnHuyBan_Click(object sender, EventArgs e)
        {
            if (_hoaDonHienTai != null)
            {
                _context.HoaDons.Remove(_hoaDonHienTai);
                _context.SaveChanges();
                LoadHoaDonBanAn();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (_hoaDonHienTai != null)
            {
                _hoaDonHienTai.IsPaid = true;
                _hoaDonHienTai.NgayKetThuc = DateTime.Now;
                _context.SaveChanges();
                LoadHoaDonBanAn(); 
            }
        }
    }
}
