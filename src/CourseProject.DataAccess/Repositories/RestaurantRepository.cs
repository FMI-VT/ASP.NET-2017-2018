namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;
    using System.Linq;

    public class RestaurantRepository : BaseRepository<CourseProjectDbContext, Restaurant>, IRestaurantRepository
    {
        public Restaurant GetSingle(int restaurantId)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == restaurantId);
            return query;
        }
    }
}
