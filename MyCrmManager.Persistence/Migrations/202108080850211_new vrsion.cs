namespace MyCrmManager.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newvrsion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contact", "FirstName", c => c.String());
            AddColumn("dbo.Contact", "LastName", c => c.String());
            AddColumn("dbo.Employee", "Password", c => c.String());
            AddColumn("dbo.Employee", "FirstName", c => c.String());
            AddColumn("dbo.Employee", "Lastname", c => c.String());
            AlterColumn("dbo.BusinessSector", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.CommsTypeDetail", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.CommsType", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Contact", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Company", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Meeting", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.MeetingDetail", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Employee", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Status", "ModifiedDate", c => c.DateTime());
            DropColumn("dbo.Contact", "NameSurname");
            DropColumn("dbo.Employee", "NameSurname");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employee", "NameSurname", c => c.String());
            AddColumn("dbo.Contact", "NameSurname", c => c.String());
            AlterColumn("dbo.Status", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Employee", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.MeetingDetail", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Meeting", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Company", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.Contact", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.CommsType", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.CommsTypeDetail", "ModifiedDate", c => c.DateTime());
            AlterColumn("dbo.BusinessSector", "ModifiedDate", c => c.DateTime());
            DropColumn("dbo.Employee", "Lastname");
            DropColumn("dbo.Employee", "FirstName");
            DropColumn("dbo.Employee", "Password");
            DropColumn("dbo.Contact", "LastName");
            DropColumn("dbo.Contact", "FirstName");
        }
    }
}
