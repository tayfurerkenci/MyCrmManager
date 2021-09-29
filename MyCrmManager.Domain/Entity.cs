using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Domain
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }
        [DefaultValue("true")]
        public bool IsActive { get; set; }
        [DefaultValue("getutcdate()")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        public DateTime? CreatedDate { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public int? CreatedBy { get; set; }

        // public virtual Employee Employee { get; set; }
        
    }
}
