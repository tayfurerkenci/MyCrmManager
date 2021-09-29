using MyCrmManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Persistence
{
    public class CommsTypeDetailRepository : Repository<CommsTypeDetail>, ICommsTypeDetailRepository
    {
        public CommsTypeDetailRepository(CrmContext context) : base(context)
        {
        }
        public CrmContext CrmContext
        {
            get { return Context as CrmContext; }
        }
    }
}
