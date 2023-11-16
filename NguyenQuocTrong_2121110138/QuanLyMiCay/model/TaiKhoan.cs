namespace QuanLyMiCay.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        public int MaTaiKhoan { get; set; }

        [Required]
        [StringLength(255)]
        public string TenTaiKhoan { get; set; }

        [Required]
        [StringLength(255)]
        public string MatKhau { get; set; }
    }
}
