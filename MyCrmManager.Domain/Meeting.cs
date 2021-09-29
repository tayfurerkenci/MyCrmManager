using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class Meeting:Entity
    {
       
        public string CompanyId { get; set; }
        public string Subject { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<MeetingDetail> MeetingDetails { get; set; }
        public override string ToString() 
        {
            return Subject;
        }
    }
}
