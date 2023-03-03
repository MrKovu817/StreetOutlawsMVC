using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreetOutlaws.Data.Entities;
using StreetOutlaws.Models.DriverModels;
using StreetOutlaws.Services.DriverServices;

namespace StreetOutlaws.MVC.Controllers
{
    [Route("[controller]")]
    public class DriverController : Controller
    {
        private IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _driverService.GetAllDrivers());
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
        public async Task<IActionResult> Post(DriverCreate driver)
        {
            if(!ModelState.IsValid)return BadRequest(driver);
            if(await _driverService.CreateDriver(driver))
            return RedirectToAction(nameof(Index));
            else
            return View(driver);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _driverService.GetDriverById(id));
        }

        [HttpGet]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            var driver = await _driverService.GetDriverById(id);
            var driverUpdate = new DriverUpdate
            {   
                Id=driver.Id,
                Name=driver.Name,
                
            };
            return View(driverUpdate);
        }

        [HttpGet]
        [Route("Update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(DriverUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _driverService.UpdateDriver(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            var driver = await _driverService.GetDriverById(id.Value);
            return View(driver);
        }

        [HttpPost]
        [Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var IsSuccessful = await _driverService.DeleteDriver(id);
            if (IsSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();
        }
    }
}