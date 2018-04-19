namespace HandIn2._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressesID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AddressesID);
            
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        ContactInformationID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ContactInformationID);
            
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
                    })
                .PrimaryKey(t => t.PersonID);
            
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
            DropTable("dbo.Types");
            DropTable("dbo.People");
            DropTable("dbo.Names");
            DropTable("dbo.ContactInformations");
            DropTable("dbo.Addresses");
        }
    }
}
