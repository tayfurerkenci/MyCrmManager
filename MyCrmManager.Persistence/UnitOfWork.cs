using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCrmManager.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CrmContext _context;
        public UnitOfWork(CrmContext context)
        {
            _context = context;
            Statuses = new StatusRepository(_context);
            CommsTypeDetails = new CommsTypeDetailRepository(_context);
            CommsTypes = new CommsTypeRepository(_context);
            Employees = new EmployeeRepository(_context);
            Contacts = new ContactRepository(_context);
            Companies = new CompanyRepository(_context);
            Meetings = new MeetingRepository(_context);
            MeetingDetails = new MeetingDetailRepository(_context);
            BusinessSectors = new BusinessSectorRepository(_context);
        }

        public IStatusRepository Statuses { get; private set; }

        public ICommsTypeDetailRepository CommsTypeDetails { get; private set; }

        public ICommsTypeRepository CommsTypes { get; private set; }

        public IEmployeeRepository Employees { get; private set; }

        public IContactRepository Contacts { get; private set; }

        public ICompanyRepository Companies { get; private set; }

        public IMeetingRepository Meetings { get; private set; }

        public IMeetingDetailRepository MeetingDetails { get; private set; }

        public IBusinessSectorRepository BusinessSectors { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
