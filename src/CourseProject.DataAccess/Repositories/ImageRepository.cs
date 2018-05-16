namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;
    using System.Linq;

    public class ImageRepository : BaseRepository<CourseProjectDbContext, Image>, IImageRepository
    {
        public Image GetSingle(int imageId)
        {
            var query = GetAll().FirstOrDefault(x => x.Id == imageId);
            return query;
        }
    }
}
