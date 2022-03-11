namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracTramerDetay")]
    public partial class AracTramerDetay
    {
        public int AracTramerDetayID { get; set; }

        public int? TramerID { get; set; }

        public int? TramerTipID { get; set; }

        public int? AracID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Tramer Tramer { get; set; }

        public virtual TramerTipi TramerTipi { get; set; }
    }
}
