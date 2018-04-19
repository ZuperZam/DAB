namespace HandIn2._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reeeee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
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
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        EmailID = c.Int(nullable: false, identity: true),
                        Emails = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.EmailID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.Names",
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
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        MainAddress_AddressID = c.Int(),
                        Name_NameID = c.Int(),
                        Type_TypeID = c.Int(),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("dbo.Addresses", t => t.MainAddress_AddressID)
                .ForeignKey("dbo.Names", t => t.Name_NameID)
                .ForeignKey("dbo.Types", t => t.Type_TypeID)
                .Index(t => t.MainAddress_AddressID)
                .Index(t => t.Name_NameID)
                .Index(t => t.Type_TypeID);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneID = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        PhoneCarrier = c.String(),
                        PhoneUsage = c.String(),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.PhoneID)
                .ForeignKey("dbo.People", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        TypeID = c.Int(nullable: false, identity: true),
                        Age = c.String(),
                        Sex = c.String(),
                    })
                .PrimaryKey(t => t.TypeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Type_TypeID", "dbo.Types");
            DropForeignKey("dbo.Phones", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.People", "Name_NameID", "dbo.Names");
            DropForeignKey("dbo.People", "MainAddress_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.Emails", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.Addresses", "Person_PersonID", "dbo.People");
            DropIndex("dbo.Phones", new[] { "Person_PersonID" });
            DropIndex("dbo.People", new[] { "Type_TypeID" });
            DropIndex("dbo.People", new[] { "Name_NameID" });
            DropIndex("dbo.People", new[] { "MainAddress_AddressID" });
            DropIndex("dbo.Emails", new[] { "Person_PersonID" });
            DropIndex("dbo.Addresses", new[] { "Person_PersonID" });
            DropTable("dbo.Types");
            DropTable("dbo.Phones");
            DropTable("dbo.People");
            DropTable("dbo.Names");
            DropTable("dbo.Emails");
            DropTable("dbo.Addresses");
        }
    }
}
