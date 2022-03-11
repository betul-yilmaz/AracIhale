namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AracOzellik")]
    public partial class AracOzellik
    {
        public int AracOzellikID { get; set; }

        public int? AracID { get; set; }

        public int? OzellikDetayID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual OzellikDetay OzellikDetay { get; set; }
    }
}
