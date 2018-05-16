namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;
    using System.Linq;

    public class LocationRepository : BaseRepository<CourseProjectDbContext, Location>, ILocationRepository
    {
        public Location GetSingle(int locationId)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == locationId);
            return query;
        }
    }
}
