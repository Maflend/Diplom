using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain.Entities.Phone.Characteristics
{
    public class FactoryData 
    {
        public int WarrantyMonth { get; set; }
        public string CountryOfOrigin { get; set; }
        public Phone Phone { get; set; }
        [Key]
        public Guid PhoneId { get; set; }
    }
}
