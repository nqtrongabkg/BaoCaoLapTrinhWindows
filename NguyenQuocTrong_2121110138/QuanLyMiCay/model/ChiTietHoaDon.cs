namespace QuanLyMiCay.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int MaChiTietHoaDon { get; set; }

        public int? MaHoaDon { get; set; }

        public int? MaThucAn { get; set; }

        public decimal DonGia { get; set; }

        public int SoLuong { get; set; }

        public decimal ThanhTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual ThucAn ThucAn { get; set; }
    }
}
