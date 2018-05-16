namespace CourseProject.DataAccess.Repositories
{
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Linq.Expressions;
    using System.Linq;

    public abstract class BaseRepository<C, T> :
    IBaseRepository<T> where T : class where C : DbContext, new()
    {
        public C Context { get; set; } = new C();

        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = Context.Set<T>();
            return query;
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = Context.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }
    }
}
