using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreetOutlaws.Models.CarModel;
using StreetOutlaws.Services.CarServices;

namespace StreetOutlaws.MVC.Controllers
{
    [Route("[controller]")]
    public class CarController : Controller
    {
        private ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _carService.GetAllCars());
        }

        [HttpGet]
        [Route("Post")]
        public async Task<IActionResult> Post()
        {
            return View();
        }

        [HttpPost]
        [Route("Post")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(CarCreate car)
        {
            if(!ModelState.IsValid)return BadRequest(car);
            if(await _carService.CreateCar(car))
            return RedirectToAction(nameof(Index));
            else
            return View(car);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _carService.GetCarById(id));
        }

        [HttpGet]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            var car = await _carService.GetCarById(id);
            var carUpdate = new CarUpdate
            {   
                Id=car.Id,
                Make=car.Make,
                Model=car.Model,
                Year=car.Year
            };
            return View(carUpdate);
        }

        [HttpGet]
        [Route("Update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CarUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _carService.UpdateCar(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            var car = await _carService.GetCarById(id.Value);
            return View(car);
        }

        [HttpPost]
        [Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var IsSuccessful = await _carService.DeleteCar(id);
            if (IsSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();
        }
    }
}