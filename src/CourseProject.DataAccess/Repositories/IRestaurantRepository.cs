namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;

    public interface IRestaurantRepository : IBaseRepository<Restaurant>
    {
        Restaurant GetSingle(int restaurantId);
    }
}