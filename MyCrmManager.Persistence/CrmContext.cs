using MyCrmManager.Domain;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace MyCrmManager.Persistence
{
    public class CrmContext : DbContext
    {
        // Your context has been configured to use a 'CrmContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MyCrmManager.Persistence.CrmContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CrmContext' 
        // connection string in the application configuration file.
        public CrmContext()
            : base("name=CrmContext")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<CrmContext, Migrations.Configuration>());
            Database.SetInitializer<CrmContext>(new DropCreateDatabaseIfModelChanges<CrmContext>());
        }
        
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<BusinessSector> BusinessSectors { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CommsType> CommsTypes { get; set; }
        public virtual DbSet<CommsTypeDetail> CommsTypeDetails { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MeetingDetail> MeetingDetails { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            // Make sure the provider assembly is available to the running application. 
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}