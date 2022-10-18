using Diplom.Application.Abstracts.IServices;
using Diplom.Domain.Entities;
using Diplom.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Diplom.Persistence;

public class SeedingService : ISeedingService
{
    private readonly IUserService _userService;

    public SeedingService(IUserService userService)
    {
        _userService = userService;
    }

    /// <summary>
    /// Заполнить БД начальными данными.
    /// </summary>
    /// <param name="modelBuilder"></param>
    public void Initialized(ModelBuilder modelBuilder)
    {
        InitialCategories(modelBuilder);
        InitialProducts(modelBuilder);
        InitialUsers(modelBuilder);
    }

    /// <summary>
    /// Данные для пользователей.
    /// </summary>
    /// <param name="modelBuilder"></param>
    public void InitialUsers(ModelBuilder modelBuilder)
    {
        _userService.CreatePasswordHash("Administrator", out byte[] passwordHash1, out byte[] passwordSalt1);
        _userService.CreatePasswordHash("Client", out byte[] passwordHash2, out byte[] passwordSalt2);

        modelBuilder.Entity<User>().HasData(
            new User()
            {
                UserName = "Admin",
                Age = 21,
                Role = RoleEnum.Administrator,
                PasswordHash = passwordHash1,
                PasswordSalt = passwordSalt1
            },
            new User()
            {
                UserName = "Client",
                Age = 21,
                Role = RoleEnum.Client,
                PasswordHash = passwordHash2,
                PasswordSalt = passwordSalt2
            }
            );
    }

    /// <summary>
    /// Данные для категорий.
    /// </summary>
    /// <param name="modelBuilder"></param>
    private void InitialCategories(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category()
            {
                Id = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                Name = "Телефоны"
            },
            new Category()
            {
                Id = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                Name = "Телевизоры"
            },
            new Category()
            {
                Id = new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"),
                Name = "Наушники"
            }
            );

    }

    /// <summary>
    /// Данные для продуктов.
    /// </summary>
    /// <param name="modelBuilder"></param>
    private void InitialProducts(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            // Телефоны
            new Product()
            {
                Name = "iPhone 11",
                Description = "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2",
                ImgUrl = "https://items.s1.citilink.ru/1429412_v01_b.jpg",
                PurchasePrice = 32000,
                Price = 54990,
                CategoryId = Guid.Parse("9b44ad54-817c-47c2-8344-729915670c73")
            },
            new Product()
            {
                Name = "Samsung Galaxy S21",
                Description = "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.",
                ImgUrl = "https://items.s1.citilink.ru/1659651_v01_b.jpg",
                PurchasePrice = 39000,
                Price = 60990,
                CategoryId = Guid.Parse("9b44ad54-817c-47c2-8344-729915670c73")
            },
            new Product()
            {
                Name = "ZTE Blade L210",
                Description = "Операционная система: Android Q Go. Дисплей: 6TFT. Разрешение дисплея: 960x480. Процессор: Spreadtrum SC7731E,1300МГц,4 - х ядерный. Объем оперативной памяти: 1 ГБ. Объем встроенной памяти: 32 ГБ.",
                ImgUrl = "https://items.s1.citilink.ru/1433141_v01_b.jpg",
                PurchasePrice = 3000,
                Price = 5100,
                CategoryId = Guid.Parse("9b44ad54-817c-47c2-8344-729915670c73")
            },
            // Телевизоры
            new Product()
            {
                Name = "LG 49UK6200PLA",
                Description = "LED-телевизор LG 49UK6200PLA с экраном диагональю 49 дюймов органично впишется в интерьер столовой, спальни или гостиной. Поддержка Ultra HD 4K с разрешением 3840х2160 делает картинку максимально реалистичной и детальной.",
                ImgUrl = "https://items.s1.citilink.ru/1092279_v01_b.jpg",
                PurchasePrice = 36000,
                Price = 57990,
                CategoryId = Guid.Parse("e90e97a3-cf8c-496e-8db4-55049d15fe99")
            },
            new Product()
            {
                Name = "Samsung UE50AU8000UXRU",
                Description = "Цвет, в котором выполнен телевизор SAMSUNG UE50AU8000UXRU, - универсальный черный. В этом цвете выполнены рамка и подставка, поэтому устройство отличается нейтральным внешним видом и способно вписаться в любой интерьер. Оно выпущено в 2021-м году и обладает подсветкой Direct LED. Диагональ экрана равна 50 дюймам, что в пересчете равно целым 125 см.",
                ImgUrl = "https://items.s1.citilink.ru/1529485_v01_b.jpg",
                PurchasePrice = 57990,
                Price = 35000,
                CategoryId = Guid.Parse("e90e97a3-cf8c-496e-8db4-55049d15fe99")
            },
            new Product()
            {
                Name = "LG 32LM6350PLA",
                Description = "Телевизор LED LG 32 оснащен четырехъядерным процессором, работающим быстро и бесшумно.С его помощью обеспечиваются более динамичная цветопередача и контрастность, обработка изображений, автоматическая коррекция цвета.Изображение становится более насыщенным и естественным.Картинки с низким разрешением масштабируются и восстанавливаются.",
                ImgUrl = "https://items.s1.citilink.ru/1140679_v01_b.jpg",
                PurchasePrice = 20000,
                Price = 34990,
                CategoryId = Guid.Parse("e90e97a3-cf8c-496e-8db4-55049d15fe99")
            },

            // Наушники
            new Product()
            {
                Name = "Audio-Technica ATH-M50X",
                Description = "Профессиональные наушники с широким диапазоном воспроизводимых частот – AUDIO-TECHNICA ATH-M50X. Данная модель отличается строгим технологичным дизайном. Длина кабеля 3 м позволяет с комфортом расположиться в студии или за диджейским пультом. Провод можно отсоединять и при необходимости менять на другой.",
                ImgUrl = "https://items.s1.citilink.ru/1048584_v01_b.jpg",
                PurchasePrice = 8000,
                Price = 25490,
                CategoryId = Guid.Parse("efe23fe7-21f0-43c8-924b-16eb4736f88a")
            },
            new Product()
            {
                Name = "Koss Porta Pro Classic",
                Description = "Наушники KOSS Porta Pro Classic разработаны еще в восьмидесятых, но они до сих пор не сдают свои позиции и остаются популярными среди меломанов. Все благодаря высокому качеству звука. Небольшие динамики выдают насыщенные басы, от которых дрожат внутренности.",
                ImgUrl = "https://items.s1.citilink.ru/490813_v01_b.jpg",
                PurchasePrice = 1500,
                Price = 3990,
                CategoryId = Guid.Parse("efe23fe7-21f0-43c8-924b-16eb4736f88a")
            },
            new Product()
            {
                Name = "Audio-Technica ATH-MSR7BBK",
                Description = "Audio-Tecnica ATH-MSR7B – проводные наушники, совместимые с большинством проигрывающих устройств, в том числе самыми современными. Данная модель обладает малым весом, а амбушюры и оголовье из пенного наполнителя не создают давления на голову и уши, благодаря чему наслаждаться любимыми мелодиями можно много часов подряд.",
                ImgUrl = "https://items.s1.citilink.ru/1141533_v01_b.jpg",
                PurchasePrice = 11000,
                Price = 16990,
                CategoryId = Guid.Parse("efe23fe7-21f0-43c8-924b-16eb4736f88a")
            }
            );
    }
}
