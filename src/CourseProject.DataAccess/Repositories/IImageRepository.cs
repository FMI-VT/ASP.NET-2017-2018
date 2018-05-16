namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;

    public interface IImageRepository : IBaseRepository<Image>
    {
        Image GetSingle(int imageId);
    }
}