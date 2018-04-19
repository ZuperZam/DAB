namespace HandIn2._1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses1",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        StreetName = c.String(),
                        HouseNumber = c.String(),
                        ZipCode = c.String(),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.AddressID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Addresses1");
        }
    }
}
