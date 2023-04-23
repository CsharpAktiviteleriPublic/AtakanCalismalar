namespace ShopVitrin.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string Isim { get; set; } = null!;
        public string? Aciklama { get; set; }
        public string? Resim { get; set; } = "Picture/kulaklık.png"; //default
    }
}

