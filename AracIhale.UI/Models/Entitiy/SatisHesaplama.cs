namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SatisHesaplama")]
    public partial class SatisHesaplama
    {
        public int SatisHesaplamaId { get; set; }

        public int? Komisyon { get; set; }

        [StringLength(10)]
        public string NoterUcret { get; set; }

        public int? AracSatisId { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual AracSatis AracSatis { get; set; }
    }
}
