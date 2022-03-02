using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain.Entities.Phone.Characteristics
{
    public class DeviceSystem
    {
        public string OperatingSystem { get; set; }
        public string OSVersion { get; set; }
        public int RamCapacity { get; set; }
        public int BuiltInMemory { get; set; }
    }
}
