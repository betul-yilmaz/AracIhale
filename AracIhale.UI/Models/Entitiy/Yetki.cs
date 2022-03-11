namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yetki")]
    public partial class Yetki
    {
        public int YetkiID { get; set; }

        public int? YetkiMetodID { get; set; }

        public int? RolID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public bool? isActive { get; set; }

        public virtual Rol Rol { get; set; }

        public virtual YetkiMetodlari YetkiMetodlari { get; set; }
    }
}
