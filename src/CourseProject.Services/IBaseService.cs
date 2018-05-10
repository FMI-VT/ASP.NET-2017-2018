namespace CourseProject.Services
{
    using System.Collections.Generic;

    public interface IBaseService<T>
    {
        IEnumerable<T> GetAll();

        T GetByID(int id);

        void Save(T item);
    }
}
