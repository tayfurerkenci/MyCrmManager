using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class Status:Entity
    {
        public string Condition { get; set; }
        public override string ToString()
        {
            return Condition;
        }

    }
}
