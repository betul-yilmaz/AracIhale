namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracSatisDetay")]
    public partial class AracSatisDetay
    {
        public int AracSatisDetayId { get; set; }

        public int? AracSatisId { get; set; }

        public int? AracSatisTeklifID { get; set; }

        public int? StatuId { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual AracSatis AracSatis { get; set; }

        public virtual AracSatisTeklif AracSatisTeklif { get; set; }
    }
}
