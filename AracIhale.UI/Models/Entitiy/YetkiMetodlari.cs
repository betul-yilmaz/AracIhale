namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YetkiMetodlari")]
    public partial class YetkiMetodlari
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YetkiMetodlari()
        {
            Yetki = new HashSet<Yetki>();
        }

        public int YetkiMetodlariID { get; set; }

        [StringLength(250)]
        public string MethodAdi { get; set; }

        public string Aciklama { get; set; }

        public int? YetkiKatagoriID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yetki> Yetki { get; set; }

        public virtual YetkiKatagori YetkiKatagori { get; set; }
    }
}
