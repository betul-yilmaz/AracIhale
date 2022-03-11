namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        public int LogID { get; set; }

        [StringLength(50)]
        public string Islem { get; set; }

        [StringLength(50)]
        public string TabloAdi { get; set; }

        public int? KullaniciID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Parametreler { get; set; }
    }
}
