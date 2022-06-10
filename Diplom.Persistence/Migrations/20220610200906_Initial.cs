using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "varchar", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ImgUrl = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "numeric", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Телефоны" },
                    { new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Телевизоры" },
                    { new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"), "Наушники" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "PasswordHash", "PasswordSalt", "Role", "UserName" },
                values: new object[,]
                {
                    { new Guid("2d89eae5-1de9-4c83-bd86-9b332eb61e24"), 21, new byte[] { 169, 102, 245, 81, 29, 23, 111, 245, 187, 222, 16, 230, 186, 92, 118, 33, 26, 201, 113, 124, 196, 186, 192, 114, 254, 41, 152, 159, 87, 180, 238, 83, 166, 77, 16, 118, 28, 130, 171, 166, 122, 240, 137, 218, 184, 156, 102, 193, 46, 26, 244, 135, 49, 130, 82, 193, 32, 112, 76, 132, 179, 168, 156, 5 }, new byte[] { 5, 14, 180, 192, 178, 190, 142, 252, 10, 221, 106, 192, 56, 9, 1, 156, 63, 155, 206, 229, 32, 230, 161, 148, 10, 219, 120, 190, 198, 55, 199, 33, 240, 90, 132, 114, 230, 142, 143, 209, 83, 55, 77, 162, 181, 53, 149, 99, 147, 67, 144, 142, 168, 34, 17, 189, 154, 21, 114, 10, 155, 38, 128, 252, 189, 179, 245, 165, 123, 33, 205, 40, 224, 92, 41, 52, 169, 23, 254, 171, 123, 104, 236, 148, 181, 230, 137, 114, 224, 27, 186, 19, 40, 45, 135, 123, 14, 161, 107, 15, 113, 88, 119, 150, 15, 148, 159, 119, 56, 209, 136, 97, 28, 43, 45, 89, 5, 26, 67, 129, 116, 209, 37, 251, 254, 221, 163, 32 }, "Administrator", "Admin" },
                    { new Guid("bdb4bdf9-685b-4d93-9542-b3d0e8983803"), 21, new byte[] { 134, 28, 250, 79, 30, 43, 101, 89, 15, 78, 181, 69, 205, 34, 207, 240, 186, 135, 201, 75, 108, 13, 22, 231, 194, 111, 126, 47, 112, 78, 88, 35, 52, 231, 239, 83, 190, 134, 82, 207, 82, 27, 243, 136, 45, 25, 108, 145, 26, 91, 55, 186, 150, 148, 217, 53, 52, 178, 246, 188, 255, 245, 142, 230 }, new byte[] { 147, 248, 234, 111, 105, 96, 137, 214, 117, 197, 213, 244, 243, 212, 48, 206, 39, 85, 27, 242, 35, 167, 128, 232, 65, 201, 96, 168, 193, 28, 195, 163, 233, 88, 240, 107, 163, 54, 138, 161, 148, 110, 231, 89, 39, 189, 151, 159, 223, 88, 126, 87, 114, 173, 204, 212, 73, 162, 174, 146, 239, 237, 21, 188, 136, 67, 210, 181, 162, 217, 71, 136, 84, 126, 132, 255, 167, 213, 231, 119, 140, 36, 251, 240, 174, 227, 65, 193, 136, 77, 69, 24, 93, 136, 25, 250, 81, 87, 126, 167, 132, 74, 57, 224, 168, 64, 172, 225, 155, 189, 57, 89, 53, 176, 148, 133, 122, 56, 216, 73, 114, 202, 87, 65, 50, 18, 41, 133 }, "Client", "Client" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[,]
                {
                    { new Guid("3e99ba2c-e14a-4abf-a0db-5bdd50472c06"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Операционная система: Android Q Go. Дисплей: 6TFT. Разрешение дисплея: 960x480. Процессор: Spreadtrum SC7731E,1300МГц,4 - х ядерный. Объем оперативной памяти: 1 ГБ. Объем встроенной памяти: 32 ГБ.", "https://items.s1.citilink.ru/1433141_v01_b.jpg", "ZTE Blade L210", 5100m, 3000m },
                    { new Guid("45637122-7766-4b6d-91c4-b0dadd227e2c"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Цвет, в котором выполнен телевизор SAMSUNG UE50AU8000UXRU, - универсальный черный. В этом цвете выполнены рамка и подставка, поэтому устройство отличается нейтральным внешним видом и способно вписаться в любой интерьер. Оно выпущено в 2021-м году и обладает подсветкой Direct LED. Диагональ экрана равна 50 дюймам, что в пересчете равно целым 125 см.", "https://items.s1.citilink.ru/1529485_v01_b.jpg", "Samsung UE50AU8000UXRU", 35000m, 57990m },
                    { new Guid("4cabc0d8-5e81-4f2b-ac10-e13bbcd9061c"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2", "https://items.s1.citilink.ru/1429412_v01_b.jpg", "iPhone 11", 54990m, 32000m },
                    { new Guid("5d0e2a44-7649-4c1f-83d2-da59c265918f"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "LED-телевизор LG 49UK6200PLA с экраном диагональю 49 дюймов органично впишется в интерьер столовой, спальни или гостиной. Поддержка Ultra HD 4K с разрешением 3840х2160 делает картинку максимально реалистичной и детальной.", "https://items.s1.citilink.ru/1092279_v01_b.jpg", "LG 49UK6200PLA", 57990m, 36000m },
                    { new Guid("8953513d-638e-41d2-a0a5-8f93c4d8d409"), new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"), "Audio-Tecnica ATH-MSR7B – проводные наушники, совместимые с большинством проигрывающих устройств, в том числе самыми современными. Данная модель обладает малым весом, а амбушюры и оголовье из пенного наполнителя не создают давления на голову и уши, благодаря чему наслаждаться любимыми мелодиями можно много часов подряд.", "https://items.s1.citilink.ru/1141533_v01_b.jpg", "Audio-Technica ATH-MSR7BBK", 16990m, 11000m },
                    { new Guid("9c364cbd-589b-40db-b8e8-801d3be55620"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Телевизор LED LG 32 оснащен четырехъядерным процессором, работающим быстро и бесшумно.С его помощью обеспечиваются более динамичная цветопередача и контрастность, обработка изображений, автоматическая коррекция цвета.Изображение становится более насыщенным и естественным.Картинки с низким разрешением масштабируются и восстанавливаются.", "https://items.s1.citilink.ru/1140679_v01_b.jpg", "LG 32LM6350PLA", 34990m, 20000m },
                    { new Guid("deec1ff7-eb51-4885-ab7a-860b4d34489e"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.", "https://items.s1.citilink.ru/1659651_v01_b.jpg", "Samsung Galaxy S21", 60990m, 39000m },
                    { new Guid("ea106943-7733-453b-b208-c7428d33ca16"), new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"), "Профессиональные наушники с широким диапазоном воспроизводимых частот – AUDIO-TECHNICA ATH-M50X. Данная модель отличается строгим технологичным дизайном. Длина кабеля 3 м позволяет с комфортом расположиться в студии или за диджейским пультом. Провод можно отсоединять и при необходимости менять на другой.", "https://items.s1.citilink.ru/1048584_v01_b.jpg", "Audio-Technica ATH-M50X", 25490m, 8000m },
                    { new Guid("f0ea7390-a574-43db-9d9b-54c27198e0a8"), new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"), "Наушники KOSS Porta Pro Classic разработаны еще в восьмидесятых, но они до сих пор не сдают свои позиции и остаются популярными среди меломанов. Все благодаря высокому качеству звука. Небольшие динамики выдают насыщенные басы, от которых дрожат внутренности.", "https://items.s1.citilink.ru/490813_v01_b.jpg", "Koss Porta Pro Classic", 3990m, 1500m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Id",
                table: "Categories",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Id",
                table: "Orders",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Id",
                table: "Products",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Id",
                table: "Sales",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_OrderId",
                table: "Sales",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Id",
                table: "Users",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
