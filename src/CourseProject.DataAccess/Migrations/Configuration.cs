namespace CourseProject.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;
    using CourseProject.DB.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<CourseProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new CustomSqlServerMigrationSqlGenerator());
        }

        protected override void Seed(CourseProjectDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Cities.AddOrUpdate(
                new City { Id = 1, Name = "Велико Търново", MunicipalityName = "Велико Търново", DistrictName = "Велико Търново", CountryName = "България" },
                new City { Id = 2, Name = "Пловдив", MunicipalityName = "Пловдив", DistrictName = "Пловдив", CountryName = "България"},
                new City { Id = 3, Name = "София", MunicipalityName = "София", DistrictName = "София", CountryName = "България" },
                new City { Id = 4, Name = "Варна", MunicipalityName = "Варна", DistrictName = "Варна", CountryName = "България" },
                new City { Id = 5, Name = "Бургас", MunicipalityName = "Бургас", DistrictName = "Бургас", CountryName = "България" }
            );

            context.SaveChanges();
        }
    }
}
