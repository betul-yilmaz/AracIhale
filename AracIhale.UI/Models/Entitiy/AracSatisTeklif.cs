namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracSatisTeklif")]
    public partial class AracSatisTeklif
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AracSatisTeklif()
        {
            AracSatisDetay = new HashSet<AracSatisDetay>();
        }

        public int AracSatisTeklifId { get; set; }

        public int? KulaniciId { get; set; }

        public int? AracSatisId { get; set; }

        public decimal? TeklifFiyat { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual AracSatis AracSatis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AracSatisDetay> AracSatisDetay { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
