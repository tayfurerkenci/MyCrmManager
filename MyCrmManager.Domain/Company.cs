using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class Company:Entity
    {
        public string Name { get; set; }
        public int BusinessSectorId { get; set; }
        public string TaxNumber { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public virtual BusinessSector BusinessSector { get; set; }

        public virtual ICollection<Meeting> Meetings { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
