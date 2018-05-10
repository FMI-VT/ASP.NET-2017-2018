namespace CourseProject.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseProject.DataAccess.CourseProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(CourseProject.DataAccess.CourseProjectDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Cities.AddOrUpdate(
                new DB.Entities.City { Id = 1, Name = "Велико Търново", MunicipalityName = "Велико Търново", DistrictName = "Велико Търново", CountryName = "България" },
                new DB.Entities.City { Id = 2, Name = "София", MunicipalityName = "София", DistrictName = "София", CountryName = "България" },
                new DB.Entities.City { Id = 3, Name = "Варна", MunicipalityName = "Варна", DistrictName = "Варна", CountryName = "България" },
                new DB.Entities.City { Id = 4, Name = "Бургас", MunicipalityName = "Бургас", DistrictName = "Бургас", CountryName = "България" }
            );
        }
    }
}
