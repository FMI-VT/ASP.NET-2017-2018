using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseProject.DB.Entities;
using CourseProject.Services;
using CourseProject.Web.Models;

namespace CourseProject.Web.Controllers
{
    public class CitiesController : Controller
    {
        private readonly CityService service;
        public CitiesController(CityService svc)
        {
            service = svc;
        }

        // GET: Cities
        public ActionResult Index()
        {
            IEnumerable<City> cities = service.GetAll();

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
            return View();
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

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
