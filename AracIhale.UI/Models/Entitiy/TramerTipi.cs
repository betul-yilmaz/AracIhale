namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TramerTipi")]
    public partial class TramerTipi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TramerTipi()
        {
            AracTramerDetay = new HashSet<AracTramerDetay>();
        }

        [Key]
        public int TramerTipID { get; set; }

        [Column("TramerTipi")]
        [Required]
        [StringLength(250)]
        public string TramerTipi1 { get; set; }

        [StringLength(250)]
        public string Aciklama { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracTramerDetay> AracTramerDetay { get; set; }
    }
}
