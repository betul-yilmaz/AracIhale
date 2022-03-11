namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BireyselKullanici")]
    public partial class BireyselKullanici
    {
        [Key]
        public int BireyselKulID { get; set; }

        [StringLength(10)]
        public string AdSoyad { get; set; }

        [StringLength(11)]
        public string TC { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
