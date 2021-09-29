using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class CommsTypeDetail: Entity
    {
     
        public int ContactId { get; set; }
 
        public int CommsTypeId { get; set; }
        public string CommsInfo { get; set; }
        public virtual CommsType CommsType { get; set; }
        public virtual Contact Contact { get; set; }


        public override string ToString()
        {
            return CommsInfo;
        }
    }
}
