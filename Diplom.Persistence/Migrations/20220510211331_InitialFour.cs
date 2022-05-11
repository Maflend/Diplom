using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    public partial class InitialFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09c36ac1-848c-490e-a79a-2871f80374e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15a811e7-ee5a-4597-b548-9e4755af9c95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("387ad23f-a5f4-4fe2-ac8e-c29436d65de5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("46d756ae-de47-42de-9d9b-8b2cf1913084"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48986475-8e37-47e2-916b-f01c70b3305a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5987d50a-9e73-4106-af87-78ebd90f6378"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7ccd4b58-292f-424e-8d88-6cc118e6bdec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c74a8644-1fe1-4596-8010-1fed4de51b92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f397843c-9ff5-4f6d-85a9-0e2b0e941e18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Наушники" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[,]
                {
                    { new Guid("62fbf839-9416-49e7-99e4-29856df0b509"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Телевизор LED LG 32 оснащен четырехъядерным процессором, работающим быстро и бесшумно.С его помощью обеспечиваются более динамичная цветопередача и контрастность, обработка изображений, автоматическая коррекция цвета.Изображение становится более насыщенным и естественным.Картинки с низким разрешением масштабируются и восстанавливаются.", "https://items.s1.citilink.ru/1140679_v01_b.jpg", "LG 32LM6350PLA", 34990m, 20000m },
                    { new Guid("6b9bff08-5e8e-4505-8b35-39faad4f49d2"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Операционная система: Android Q Go. Дисплей: 6TFT. Разрешение дисплея: 960x480. Процессор: Spreadtrum SC7731E,1300МГц,4 - х ядерный. Объем оперативной памяти: 1 ГБ. Объем встроенной памяти: 32 ГБ.", "https://items.s1.citilink.ru/1433141_v01_b.jpg", "ZTE Blade L210", 5100m, 3000m },
                    { new Guid("8cf5c0db-ad0e-463d-9b59-f3adb186ac64"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2", "https://items.s1.citilink.ru/1429412_v01_b.jpg", "iPhone 11", 54990m, 32000m },
                    { new Guid("9577f90c-f370-479e-9011-30d2e1dfa89c"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.", "https://items.s1.citilink.ru/1659651_v01_b.jpg", "Samsung Galaxy S21", 60990m, 39000m },
                    { new Guid("ac7f7b99-46b4-4ba1-a586-1054406da995"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Цвет, в котором выполнен телевизор SAMSUNG UE50AU8000UXRU, - универсальный черный. В этом цвете выполнены рамка и подставка, поэтому устройство отличается нейтральным внешним видом и способно вписаться в любой интерьер. Оно выпущено в 2021-м году и обладает подсветкой Direct LED. Диагональ экрана равна 50 дюймам, что в пересчете равно целым 125 см.", "https://items.s1.citilink.ru/1529485_v01_b.jpg", "Samsung UE50AU8000UXRU", 35000m, 57990m },
                    { new Guid("f7edfb58-4842-4b4d-9563-e8fe4626fc1a"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "LED-телевизор LG 49UK6200PLA с экраном диагональю 49 дюймов органично впишется в интерьер столовой, спальни или гостиной. Поддержка Ultra HD 4K с разрешением 3840х2160 делает картинку максимально реалистичной и детальной.", "https://items.s1.citilink.ru/1092279_v01_b.jpg", "LG 49UK6200PLA", 57990m, 36000m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[] { new Guid("003c1506-ac20-436f-a4ad-568d4474857d"), new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Профессиональные наушники с широким диапазоном воспроизводимых частот – AUDIO-TECHNICA ATH-M50X. Данная модель отличается строгим технологичным дизайном. Длина кабеля 3 м позволяет с комфортом расположиться в студии или за диджейским пультом. Провод можно отсоединять и при необходимости менять на другой.", "https://items.s1.citilink.ru/1048584_v01_b.jpg", "Audio-Technica ATH-M50X", 25490m, 8000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[] { new Guid("0e801de3-43db-4ac5-886e-01f0ce6f9f57"), new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Наушники KOSS Porta Pro Classic разработаны еще в восьмидесятых, но они до сих пор не сдают свои позиции и остаются популярными среди меломанов. Все благодаря высокому качеству звука. Небольшие динамики выдают насыщенные басы, от которых дрожат внутренности.", "https://items.s1.citilink.ru/490813_v01_b.jpg", "Koss Porta Pro Classic", 3990m, 1500m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[] { new Guid("c74d342e-5eb6-4523-b3bd-e00cd5de7c98"), new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"), "Audio-Tecnica ATH-MSR7B – проводные наушники, совместимые с большинством проигрывающих устройств, в том числе самыми современными. Данная модель обладает малым весом, а амбушюры и оголовье из пенного наполнителя не создают давления на голову и уши, благодаря чему наслаждаться любимыми мелодиями можно много часов подряд.", "https://items.s1.citilink.ru/1141533_v01_b.jpg", "Audio-Technica ATH-MSR7BBK", 16990m, 11000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("003c1506-ac20-436f-a4ad-568d4474857d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e801de3-43db-4ac5-886e-01f0ce6f9f57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("62fbf839-9416-49e7-99e4-29856df0b509"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b9bff08-5e8e-4505-8b35-39faad4f49d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cf5c0db-ad0e-463d-9b59-f3adb186ac64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9577f90c-f370-479e-9011-30d2e1dfa89c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac7f7b99-46b4-4ba1-a586-1054406da995"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c74d342e-5eb6-4523-b3bd-e00cd5de7c98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f7edfb58-4842-4b4d-9563-e8fe4626fc1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "Наушники" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[,]
                {
                    { new Guid("09c36ac1-848c-490e-a79a-2871f80374e6"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Телевизор LED LG 32 оснащен четырехъядерным процессором, работающим быстро и бесшумно.С его помощью обеспечиваются более динамичная цветопередача и контрастность, обработка изображений, автоматическая коррекция цвета.Изображение становится более насыщенным и естественным.Картинки с низким разрешением масштабируются и восстанавливаются.", "https://items.s1.citilink.ru/1140679_v01_b.jpg", "LG 32LM6350PLA", 34990m, 20000m },
                    { new Guid("387ad23f-a5f4-4fe2-ac8e-c29436d65de5"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.", "https://items.s1.citilink.ru/1659651_v01_b.jpg", "Samsung Galaxy S21", 60990m, 39000m },
                    { new Guid("46d756ae-de47-42de-9d9b-8b2cf1913084"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "LED-телевизор LG 49UK6200PLA с экраном диагональю 49 дюймов органично впишется в интерьер столовой, спальни или гостиной. Поддержка Ultra HD 4K с разрешением 3840х2160 делает картинку максимально реалистичной и детальной.", "https://items.s1.citilink.ru/1092279_v01_b.jpg", "LG 49UK6200PLA", 57990m, 36000m },
                    { new Guid("48986475-8e37-47e2-916b-f01c70b3305a"), new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"), "Цвет, в котором выполнен телевизор SAMSUNG UE50AU8000UXRU, - универсальный черный. В этом цвете выполнены рамка и подставка, поэтому устройство отличается нейтральным внешним видом и способно вписаться в любой интерьер. Оно выпущено в 2021-м году и обладает подсветкой Direct LED. Диагональ экрана равна 50 дюймам, что в пересчете равно целым 125 см.", "https://items.s1.citilink.ru/1529485_v01_b.jpg", "Samsung UE50AU8000UXRU", 35000m, 57990m },
                    { new Guid("5987d50a-9e73-4106-af87-78ebd90f6378"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Операционная система: Android Q Go. Дисплей: 6TFT. Разрешение дисплея: 960x480. Процессор: Spreadtrum SC7731E,1300МГц,4 - х ядерный. Объем оперативной памяти: 1 ГБ. Объем встроенной памяти: 32 ГБ.", "https://items.s1.citilink.ru/1433141_v01_b.jpg", "ZTE Blade L210", 5100m, 3000m },
                    { new Guid("7ccd4b58-292f-424e-8d88-6cc118e6bdec"), new Guid("9b44ad54-817c-47c2-8344-729915670c73"), "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2", "https://items.s1.citilink.ru/1429412_v01_b.jpg", "iPhone 11", 54990m, 32000m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[] { new Guid("15a811e7-ee5a-4597-b548-9e4755af9c95"), new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "Audio-Tecnica ATH-MSR7B – проводные наушники, совместимые с большинством проигрывающих устройств, в том числе самыми современными. Данная модель обладает малым весом, а амбушюры и оголовье из пенного наполнителя не создают давления на голову и уши, благодаря чему наслаждаться любимыми мелодиями можно много часов подряд.", "https://items.s1.citilink.ru/1141533_v01_b.jpg", "Audio-Technica ATH-MSR7BBK", 16990m, 11000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[] { new Guid("c74a8644-1fe1-4596-8010-1fed4de51b92"), new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "Наушники KOSS Porta Pro Classic разработаны еще в восьмидесятых, но они до сих пор не сдают свои позиции и остаются популярными среди меломанов. Все благодаря высокому качеству звука. Небольшие динамики выдают насыщенные басы, от которых дрожат внутренности.", "https://items.s1.citilink.ru/490813_v01_b.jpg", "Koss Porta Pro Classic", 3990m, 1500m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "PurchasePrice" },
                values: new object[] { new Guid("f397843c-9ff5-4f6d-85a9-0e2b0e941e18"), new Guid("7ef0c053-2ebe-47b3-8dd0-e9462ab083ff"), "Профессиональные наушники с широким диапазоном воспроизводимых частот – AUDIO-TECHNICA ATH-M50X. Данная модель отличается строгим технологичным дизайном. Длина кабеля 3 м позволяет с комфортом расположиться в студии или за диджейским пультом. Провод можно отсоединять и при необходимости менять на другой.", "https://items.s1.citilink.ru/1048584_v01_b.jpg", "Audio-Technica ATH-M50X", 25490m, 8000m });
        }
    }
}
