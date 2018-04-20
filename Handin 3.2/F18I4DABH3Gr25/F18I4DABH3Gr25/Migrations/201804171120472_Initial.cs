namespace F18I4DABH3Gr25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses3-2",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        HouseNumber = c.String(),
                        ZipCode = c.String(),
                        CityName = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.People3-2", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.People3-2",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        MainAddress_AddressID = c.Int(),
                        Name_NameID = c.Int(),
                        Type_TypeID = c.Int(),
                        Address_AddressID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Addresses3-2", t => t.MainAddress_AddressID)
                .ForeignKey("dbo.Names3-2", t => t.Name_NameID)
                .ForeignKey("dbo.xTypes", t => t.Type_TypeID)
                .ForeignKey("dbo.Addresses3-2", t => t.Address_AddressID)
                .Index(t => t.MainAddress_AddressID)
                .Index(t => t.Name_NameID)
                .Index(t => t.Type_TypeID)
                .Index(t => t.Address_AddressID);
            
            CreateTable(
                "dbo.Emails3-2",
                c => new
                    {
                        EmailID = c.Int(nullable: false, identity: true),
                        Emails = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.EmailID)
                .ForeignKey("dbo.People3-2", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.Names3-2",
                c => new
                    {
                        NameID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.NameID);
            
            CreateTable(
                "dbo.Phones3-2",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        PhoneCarrier = c.String(),
                        PhoneUsage = c.String(),
                    })
                .PrimaryKey(t => t.PhoneID);
            
            CreateTable(
                "dbo.xTypes",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        Age = c.String(),
                        Sex = c.String(),
                    })
                .PrimaryKey(t => t.TypeID);
            
            CreateTable(
                "dbo.PhonePersons3-2",
                c => new
                    {
                        Phone_PhoneID = c.Int(nullable: false),
                        Person_PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Phone_PhoneID, t.Person_PersonID })
                .ForeignKey("dbo.Phones3-2", t => t.Phone_PhoneID, cascadeDelete: true)
                .ForeignKey("dbo.People3-2", t => t.Person_PersonID, cascadeDelete: true)
                .Index(t => t.Phone_PhoneID)
                .Index(t => t.Person_PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People3-2", "Address_AddressID", "dbo.Addresses3-2");
            DropForeignKey("dbo.People3-2", "Type_TypeID", "dbo.xTypes");
            DropForeignKey("dbo.PhonePersons3-2", "Person_PersonID", "dbo.People3-2");
            DropForeignKey("dbo.PhonePersons3-2", "Phone_PhoneID", "dbo.Phones3-2");
            DropForeignKey("dbo.People3-2", "Name_NameID", "dbo.Names3-2");
            DropForeignKey("dbo.People3-2", "MainAddress_AddressID", "dbo.Addresses3-2");
            DropForeignKey("dbo.Emails3-2", "Person_PersonID", "dbo.People3-2");
            DropForeignKey("dbo.Addresses3-2", "Person_PersonID", "dbo.People3-2");
            DropIndex("dbo.PhonePersons3-2", new[] { "Person_PersonID" });
            DropIndex("dbo.PhonePersons3-2", new[] { "Phone_PhoneID" });
            DropIndex("dbo.Emails3-2", new[] { "Person_PersonID" });
            DropIndex("dbo.People3-2", new[] { "Address_AddressID" });
            DropIndex("dbo.People3-2", new[] { "Type_TypeID" });
            DropIndex("dbo.People3-2", new[] { "Name_NameID" });
            DropIndex("dbo.People3-2", new[] { "MainAddress_AddressID" });
            DropIndex("dbo.Addresses3-2", new[] { "Person_PersonID" });
            DropTable("dbo.PhonePersons3-2");
            DropTable("dbo.xTypes");
            DropTable("dbo.Phones3-2");
            DropTable("dbo.Names3-2");
            DropTable("dbo.Emails3-2");
            DropTable("dbo.People3-2");
            DropTable("dbo.Addresses3-2");
        }
    }
}
