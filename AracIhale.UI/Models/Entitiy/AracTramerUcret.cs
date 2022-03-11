namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracTramerUcret")]
    public partial class AracTramerUcret
    {
        public int AracTramerUcretId { get; set; }

        public int? AracId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fiyat { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Arac Arac { get; set; }
    }
}
