using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreetOutlaws.Models.TrackModels;
using StreetOutlaws.Services.TrackServices;

namespace StreetOutlaws.MVC.Controllers
{
    [Route("[controller]")]
    public class TrackController : Controller
    {
        private ITrackService _trackService;

        public TrackController(ITrackService trackService)
        {
            _trackService = trackService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _trackService.GetAllTracks());
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
        public async Task<IActionResult> Post(TrackCreate track)
        {
            if(!ModelState.IsValid)return BadRequest(track);
            if(await _trackService.CreateTrack(track))
            return RedirectToAction(nameof(Index));
            else
            return View(track);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _trackService.GetTrackById(id));
        }

        [HttpGet]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            var track = await _trackService.GetTrackById(id);
            var trackUpdate = new TrackUpdate
            {   
                Id=track.Id,
                Name=track.Name,
            };
            return View(trackUpdate);
        }

        [HttpGet]
        [Route("Update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(TrackUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _trackService.UpdateTrack(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            var track = await _trackService.GetTrackById(id.Value);
            return View(track);
        }

        [HttpPost]
        [Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var IsSuccessful = await _trackService.DeleteTrack(id);
            if (IsSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();
        }
    }
}