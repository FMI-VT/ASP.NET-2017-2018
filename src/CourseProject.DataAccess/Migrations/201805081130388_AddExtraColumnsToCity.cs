namespace CourseProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExtraColumnsToCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "MunicipalityName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Cities", "DistrictName", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Cities", "CountryName", c => c.String(nullable: false, maxLength: 20));
            CreateIndex("dbo.Cities", "Name", unique: true, name: "IX_CityNameUnique");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cities", "IX_CityNameUnique");
            DropColumn("dbo.Cities", "CountryName");
            DropColumn("dbo.Cities", "DistrictName");
            DropColumn("dbo.Cities", "MunicipalityName");
        }
    }
}
