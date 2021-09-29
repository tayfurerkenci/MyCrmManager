using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Persistence
{
    public interface IUnitOfWork:IDisposable
    {
        IStatusRepository Statuses { get; }
        ICommsTypeDetailRepository CommsTypeDetails { get; }
        ICommsTypeRepository CommsTypes { get; }
        IEmployeeRepository Employees { get; }
        IContactRepository Contacts { get; }
        ICompanyRepository Companies { get; }
        IMeetingRepository Meetings { get; }
        IMeetingDetailRepository MeetingDetails { get; }
        IBusinessSectorRepository BusinessSectors { get; }
        int Complete();
    }
}
