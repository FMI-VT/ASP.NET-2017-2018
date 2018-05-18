using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseProject.DataAccess;
using CourseProject.DataAccess.Repositories;
using CourseProject.DB.Entities;
using CourseProject.Services;
using CourseProject.Web.Models;

namespace CourseProject.Web.Controllers
{
    public class CitiesController : Controller
    {
        private readonly UnitOfWork uow;
        public CitiesController(CourseProjectDbContext context)
        {
            uow = new UnitOfWork(context);
        }

        // GET: Cities
        public ActionResult Index()
        {
            IEnumerable<City> cities = uow.CityRepository.GetAll();

            List<CityViewModel> model = new List<CityViewModel>();
            foreach(City city in cities)
            {
                CityViewModel cityModel = new CityViewModel(city);
                model.Add(cityModel);
            }

            return View(model);
        }

        // GET: Cities/Details/5
        public ActionResult Details(int id)
        {
            City city = uow.CityRepository.Get(id);
            CityViewModel model = new CityViewModel(city);

            IEnumerable<Location> Locations = 
                uow.LocationRepository.Find(x => x.CityId == id);

            ViewBag.Locations = Locations;

            return View(model);
        }

        // GET: Cities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cities/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cities/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cities/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cities/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                City city = uow.CityRepository.Get(id);

                foreach (Location location in city.Locations)
                {
                    foreach(Restaurant restaurant in location.Restaurants)
                    {
                        uow.ImageRepository.RemoveRange(restaurant.Images);
                        uow.RestaurantRepository.Remove(restaurant);
                    }

                    uow.LocationRepository.Remove(location);
                }
                
                uow.CityRepository.Remove(city);

                uow.SaveChanges();

                IEnumerable<City> cities = uow.CityRepository.GetAll();

                List<CityViewModel> model = new List<CityViewModel>();
                foreach (City oldcity in cities)
                {
                    CityViewModel cityModel = new CityViewModel(oldcity);
                    model.Add(cityModel);
                }

                return View(model);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
