using Microsoft.EntityFrameworkCore;

namespace ShopVitrin.Models
{
    public class UrunContext : DbContext
    {
        public virtual DbSet<Urun> Urunler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ShopVitrin;Trusted_Connection=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            DummyData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void DummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>().HasData(
                new Urun { UrunId = 1, Isim = "Erkek Beyaz Pantolon", Aciklama = "Donate: If yose conp pay for theour support.", Resim = "Picture/erkek_beyaz_pantolon.png" },
                new Urun { UrunId = 2, Isim = "Erkek Gri Ayakkabı", Aciklama = "ciated - click here to donate using PayPal. Thank you for your support.", Resim = "Picture/erkek_gri_ayakkabı.png" },
                new Urun { UrunId = 3, Isim = "Erkek Gri Pantolon", Aciklama = "Donate: If you use this siting PayPal. Thank you for your support.", Resim = "Picture/erkek_gri_pantolon.png" },
                new Urun { UrunId = 4, Isim = "Erkek Kareli Pantolon", Aciklama = "Donat. Thank you for your support.", Resim = "Picture/erkek_kareli_pantolon.png" },
                new Urun { UrunId = 5, Isim = "Erkek Mavi Hırka", Aciklama = "o donate using PayPal. Thank you for your support.", Resim = "Picture//erkek_mavi_hırka.png" },
                new Urun { UrunId = 6, Isim = "Erkek Tsirt", Aciklama = "Donate: If yated - click here toyour support.", Resim = "Picture/erkek_tsirt.png" },
                new Urun { UrunId = 7, Isim = "Erkek Tsirt Kırmızı", Aciklama = "Donate: If yu for your support.", Resim = "Picture/erkek_tsirt_kırmızı.png" },
                new Urun { UrunId = 8, Isim = "Kadın Çanta Takım", Aciklama = "Do. Thank you for your support.", Resim = "Picture/kadın_çanta_takım.png" },
                new Urun { UrunId = 9, Isim = "Kadın Kot Pantolon", Aciklama = "Donate: If you use this site regular pport.", Resim = "Picture/kadın_kot_pantolon.png" },
                new Urun { UrunId = 10, Isim = "Kadın Kot Siyah", Aciklama = "Donate: click here to donate using PayPal. Thank you for your support.", Resim = "Picture/kadın_kot_siyah.png" },
                new Urun { UrunId = 11, Isim = "Kadın Turuncu Hırka", Aciklama = "Dona your support.", Resim = "Picture/kadın_turuncu_hırka.png" },
                new Urun { UrunId = 12, Isim = "Kulaklık", Aciklama = "Donate:  hany sum is appreciated - click here to donate using PayPal. Thank you for your support.", Resim = "Picture/kulaklık.png" }
                 );
        }
    }
}
