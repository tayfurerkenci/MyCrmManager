namespace MyCrmManager.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.BusinessSectors", newName: "BusinessSector");
            RenameTable(name: "dbo.CommsTypeDetails", newName: "CommsTypeDetail");
            RenameTable(name: "dbo.CommsTypes", newName: "CommsType");
            RenameTable(name: "dbo.Contacts", newName: "Contact");
            RenameTable(name: "dbo.Companies", newName: "Company");
            RenameTable(name: "dbo.Meetings", newName: "Meeting");
            RenameTable(name: "dbo.MeetingDetails", newName: "MeetingDetail");
            RenameTable(name: "dbo.Employees", newName: "Employee");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Employee", newName: "Employees");
            RenameTable(name: "dbo.MeetingDetail", newName: "MeetingDetails");
            RenameTable(name: "dbo.Meeting", newName: "Meetings");
            RenameTable(name: "dbo.Company", newName: "Companies");
            RenameTable(name: "dbo.Contact", newName: "Contacts");
            RenameTable(name: "dbo.CommsType", newName: "CommsTypes");
            RenameTable(name: "dbo.CommsTypeDetail", newName: "CommsTypeDetails");
            RenameTable(name: "dbo.BusinessSector", newName: "BusinessSectors");
        }
    }
}
