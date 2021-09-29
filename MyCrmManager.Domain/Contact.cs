using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class Contact:Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
