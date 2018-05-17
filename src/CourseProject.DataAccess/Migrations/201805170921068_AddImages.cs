namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImages : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ImageName = c.String(nullable: false, maxLength: 120),
                        ImagePath = c.String(nullable: false, maxLength: 120),
                        RestaurantId = c.Int(nullable: false),
                        CreatedTime = c.DateTime(nullable: false),
                        UpdatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Restaurants", t => t.RestaurantId, cascadeDelete: true)
                .Index(t => t.RestaurantId);
            
            AddColumn("dbo.Restaurants", "PhoneNumber", c => c.String(nullable: false));
            AddColumn("dbo.Restaurants", "SuitableForKids", c => c.Boolean(nullable: false));
            DropColumn("dbo.Restaurants", "ReservationFee");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Restaurants", "ReservationFee", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropForeignKey("dbo.Images", "RestaurantId", "dbo.Restaurants");
            DropIndex("dbo.Images", new[] { "RestaurantId" });
            DropColumn("dbo.Restaurants", "SuitableForKids");
            DropColumn("dbo.Restaurants", "PhoneNumber");
            DropTable("dbo.Images");
        }
    }
}
