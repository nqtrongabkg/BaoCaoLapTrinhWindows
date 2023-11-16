namespace QuanLyMiCay.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiThucAn")]
    public partial class LoaiThucAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiThucAn()
        {
            ThucAns = new HashSet<ThucAn>();
        }

        [Key]
        public int MaLoaiThucAn { get; set; }

        [Required]
        [StringLength(255)]
        public string TenLoaiThucAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThucAn> ThucAns { get; set; }
    }
}
