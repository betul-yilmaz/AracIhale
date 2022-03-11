using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AracIhale.UI
{
    public partial class MyAracIhaleEntities : DbContext
    {
        public MyAracIhaleEntities()
            : base("name=MyAracIhaleEntities")
        {
        }

        public virtual DbSet<Arac> Arac { get; set; }
        public virtual DbSet<AracGorsel> AracGorsel { get; set; }
        public virtual DbSet<AracOzellik> AracOzellik { get; set; }
        public virtual DbSet<AracSatis> AracSatis { get; set; }
        public virtual DbSet<AracSatisDetay> AracSatisDetay { get; set; }
        public virtual DbSet<AracSatisTeklif> AracSatisTeklif { get; set; }
        public virtual DbSet<AracTramerDetay> AracTramerDetay { get; set; }
        public virtual DbSet<AracTramerUcret> AracTramerUcret { get; set; }
        public virtual DbSet<BireyselKullanici> BireyselKullanici { get; set; }
        public virtual DbSet<Ekspertiz> Ekspertiz { get; set; }
        public virtual DbSet<Firma> Firma { get; set; }
        public virtual DbSet<Ihale> Ihale { get; set; }
        public virtual DbSet<IhaleArac> IhaleArac { get; set; }
        public virtual DbSet<IhaleTeklif> IhaleTeklif { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }
        public virtual DbSet<IletisimTipi> IletisimTipi { get; set; }
        public virtual DbSet<KomisyonUcret> KomisyonUcret { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KurumsalKullanici> KurumsalKullanici { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Model> Model { get; set; }
        public virtual DbSet<NoterUcret> NoterUcret { get; set; }
        public virtual DbSet<Ozellik> Ozellik { get; set; }
        public virtual DbSet<OzellikDetay> OzellikDetay { get; set; }
        public virtual DbSet<Paket> Paket { get; set; }
        public virtual DbSet<PaketDetay> PaketDetay { get; set; }
        public virtual DbSet<Personel> Personel { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<SatisHesaplama> SatisHesaplama { get; set; }
        public virtual DbSet<Statu> Statu { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tramer> Tramer { get; set; }
        public virtual DbSet<TramerTipi> TramerTipi { get; set; }
        public virtual DbSet<UyeTip> UyeTip { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }
        public virtual DbSet<YetkiKatagori> YetkiKatagori { get; set; }
        public virtual DbSet<YetkiMetodlari> YetkiMetodlari { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AracTramerUcret>()
                .Property(e => e.Fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<BireyselKullanici>()
                .Property(e => e.AdSoyad)
                .IsFixedLength();

            modelBuilder.Entity<BireyselKullanici>()
                .Property(e => e.TC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Firma>()
                .Property(e => e.FirmaAdi)
                .IsFixedLength();

            modelBuilder.Entity<IhaleArac>()
                .Property(e => e.BaslangicFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<IhaleArac>()
                .Property(e => e.MinimumAlimFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<IhaleTeklif>()
                .Property(e => e.TeklifFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.AracSatisTeklif)
                .WithOptional(e => e.Kullanici)
                .HasForeignKey(e => e.KulaniciId);

            modelBuilder.Entity<KurumsalKullanici>()
                .Property(e => e.TC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Marka>()
                .HasMany(e => e.Model)
                .WithRequired(e => e.Marka)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Personel>()
                .Property(e => e.TC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SatisHesaplama>()
                .Property(e => e.NoterUcret)
                .IsFixedLength();

            modelBuilder.Entity<UyeTip>()
                .HasMany(e => e.Statu)
                .WithOptional(e => e.UyeTip)
                .HasForeignKey(e => e.UyeTipAciklamaID);

            modelBuilder.Entity<YetkiMetodlari>()
                .HasMany(e => e.Yetki)
                .WithOptional(e => e.YetkiMetodlari)
                .HasForeignKey(e => e.YetkiMetodID);
        }
        public virtual int SaveChanges(int? userid = null)
        {
            var entries = ChangeTracker.Entries().Where(e => e.State == EntityState.Added || e.State == EntityState.Modified || e.State == EntityState.Deleted);

            var logList = new List<Log>();

            foreach (var entityEntry in entries)
            {
                //string yeniParametreler = "";

                Log Log1 = new Log()
                {
                    CreatedDate = DateTime.Now,
                    TabloAdi = entityEntry.Entity.GetType().Name,
                    Islem = entityEntry.State.ToString(),
                    KullaniciID = userid
                };

                //foreach (var item in entityEntry.CurrentValues.PropertyNames)
                //{
                //    var currentVal = entityEntry.CurrentValues[item].ToString();
                //    yeniParametreler += item + ":" + currentVal + ",";
                //}

                //Log1.Parametreler = yeniParametreler;
                Log.Add(Log1);
            }

            return base.SaveChanges();
        }
    }
}
