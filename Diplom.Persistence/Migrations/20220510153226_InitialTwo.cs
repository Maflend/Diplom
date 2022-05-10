using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    public partial class InitialTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "Наушники" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Телефоны" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Телевизоры" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[,]
                {
                    { new Guid("09c398a4-fbd0-424c-a423-a8aab97e9090"), new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "наушники", "", "Samsung", 60m, 40m },
                    { new Guid("23bdc4f9-af5f-4c3e-8363-98a290d02aae"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "телевизор", "", "LG", 350m, 200m },
                    { new Guid("3b22da0c-1894-419f-8634-3b14d5a628d0"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "телевизор", "", "Samsung", 600m, 400m },
                    { new Guid("45f6cbc7-63bc-4a06-a9f0-87abdf8bb2dc"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "телевизор", "", "LG media", 350m, 800m },
                    { new Guid("86fb0ae0-62e6-4955-9be6-0e71b7d5f0a2"), new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "наушники", "", "LG", 35m, 20m },
                    { new Guid("d24a8b23-6e54-4b74-b2ff-79a6a6118b65"), new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "наушники", "", "LG media", 22m, 15m },
                    { new Guid("def4658e-6634-4ef7-9071-18197f597718"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2", "https://cdn.svyaznoy.ru/upload/iblock/989/iphone_11_b_2.jpg/resize/870x725/hq/", "iPhone 11", 54990m, 32000m },
                    { new Guid("fa1c6d1c-6785-44bc-a710-777d7a4d4ca3"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.", "https://static.galaxystore.ru/upload/resize_cache/iblock/0d9/440_440_1/0d93f182dc5448edd34f16b230f328ea.jpg", "Samsung Galaxy S21", 60990m, 39000m },
                    { new Guid("fda49561-07cc-4134-8756-90baa917d57e"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "смартфон", "", "ZTE", 750m, 600m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09c398a4-fbd0-424c-a423-a8aab97e9090"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("23bdc4f9-af5f-4c3e-8363-98a290d02aae"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b22da0c-1894-419f-8634-3b14d5a628d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("45f6cbc7-63bc-4a06-a9f0-87abdf8bb2dc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("86fb0ae0-62e6-4955-9be6-0e71b7d5f0a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d24a8b23-6e54-4b74-b2ff-79a6a6118b65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("def4658e-6634-4ef7-9071-18197f597718"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fa1c6d1c-6785-44bc-a710-777d7a4d4ca3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fda49561-07cc-4134-8756-90baa917d57e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b44ad54-817c-47c2-8344-729915670c73"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"));

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Products");
        }
    }
}
