namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KomisyonUcret")]
    public partial class KomisyonUcret
    {
        public int KomisyonUcretId { get; set; }

        public DateTime? BaslangicTarih { get; set; }

        public DateTime? BitisTarih { get; set; }

        public decimal? MinFiyat { get; set; }

        public decimal? MaxFiyat { get; set; }

        public decimal? Komisyon { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }
    }
}
