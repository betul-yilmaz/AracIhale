namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KurumsalKullanici")]
    public partial class KurumsalKullanici
    {
        [Key]
        public int KurumsalKulID { get; set; }

        [StringLength(250)]
        public string AdSoyad { get; set; }

        [StringLength(11)]
        public string TC { get; set; }

        public int? FirmaID { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool isActive { get; set; }

        public virtual Firma Firma { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
