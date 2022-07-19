using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutomobileLibrary.Repository;
using AutomobileLibrary.DataAccess;
using System;

namespace AutomobileWebApp.Controllers
{
    public class CarsController : Controller
    {
        ICarRepository carRepository = null;
        public CarsController() => carRepository = new CarRepositorycs();



        // GET: CarController
        public ActionResult Index()
        {
            var carList = carRepository.GetCars();
            return View(carList);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var car = carRepository.GetCarById(id.Value);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // GET: CarController/Create
        public ActionResult Create() => View();


        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    carRepository.InsertCar(car);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(car);
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var car = carRepository.GetCarById(id.Value);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car car)
        {
            try
            {
                if (id != car.CarId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    carRepository.UpdateCar(car);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var car = carRepository.GetCarById(id.Value);
            if (car == null)
            {
                return NotFound();
            }
            return View(car);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                carRepository.DeleteCar(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
