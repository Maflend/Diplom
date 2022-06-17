﻿// <auto-generated />
using System;
using Diplom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    [DbContext(typeof(DiplomContext))]
    [Migration("20220610200906_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Diplom.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                            Name = "Телефоны"
                        },
                        new
                        {
                            Id = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                            Name = "Телевизоры"
                        },
                        new
                        {
                            Id = new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"),
                            Name = "Наушники"
                        });
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4cabc0d8-5e81-4f2b-ac10-e13bbcd9061c"),
                            CategoryId = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                            Description = "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2",
                            ImgUrl = "https://items.s1.citilink.ru/1429412_v01_b.jpg",
                            Name = "iPhone 11",
                            Price = 54990m,
                            PurchasePrice = 32000m
                        },
                        new
                        {
                            Id = new Guid("deec1ff7-eb51-4885-ab7a-860b4d34489e"),
                            CategoryId = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                            Description = "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.",
                            ImgUrl = "https://items.s1.citilink.ru/1659651_v01_b.jpg",
                            Name = "Samsung Galaxy S21",
                            Price = 60990m,
                            PurchasePrice = 39000m
                        },
                        new
                        {
                            Id = new Guid("3e99ba2c-e14a-4abf-a0db-5bdd50472c06"),
                            CategoryId = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                            Description = "Операционная система: Android Q Go. Дисплей: 6TFT. Разрешение дисплея: 960x480. Процессор: Spreadtrum SC7731E,1300МГц,4 - х ядерный. Объем оперативной памяти: 1 ГБ. Объем встроенной памяти: 32 ГБ.",
                            ImgUrl = "https://items.s1.citilink.ru/1433141_v01_b.jpg",
                            Name = "ZTE Blade L210",
                            Price = 5100m,
                            PurchasePrice = 3000m
                        },
                        new
                        {
                            Id = new Guid("5d0e2a44-7649-4c1f-83d2-da59c265918f"),
                            CategoryId = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                            Description = "LED-телевизор LG 49UK6200PLA с экраном диагональю 49 дюймов органично впишется в интерьер столовой, спальни или гостиной. Поддержка Ultra HD 4K с разрешением 3840х2160 делает картинку максимально реалистичной и детальной.",
                            ImgUrl = "https://items.s1.citilink.ru/1092279_v01_b.jpg",
                            Name = "LG 49UK6200PLA",
                            Price = 57990m,
                            PurchasePrice = 36000m
                        },
                        new
                        {
                            Id = new Guid("45637122-7766-4b6d-91c4-b0dadd227e2c"),
                            CategoryId = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                            Description = "Цвет, в котором выполнен телевизор SAMSUNG UE50AU8000UXRU, - универсальный черный. В этом цвете выполнены рамка и подставка, поэтому устройство отличается нейтральным внешним видом и способно вписаться в любой интерьер. Оно выпущено в 2021-м году и обладает подсветкой Direct LED. Диагональ экрана равна 50 дюймам, что в пересчете равно целым 125 см.",
                            ImgUrl = "https://items.s1.citilink.ru/1529485_v01_b.jpg",
                            Name = "Samsung UE50AU8000UXRU",
                            Price = 35000m,
                            PurchasePrice = 57990m
                        },
                        new
                        {
                            Id = new Guid("9c364cbd-589b-40db-b8e8-801d3be55620"),
                            CategoryId = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                            Description = "Телевизор LED LG 32 оснащен четырехъядерным процессором, работающим быстро и бесшумно.С его помощью обеспечиваются более динамичная цветопередача и контрастность, обработка изображений, автоматическая коррекция цвета.Изображение становится более насыщенным и естественным.Картинки с низким разрешением масштабируются и восстанавливаются.",
                            ImgUrl = "https://items.s1.citilink.ru/1140679_v01_b.jpg",
                            Name = "LG 32LM6350PLA",
                            Price = 34990m,
                            PurchasePrice = 20000m
                        },
                        new
                        {
                            Id = new Guid("ea106943-7733-453b-b208-c7428d33ca16"),
                            CategoryId = new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"),
                            Description = "Профессиональные наушники с широким диапазоном воспроизводимых частот – AUDIO-TECHNICA ATH-M50X. Данная модель отличается строгим технологичным дизайном. Длина кабеля 3 м позволяет с комфортом расположиться в студии или за диджейским пультом. Провод можно отсоединять и при необходимости менять на другой.",
                            ImgUrl = "https://items.s1.citilink.ru/1048584_v01_b.jpg",
                            Name = "Audio-Technica ATH-M50X",
                            Price = 25490m,
                            PurchasePrice = 8000m
                        },
                        new
                        {
                            Id = new Guid("f0ea7390-a574-43db-9d9b-54c27198e0a8"),
                            CategoryId = new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"),
                            Description = "Наушники KOSS Porta Pro Classic разработаны еще в восьмидесятых, но они до сих пор не сдают свои позиции и остаются популярными среди меломанов. Все благодаря высокому качеству звука. Небольшие динамики выдают насыщенные басы, от которых дрожат внутренности.",
                            ImgUrl = "https://items.s1.citilink.ru/490813_v01_b.jpg",
                            Name = "Koss Porta Pro Classic",
                            Price = 3990m,
                            PurchasePrice = 1500m
                        },
                        new
                        {
                            Id = new Guid("8953513d-638e-41d2-a0a5-8f93c4d8d409"),
                            CategoryId = new Guid("efe23fe7-21f0-43c8-924b-16eb4736f88a"),
                            Description = "Audio-Tecnica ATH-MSR7B – проводные наушники, совместимые с большинством проигрывающих устройств, в том числе самыми современными. Данная модель обладает малым весом, а амбушюры и оголовье из пенного наполнителя не создают давления на голову и уши, благодаря чему наслаждаться любимыми мелодиями можно много часов подряд.",
                            ImgUrl = "https://items.s1.citilink.ru/1141533_v01_b.jpg",
                            Name = "Audio-Technica ATH-MSR7BBK",
                            Price = 16990m,
                            PurchasePrice = 11000m
                        });
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Sale", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("Diplom.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2d89eae5-1de9-4c83-bd86-9b332eb61e24"),
                            Age = 21,
                            PasswordHash = new byte[] { 169, 102, 245, 81, 29, 23, 111, 245, 187, 222, 16, 230, 186, 92, 118, 33, 26, 201, 113, 124, 196, 186, 192, 114, 254, 41, 152, 159, 87, 180, 238, 83, 166, 77, 16, 118, 28, 130, 171, 166, 122, 240, 137, 218, 184, 156, 102, 193, 46, 26, 244, 135, 49, 130, 82, 193, 32, 112, 76, 132, 179, 168, 156, 5 },
                            PasswordSalt = new byte[] { 5, 14, 180, 192, 178, 190, 142, 252, 10, 221, 106, 192, 56, 9, 1, 156, 63, 155, 206, 229, 32, 230, 161, 148, 10, 219, 120, 190, 198, 55, 199, 33, 240, 90, 132, 114, 230, 142, 143, 209, 83, 55, 77, 162, 181, 53, 149, 99, 147, 67, 144, 142, 168, 34, 17, 189, 154, 21, 114, 10, 155, 38, 128, 252, 189, 179, 245, 165, 123, 33, 205, 40, 224, 92, 41, 52, 169, 23, 254, 171, 123, 104, 236, 148, 181, 230, 137, 114, 224, 27, 186, 19, 40, 45, 135, 123, 14, 161, 107, 15, 113, 88, 119, 150, 15, 148, 159, 119, 56, 209, 136, 97, 28, 43, 45, 89, 5, 26, 67, 129, 116, 209, 37, 251, 254, 221, 163, 32 },
                            Role = "Administrator",
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("bdb4bdf9-685b-4d93-9542-b3d0e8983803"),
                            Age = 21,
                            PasswordHash = new byte[] { 134, 28, 250, 79, 30, 43, 101, 89, 15, 78, 181, 69, 205, 34, 207, 240, 186, 135, 201, 75, 108, 13, 22, 231, 194, 111, 126, 47, 112, 78, 88, 35, 52, 231, 239, 83, 190, 134, 82, 207, 82, 27, 243, 136, 45, 25, 108, 145, 26, 91, 55, 186, 150, 148, 217, 53, 52, 178, 246, 188, 255, 245, 142, 230 },
                            PasswordSalt = new byte[] { 147, 248, 234, 111, 105, 96, 137, 214, 117, 197, 213, 244, 243, 212, 48, 206, 39, 85, 27, 242, 35, 167, 128, 232, 65, 201, 96, 168, 193, 28, 195, 163, 233, 88, 240, 107, 163, 54, 138, 161, 148, 110, 231, 89, 39, 189, 151, 159, 223, 88, 126, 87, 114, 173, 204, 212, 73, 162, 174, 146, 239, 237, 21, 188, 136, 67, 210, 181, 162, 217, 71, 136, 84, 126, 132, 255, 167, 213, 231, 119, 140, 36, 251, 240, 174, 227, 65, 193, 136, 77, 69, 24, 93, 136, 25, 250, 81, 87, 126, 167, 132, 74, 57, 224, 168, 64, 172, 225, 155, 189, 57, 89, 53, 176, 148, 133, 122, 56, 216, 73, 114, 202, 87, 65, 50, 18, 41, 133 },
                            Role = "Client",
                            UserName = "Client"
                        });
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Order", b =>
                {
                    b.HasOne("Diplom.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Product", b =>
                {
                    b.HasOne("Diplom.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Sale", b =>
                {
                    b.HasOne("Diplom.Domain.Entities.Order", "Order")
                        .WithMany("Sales")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diplom.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Order", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("Diplom.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}