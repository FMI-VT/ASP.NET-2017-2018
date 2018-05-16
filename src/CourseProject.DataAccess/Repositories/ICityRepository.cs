namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;

    public interface ICityRepository : IBaseRepository<City>
    {
        City GetSingle(int cityId);
    }
}
