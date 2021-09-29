using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class BusinessSector:Entity
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
