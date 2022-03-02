using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain.Entities.Phone.Characteristics
{
    public class MobileCommunications
    {
        public bool SupportFor2GNetworks { get; set; }
        public bool SupportFor3GNetworks { get; set; }
        public bool SupportFor4GNetworksLTE { get; set; }
        public bool SupportFor5GNetworks { get; set; }
    }
}
