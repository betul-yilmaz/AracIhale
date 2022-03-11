namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaketDetay")]
    public partial class PaketDetay
    {
        public int PaketDetayId { get; set; }

        public int? PaketId { get; set; }

        public int? FirmaID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Firma Firma { get; set; }

        public virtual Paket Paket { get; set; }
    }
}
