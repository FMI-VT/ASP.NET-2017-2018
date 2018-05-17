namespace CourseProject.DataAccess.Repositories
{
    using CourseProject.DB.Entities;
    using System.Threading.Tasks;
    using System.Threading;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Data.Common;

    public class UnitOfWork 
    {
        private CourseProjectDbContext context;

        private Repository<City> cityRepository;
        private Repository<Location> locationRepository;
        private Repository<Restaurant> restaurantRepository;
        private Repository<Image> imageRepository;

        public UnitOfWork(CourseProjectDbContext ctx)
        {
            context = ctx;
        }

        public Repository<City> CityRepository
        {
            get
            {
                if (cityRepository == null)
                {
                    cityRepository = new Repository<City>(context);
                }

                return cityRepository;
            }
        }

        public Repository<Location> LocationRepository
        {
            get
            {
                if (locationRepository == null)
                {
                    locationRepository = new Repository<Location>(context);
                }

                return locationRepository;
            }
        }

        public Repository<Restaurant> RestaurantRepository
        {
            get
            {
                if (restaurantRepository == null)
                {
                    restaurantRepository = new Repository<Restaurant>(context);
                }

                return restaurantRepository;
            }
        }

        public Repository<Image> ImageRepository
        {
            get
            {
                if (imageRepository == null)
                {
                    imageRepository = new Repository<Image>(context);
                }

                return imageRepository;
            }
        }

        public DbTransaction Transaction { get; private set; }

        public virtual int SaveChanges() => context.SaveChanges();

        public Task<int> SaveChangesAsync()
        {
            return context.SaveChangesAsync();
        }

        public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return context.SaveChangesAsync(cancellationToken);
        }

        public virtual int ExecuteSqlCommand(string sql, params object[] parameters)
        {
            return context.Database.ExecuteSqlCommand(sql, parameters);
        }

        public virtual async Task<int> ExecuteSqlCommandAsync(string sql, params object[] parameters)
        {
            return await context.Database.ExecuteSqlCommandAsync(sql, parameters);
        }

        public virtual async Task<int> ExecuteSqlCommandAsync(string sql, CancellationToken cancellationToken, params object[] parameters)
        {
            return await context.Database.ExecuteSqlCommandAsync(sql, cancellationToken, parameters);
        }

        public virtual void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified)
        {
            var objectContext = ((IObjectContextAdapter)context).ObjectContext;
            if (objectContext.Connection.State != ConnectionState.Open)
            {
                objectContext.Connection.Open();
            }
            Transaction = objectContext.Connection.BeginTransaction(isolationLevel);
        }

        public virtual bool Commit()
        {
            Transaction.Commit();
            return true;
        }

        public virtual void Rollback()
        {
            Transaction.Rollback();
        }
    }
}
