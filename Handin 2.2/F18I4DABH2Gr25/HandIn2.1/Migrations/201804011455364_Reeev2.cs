namespace HandIn2._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reeev2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Phones", "Person_PersonID", "dbo.People");
            DropIndex("dbo.Phones", new[] { "Person_PersonID" });
            CreateTable(
                "dbo.PhonePersons",
                c => new
                    {
                        Phone_PhoneID = c.Int(nullable: false),
                        Person_PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Phone_PhoneID, t.Person_PersonID })
                .ForeignKey("dbo.Phones", t => t.Phone_PhoneID, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.Person_PersonID, cascadeDelete: true)
                .Index(t => t.Phone_PhoneID)
                .Index(t => t.Person_PersonID);
            
            AddColumn("dbo.People", "Address_AddressID", c => c.Int());
            CreateIndex("dbo.People", "Address_AddressID");
            AddForeignKey("dbo.People", "Address_AddressID", "dbo.Addresses", "AddressID");
            DropColumn("dbo.Phones", "Person_PersonID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Phones", "Person_PersonID", c => c.Int());
            DropForeignKey("dbo.People", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.PhonePersons", "Person_PersonID", "dbo.People");
            DropForeignKey("dbo.PhonePersons", "Phone_PhoneID", "dbo.Phones");
            DropIndex("dbo.PhonePersons", new[] { "Person_PersonID" });
            DropIndex("dbo.PhonePersons", new[] { "Phone_PhoneID" });
            DropIndex("dbo.People", new[] { "Address_AddressID" });
            DropColumn("dbo.People", "Address_AddressID");
            DropTable("dbo.PhonePersons");
            CreateIndex("dbo.Phones", "Person_PersonID");
            AddForeignKey("dbo.Phones", "Person_PersonID", "dbo.People", "PersonID");
        }
    }
}
