namespace HandIn2._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NothingHasChangedButOkay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Address_AddressID", c => c.Int());
            AddColumn("dbo.People", "Addresses_AddressesID", c => c.Int());
            AddColumn("dbo.People", "ContactInformation_ContactInformationID", c => c.Int());
            AddColumn("dbo.People", "Name_NameID", c => c.Int());
            AddColumn("dbo.People", "Type_TypeID", c => c.Int());
            CreateIndex("dbo.People", "Address_AddressID");
            CreateIndex("dbo.People", "Addresses_AddressesID");
            CreateIndex("dbo.People", "ContactInformation_ContactInformationID");
            CreateIndex("dbo.People", "Name_NameID");
            CreateIndex("dbo.People", "Type_TypeID");
            AddForeignKey("dbo.People", "Address_AddressID", "dbo.Addresses1", "AddressID");
            AddForeignKey("dbo.People", "Addresses_AddressesID", "dbo.Addresses", "AddressesID");
            AddForeignKey("dbo.People", "ContactInformation_ContactInformationID", "dbo.ContactInformations", "ContactInformationID");
            AddForeignKey("dbo.People", "Name_NameID", "dbo.Names", "NameID");
            AddForeignKey("dbo.People", "Type_TypeID", "dbo.Types", "TypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "Type_TypeID", "dbo.Types");
            DropForeignKey("dbo.People", "Name_NameID", "dbo.Names");
            DropForeignKey("dbo.People", "ContactInformation_ContactInformationID", "dbo.ContactInformations");
            DropForeignKey("dbo.People", "Addresses_AddressesID", "dbo.Addresses");
            DropForeignKey("dbo.People", "Address_AddressID", "dbo.Addresses1");
            DropIndex("dbo.People", new[] { "Type_TypeID" });
            DropIndex("dbo.People", new[] { "Name_NameID" });
            DropIndex("dbo.People", new[] { "ContactInformation_ContactInformationID" });
            DropIndex("dbo.People", new[] { "Addresses_AddressesID" });
            DropIndex("dbo.People", new[] { "Address_AddressID" });
            DropColumn("dbo.People", "Type_TypeID");
            DropColumn("dbo.People", "Name_NameID");
            DropColumn("dbo.People", "ContactInformation_ContactInformationID");
            DropColumn("dbo.People", "Addresses_AddressesID");
            DropColumn("dbo.People", "Address_AddressID");
        }
    }
}
