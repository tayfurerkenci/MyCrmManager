using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class MeetingDetail:Entity
    {
        
        public int ContactId { get; set; }

        public int MeetingId { get; set; }

        
        public int EmployeeId { get; set; }

        public string Note { get; set; }

        public int StatusId { get; set; }

        public string ProposalDocPath { get; set; }
        public DateTime MeetingDate { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Meeting Meeting { get; set; }
        public virtual Status Status { get; set; }
        public virtual Employee Employee { get; set; }

        public override string ToString()
        {
            return Note + " " + MeetingDate.ToString("dd/MM/yyyy, ddd");
        }
    }
}
