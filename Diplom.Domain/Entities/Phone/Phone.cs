using Diplom.Domain.Entities.Phone.Characteristics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain.Entities.Phone
{
    public class Phone : Product
    {
        public string Color { get; set; }
        public FactoryData FactoryData { get; set; }
        //public GeneralParameters GeneralParameters { get; set; }
        //public Appearance Appearance { get; set; }
        //public MobileCommunications MobileCommunications { get; set; }
        //public Display Display { get; set; }
        //public DeviceSystem System { get; set; }

    }
}
