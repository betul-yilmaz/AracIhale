namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ekspertiz")]
    public partial class Ekspertiz
    {
        public int EkspertizId { get; set; }

        public string Ad { get; set; }

        public string Adres { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(11)]
        public string Telefon { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }
    }
}
