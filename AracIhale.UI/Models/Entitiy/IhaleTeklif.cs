namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IhaleTeklif")]
    public partial class IhaleTeklif
    {
        public int IhaleTeklifId { get; set; }

        public int? IhaleAracId { get; set; }

        public int? KullaniciId { get; set; }

        [Column(TypeName = "money")]
        public decimal? TeklifFiyat { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual IhaleArac IhaleArac { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
