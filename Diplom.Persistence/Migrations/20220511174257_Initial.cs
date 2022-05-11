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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                values: new object[] { new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Наушники" });

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
                    { new Guid("1ede832d-9992-45e4-ab46-3feae3330a6a"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "LED-телевизор LG 49UK6200PLA с экраном диагональю 49 дюймов органично впишется в интерьер столовой, спальни или гостиной. Поддержка Ultra HD 4K с разрешением 3840х2160 делает картинку максимально реалистичной и детальной.", "https://items.s1.citilink.ru/1092279_v01_b.jpg", "LG 49UK6200PLA", 57990m, 36000m },
                    { new Guid("22845414-8f7a-4487-9403-f7efe135f0fd"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Цвет, в котором выполнен телевизор SAMSUNG UE50AU8000UXRU, - универсальный черный. В этом цвете выполнены рамка и подставка, поэтому устройство отличается нейтральным внешним видом и способно вписаться в любой интерьер. Оно выпущено в 2021-м году и обладает подсветкой Direct LED. Диагональ экрана равна 50 дюймам, что в пересчете равно целым 125 см.", "https://items.s1.citilink.ru/1529485_v01_b.jpg", "Samsung UE50AU8000UXRU", 35000m, 57990m },
                    { new Guid("4850b48f-51f7-4244-9bd7-aaab9830639a"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Телевизор LED LG 32 оснащен четырехъядерным процессором, работающим быстро и бесшумно.С его помощью обеспечиваются более динамичная цветопередача и контрастность, обработка изображений, автоматическая коррекция цвета.Изображение становится более насыщенным и естественным.Картинки с низким разрешением масштабируются и восстанавливаются.", "https://items.s1.citilink.ru/1140679_v01_b.jpg", "LG 32LM6350PLA", 34990m, 20000m },
                    { new Guid("6c4f9271-d9d4-4ffa-ad67-81f854fe65c7"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.", "https://items.s1.citilink.ru/1659651_v01_b.jpg", "Samsung Galaxy S21", 60990m, 39000m },
                    { new Guid("a476254b-46ac-41f8-b1b6-5ebd4e265b0d"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Операционная система: Android Q Go. Дисплей: 6TFT. Разрешение дисплея: 960x480. Процессор: Spreadtrum SC7731E,1300МГц,4 - х ядерный. Объем оперативной памяти: 1 ГБ. Объем встроенной памяти: 32 ГБ.", "https://items.s1.citilink.ru/1433141_v01_b.jpg", "ZTE Blade L210", 5100m, 3000m },
                    { new Guid("aec518f2-a013-44ad-b2c0-62365a800dfa"), new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Audio-Tecnica ATH-MSR7B – проводные наушники, совместимые с большинством проигрывающих устройств, в том числе самыми современными. Данная модель обладает малым весом, а амбушюры и оголовье из пенного наполнителя не создают давления на голову и уши, благодаря чему наслаждаться любимыми мелодиями можно много часов подряд.", "https://items.s1.citilink.ru/1141533_v01_b.jpg", "Audio-Technica ATH-MSR7BBK", 16990m, 11000m },
                    { new Guid("b583d4f5-bd41-4296-9e86-08495dab7dc0"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2", "https://items.s1.citilink.ru/1429412_v01_b.jpg", "iPhone 11", 54990m, 32000m },
                    { new Guid("d397d96e-8564-4e06-9680-354485b595ff"), new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Наушники KOSS Porta Pro Classic разработаны еще в восьмидесятых, но они до сих пор не сдают свои позиции и остаются популярными среди меломанов. Все благодаря высокому качеству звука. Небольшие динамики выдают насыщенные басы, от которых дрожат внутренности.", "https://items.s1.citilink.ru/490813_v01_b.jpg", "Koss Porta Pro Classic", 3990m, 1500m },
                    { new Guid("e1752711-8d09-4e73-952d-518af4bb80ab"), new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Профессиональные наушники с широким диапазоном воспроизводимых частот – AUDIO-TECHNICA ATH-M50X. Данная модель отличается строгим технологичным дизайном. Длина кабеля 3 м позволяет с комфортом расположиться в студии или за диджейским пультом. Провод можно отсоединять и при необходимости менять на другой.", "https://items.s1.citilink.ru/1048584_v01_b.jpg", "Audio-Technica ATH-M50X", 25490m, 8000m }
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
