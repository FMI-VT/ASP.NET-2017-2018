namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;
    using System.Linq;

    public class CityRepository : BaseRepository<CourseProjectDbContext, City>, ICityRepository
    {
        public City GetSingle (int cityId)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == cityId);
            return query;
        }
    }
}
