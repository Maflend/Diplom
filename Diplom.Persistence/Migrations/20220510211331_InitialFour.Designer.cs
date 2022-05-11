﻿// <auto-generated />
using System;
using Diplom.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diplom.Persistence.Migrations
{
    [DbContext(typeof(DiplomContext))]
    [Migration("20220510211331_InitialFour")]
    partial class InitialFour
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Diplom.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

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
                            Id = new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"),
                            Name = "Наушники"
                        });
                });

            modelBuilder.Entity("Diplom.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

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
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8cf5c0db-ad0e-463d-9b59-f3adb186ac64"),
                            CategoryId = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                            Description = "Смартфон Apple iPhone 11 128GB с новой комплектацией черный. ID: 5863730. Артикул: 836847. Диагональ(дюйм): 6.1. Разрешение(пикс): 1792x828. Встроенная память(Гб): 128. Фотокамера(Мп): 12 + 12(двойная). Оптический зум: x2",
                            ImgUrl = "https://items.s1.citilink.ru/1429412_v01_b.jpg",
                            Name = "iPhone 11",
                            Price = 54990m,
                            PurchasePrice = 32000m
                        },
                        new
                        {
                            Id = new Guid("9577f90c-f370-479e-9011-30d2e1dfa89c"),
                            CategoryId = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                            Description = "Смартфон Samsung Galaxy S21 FE 128 ГБ белый. Разрешение экрана пикс: 2340 x 1080. Встроенная память, ГБ:128.",
                            ImgUrl = "https://items.s1.citilink.ru/1659651_v01_b.jpg",
                            Name = "Samsung Galaxy S21",
                            Price = 60990m,
                            PurchasePrice = 39000m
                        },
                        new
                        {
                            Id = new Guid("6b9bff08-5e8e-4505-8b35-39faad4f49d2"),
                            CategoryId = new Guid("9b44ad54-817c-47c2-8344-729915670c73"),
                            Description = "Операционная система: Android Q Go. Дисплей: 6TFT. Разрешение дисплея: 960x480. Процессор: Spreadtrum SC7731E,1300МГц,4 - х ядерный. Объем оперативной памяти: 1 ГБ. Объем встроенной памяти: 32 ГБ.",
                            ImgUrl = "https://items.s1.citilink.ru/1433141_v01_b.jpg",
                            Name = "ZTE Blade L210",
                            Price = 5100m,
                            PurchasePrice = 3000m
                        },
                        new
                        {
                            Id = new Guid("f7edfb58-4842-4b4d-9563-e8fe4626fc1a"),
                            CategoryId = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                            Description = "LED-телевизор LG 49UK6200PLA с экраном диагональю 49 дюймов органично впишется в интерьер столовой, спальни или гостиной. Поддержка Ultra HD 4K с разрешением 3840х2160 делает картинку максимально реалистичной и детальной.",
                            ImgUrl = "https://items.s1.citilink.ru/1092279_v01_b.jpg",
                            Name = "LG 49UK6200PLA",
                            Price = 57990m,
                            PurchasePrice = 36000m
                        },
                        new
                        {
                            Id = new Guid("ac7f7b99-46b4-4ba1-a586-1054406da995"),
                            CategoryId = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                            Description = "Цвет, в котором выполнен телевизор SAMSUNG UE50AU8000UXRU, - универсальный черный. В этом цвете выполнены рамка и подставка, поэтому устройство отличается нейтральным внешним видом и способно вписаться в любой интерьер. Оно выпущено в 2021-м году и обладает подсветкой Direct LED. Диагональ экрана равна 50 дюймам, что в пересчете равно целым 125 см.",
                            ImgUrl = "https://items.s1.citilink.ru/1529485_v01_b.jpg",
                            Name = "Samsung UE50AU8000UXRU",
                            Price = 35000m,
                            PurchasePrice = 57990m
                        },
                        new
                        {
                            Id = new Guid("62fbf839-9416-49e7-99e4-29856df0b509"),
                            CategoryId = new Guid("e90e97a3-cf8c-496e-8db4-55049d15fe99"),
                            Description = "Телевизор LED LG 32 оснащен четырехъядерным процессором, работающим быстро и бесшумно.С его помощью обеспечиваются более динамичная цветопередача и контрастность, обработка изображений, автоматическая коррекция цвета.Изображение становится более насыщенным и естественным.Картинки с низким разрешением масштабируются и восстанавливаются.",
                            ImgUrl = "https://items.s1.citilink.ru/1140679_v01_b.jpg",
                            Name = "LG 32LM6350PLA",
                            Price = 34990m,
                            PurchasePrice = 20000m
                        },
                        new
                        {
                            Id = new Guid("003c1506-ac20-436f-a4ad-568d4474857d"),
                            CategoryId = new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"),
                            Description = "Профессиональные наушники с широким диапазоном воспроизводимых частот – AUDIO-TECHNICA ATH-M50X. Данная модель отличается строгим технологичным дизайном. Длина кабеля 3 м позволяет с комфортом расположиться в студии или за диджейским пультом. Провод можно отсоединять и при необходимости менять на другой.",
                            ImgUrl = "https://items.s1.citilink.ru/1048584_v01_b.jpg",
                            Name = "Audio-Technica ATH-M50X",
                            Price = 25490m,
                            PurchasePrice = 8000m
                        },
                        new
                        {
                            Id = new Guid("0e801de3-43db-4ac5-886e-01f0ce6f9f57"),
                            CategoryId = new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"),
                            Description = "Наушники KOSS Porta Pro Classic разработаны еще в восьмидесятых, но они до сих пор не сдают свои позиции и остаются популярными среди меломанов. Все благодаря высокому качеству звука. Небольшие динамики выдают насыщенные басы, от которых дрожат внутренности.",
                            ImgUrl = "https://items.s1.citilink.ru/490813_v01_b.jpg",
                            Name = "Koss Porta Pro Classic",
                            Price = 3990m,
                            PurchasePrice = 1500m
                        },
                        new
                        {
                            Id = new Guid("c74d342e-5eb6-4523-b3bd-e00cd5de7c98"),
                            CategoryId = new Guid("67f36106-149d-4e4d-b9e1-f365f498a7a6"),
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
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

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
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Users");
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