namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ihale")]
    public partial class Ihale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ihale()
        {
            IhaleArac = new HashSet<IhaleArac>();
        }

        public int IhaleId { get; set; }

        public int? KullaniciId { get; set; }

        [StringLength(250)]
        public string Adi { get; set; }

        public string Aciklama { get; set; }

        public DateTime? BaslangicTarih { get; set; }

        public DateTime? BitisTarih { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IhaleArac> IhaleArac { get; set; }
    }
}
