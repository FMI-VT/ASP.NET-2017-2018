namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;

    public interface ILocationRepository : IBaseRepository<Location>
    {
        Location GetSingle(int locationId);
    }
}