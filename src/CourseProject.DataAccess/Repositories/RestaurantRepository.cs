namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;

    class RestaurantRepository : BaseRepository<Restaurant>
    {
        public void Save(Restaurant restaurant)
        {
            if (restaurant.Id == 0)
            {
                Create(restaurant);
            }
            else
            {
                Update(restaurant, item => item.Id == restaurant.Id);
            }
        }
    }
}
