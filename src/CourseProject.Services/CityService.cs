using CourseProject.DataAccess.Repositories;
using CourseProject.DB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Services
{
    public class CityService 
    {
        private readonly IBaseRepository<City> repository;

        public CityService(IBaseRepository<City> repo)
        {
            repository = repo;
        }

        public IEnumerable<City> GetAll()
        {
            return repository.GetAll();
        }

        public CityService GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(City item)
        {
            // Custom validations

            if (item.Id == 0)
            {
                repository.Create(item);
            }
            else
            {
                repository.Update(item, x => x.Id == item.Id);
            }
            
        }
    }
}
