namespace MyCrmManager.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BusinessSectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CommsTypeDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactId = c.Int(nullable: false),
                        CommsTypeId = c.Int(nullable: false),
                        CommsInfo = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CommsTypes", t => t.CommsTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .Index(t => t.ContactId)
                .Index(t => t.CommsTypeId);
            
            CreateTable(
                "dbo.CommsTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        CompanyId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BusinessSectorId = c.Int(nullable: false),
                        TaxNumber = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BusinessSectors", t => t.BusinessSectorId, cascadeDelete: true)
                .Index(t => t.BusinessSectorId);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.String(),
                        Subject = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                        Company_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.Company_Id)
                .Index(t => t.Company_Id);
            
            CreateTable(
                "dbo.MeetingDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ContactId = c.Int(nullable: false),
                        MeetingId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        Note = c.String(),
                        StatusId = c.Int(nullable: false),
                        ProposalDocPath = c.String(),
                        MeetingDate = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Meetings", t => t.MeetingId, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.ContactId)
                .Index(t => t.MeetingId)
                .Index(t => t.EmployeeId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        NationalId = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Condition = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.Int(),
                        CreatedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CommsTypeDetails", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.MeetingDetails", "StatusId", "dbo.Status");
            DropForeignKey("dbo.MeetingDetails", "MeetingId", "dbo.Meetings");
            DropForeignKey("dbo.MeetingDetails", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.MeetingDetails", "ContactId", "dbo.Contacts");
            DropForeignKey("dbo.Meetings", "Company_Id", "dbo.Companies");
            DropForeignKey("dbo.Contacts", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Companies", "BusinessSectorId", "dbo.BusinessSectors");
            DropForeignKey("dbo.CommsTypeDetails", "CommsTypeId", "dbo.CommsTypes");
            DropIndex("dbo.MeetingDetails", new[] { "StatusId" });
            DropIndex("dbo.MeetingDetails", new[] { "EmployeeId" });
            DropIndex("dbo.MeetingDetails", new[] { "MeetingId" });
            DropIndex("dbo.MeetingDetails", new[] { "ContactId" });
            DropIndex("dbo.Meetings", new[] { "Company_Id" });
            DropIndex("dbo.Companies", new[] { "BusinessSectorId" });
            DropIndex("dbo.Contacts", new[] { "CompanyId" });
            DropIndex("dbo.CommsTypeDetails", new[] { "CommsTypeId" });
            DropIndex("dbo.CommsTypeDetails", new[] { "ContactId" });
            DropTable("dbo.Status");
            DropTable("dbo.Employees");
            DropTable("dbo.MeetingDetails");
            DropTable("dbo.Meetings");
            DropTable("dbo.Companies");
            DropTable("dbo.Contacts");
            DropTable("dbo.CommsTypes");
            DropTable("dbo.CommsTypeDetails");
            DropTable("dbo.BusinessSectors");
        }
    }
}
