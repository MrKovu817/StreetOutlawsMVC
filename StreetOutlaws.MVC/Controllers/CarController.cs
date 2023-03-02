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
    }
}