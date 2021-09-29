using MyCrmManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Persistence
{
    public class CommsTypeRepository : Repository<CommsType>, ICommsTypeRepository
    {
        public CommsTypeRepository(CrmContext context) : base(context)
        {

        }
        public CrmContext CrmContext
        {
            get { return Context as CrmContext; }
        }
    }
 
}
