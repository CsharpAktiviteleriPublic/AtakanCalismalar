using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopVitrin.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunId);
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "UrunId", "Aciklama", "Isim", "Resim" },
                values: new object[,]
                {
                    { 1, "Donate: If yose conp pay for theour support.", "Erkek Beyaz Pantolon", "Picture/erkek_beyaz_pantolon.png" },
                    { 2, "ciated - click here to donate using PayPal. Thank you for your support.", "Erkek Gri Ayakkabı", "Picture/erkek_gri_ayakkabı.png" },
                    { 3, "Donate: If you use this siting PayPal. Thank you for your support.", "Erkek Gri Pantolon", "Picture/erkek_gri_pantolon.png" },
                    { 4, "Donat. Thank you for your support.", "Erkek Kareli Pantolon", "Picture/erkek_kareli_pantolon.png" },
                    { 5, "o donate using PayPal. Thank you for your support.", "Erkek Mavi Hırka", "Picture//erkek_mavi_hırka.png" },
                    { 6, "Donate: If yated - click here toyour support.", "Erkek Tsirt", "Picture/erkek_tsirt.png" },
                    { 7, "Donate: If yu for your support.", "Erkek Tsirt Kırmızı", "Picture/erkek_tsirt_kırmızı.png" },
                    { 8, "Do. Thank you for your support.", "Kadın Çanta Takım", "Picture/kadın_çanta_takım.png" },
                    { 9, "Donate: If you use this site regular pport.", "Kadın Kot Pantolon", "Picture/kadın_kot_pantolon.png" },
                    { 10, "Donate: click here to donate using PayPal. Thank you for your support.", "Kadın Kot Siyah", "Picture/kadın_kot_siyah.png" },
                    { 11, "Dona your support.", "Kadın Turuncu Hırka", "Picture/kadın_turuncu_hırka.png" },
                    { 12, "Donate:  hany sum is appreciated - click here to donate using PayPal. Thank you for your support.", "Kulaklık", "Picture/kulaklık.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");
        }
    }
}
