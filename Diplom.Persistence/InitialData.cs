using Diplom.Domain.Entities;
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
    }
}
