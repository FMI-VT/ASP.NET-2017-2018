namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZipCode = c.String(nullable: false, maxLength: 8),
                        StreetName = c.String(nullable: false, maxLength: 20),
                        StreetNum = c.String(nullable: false, maxLength: 20),
                        Extra = c.String(maxLength: 50),
                        CityId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        SeatsNumber = c.Int(nullable: false),
                        MenuType = c.String(nullable: false, maxLength: 50),
                        WorkingHours = c.String(nullable: false, maxLength: 20),
                        ReservationFee = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocationId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.Name, unique: true, name: "IX_RestaurantNameUnique")
                .Index(t => t.LocationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Restaurants", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Locations", "CityId", "dbo.Cities");
            DropIndex("dbo.Restaurants", new[] { "LocationId" });
            DropIndex("dbo.Restaurants", "IX_RestaurantNameUnique");
            DropIndex("dbo.Locations", new[] { "CityId" });
            DropTable("dbo.Restaurants");
            DropTable("dbo.Locations");
            DropTable("dbo.Cities");
        }
    }
}
