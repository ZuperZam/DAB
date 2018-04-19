namespace HandIn2._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomethingChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Addresses1", "Addresses_AddressesID", c => c.Int());
            CreateIndex("dbo.Addresses1", "Addresses_AddressesID");
            AddForeignKey("dbo.Addresses1", "Addresses_AddressesID", "dbo.Addresses", "AddressesID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses1", "Addresses_AddressesID", "dbo.Addresses");
            DropIndex("dbo.Addresses1", new[] { "Addresses_AddressesID" });
            DropColumn("dbo.Addresses1", "Addresses_AddressesID");
        }
    }
}
