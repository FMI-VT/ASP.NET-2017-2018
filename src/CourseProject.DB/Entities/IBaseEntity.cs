namespace CourseProject.DB.Entities
{
    public interface IBaseEntity<T, K>
    {
        T Id { get; set; }

        K CreatedTime { get; set; }

        K UpdatedTime { get; set; }
    }
}
