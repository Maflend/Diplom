using Diplom.Domain.Entities;
using Diplom.Domain.Entities.Phone;
using Diplom.Domain.Entities.Phone.Characteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Persistence
{
    public static class InitialData
    {

        public static List<Category> Categories = new()
        {
            new Category()
            {
                Name = "Телефоны"
            },
            new Category()
            {
                Name = "Телевизоры"
            },
            new Category()
            {
                Name = "Наушники"
            },
        };

        //public static List<Phone> Phones = new()
        //{
        //    new Phone()
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "IPhone Xs",
        //        Description = "Дисплей Super Retina XDR 6,1 дюйма с технологией ProMotion для более быстрого и плавного взаимодействия",
        //        Price = 70000.00m,
        //        PurchasePrice = 50000.00m,

        //        Color = "Золотистый",




        //        CategoryId = Categories.Where(c => c.Name == "Телефоны").First().Id


        //    }   
        //};
        //


        public static FactoryData Factory = new FactoryData()
        {
             WarrantyMonth = 12, CountryOfOrigin = "Китай"
        };
        public static Product Phone = new Phone()
        {
            Id = Guid.NewGuid(),
            Name = "IPhone Xs",
            Description = "Дисплей Super Retina XDR 6,1 дюйма с технологией ProMotion для более быстрого и плавного взаимодействия",
            Price = 70000.00m,
            PurchasePrice = 50000.00m,

            Color = "Золотистый",

            FactoryData = Factory,



            CategoryId = Categories.Where(c => c.Name == "Телефоны").First().Id




        };
    }
}
