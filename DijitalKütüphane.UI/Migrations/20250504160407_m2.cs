using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DijitalKütüphane.UI.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Yazarlar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Aciklamasi", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, "Dünya edebiyatında önemli yer edinmiş eserler", "Klasik" },
                    { 2, "Bireysel gelişim ve motivasyon kitapları", "Kişisel Gelişim" },
                    { 3, "Sürükleyici ve aksiyon dolu hikayeler", "Macera" },
                    { 4, "Hayal gücüne dayalı kurgu evrenlerde geçen hikayeler", "Fantastik" },
                    { 5, "Programlama, algoritmalar ve yazılım geliştirme konuları", "Yazılım" },
                    { 6, "İnsan davranışı ve zihin yapısını inceleyen kitaplar", "Psikoloji" },
                    { 7, "Bilimsel temelli hayal gücüyle zenginleştirilmiş eserler", "Bilim Kurgu" },
                    { 8, "Geçmiş olayları anlatan tarihsel içerikler", "Tarih" },
                    { 9, "Gerçek kişilerin yaşam öykülerini anlatan eserler", "Biyografi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Yazarlar");
        }
    }
}
