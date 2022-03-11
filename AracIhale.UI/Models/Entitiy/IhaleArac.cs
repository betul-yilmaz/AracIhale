namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleArac")]
    public partial class IhaleArac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IhaleArac()
        {
            IhaleTeklif = new HashSet<IhaleTeklif>();
        }

        public int IhaleAracId { get; set; }

        public int? AracId { get; set; }

        public int? IhaleID { get; set; }

        [Column(TypeName = "money")]
        public decimal? BaslangicFiyat { get; set; }

        [Column(TypeName = "money")]
        public decimal? MinimumAlimFiyat { get; set; }

        public int? StatuId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Ihale Ihale { get; set; }

        public virtual Statu Statu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleTeklif> IhaleTeklif { get; set; }
    }
}
