using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain.Entities.Phone.Characteristics
{
   
    public class Appearance
    {
        public string BackPanelColour { get; set; }
        public string FrontPanelColour { get; set; }
        public string ColorOfFaces { get; set; }
        public string ColorDeclaredByTheManufacturer { get; set; }
    }
}
