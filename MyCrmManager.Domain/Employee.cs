using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class Employee:Entity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public virtual ICollection<MeetingDetail> MeetingDetails { get; set; }

        public override string ToString()
        {
            return FirstName + " " + Lastname + " " + Email;
        }

    }
}
