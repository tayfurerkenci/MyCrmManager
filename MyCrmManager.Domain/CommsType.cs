using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class CommsType:Entity
    {
        public string Name { get; set; }
        public virtual ICollection<CommsTypeDetail> CommsTypeDetail { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
