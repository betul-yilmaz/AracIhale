namespace AracIhale.UI
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Personel")]
    public partial class Personel
    {
        public int PersonelID { get; set; }

        public int? KullaniciID { get; set; }

        [StringLength(250)]
        public string AdSoyad { get; set; }

        [StringLength(11)]
        public string TC { get; set; }

        public virtual Kullanici Kullanici { get; set; }
    }
}
