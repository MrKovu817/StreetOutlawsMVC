using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreetOutlaws.Models.TeamModels;
using StreetOutlaws.Services.TeamServices;

namespace StreetOutlaws.MVC.Controllers
{
    [Route("[controller]")]
    public class TeamController : Controller
    {
        private ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _teamService.GetAllTeams());
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
        public async Task<IActionResult> Post(TeamCreate team)
        {
            if(!ModelState.IsValid)return BadRequest(team);
            if(await _teamService.CreateTeam(team))
            return RedirectToAction(nameof(Index));
            else
            return View(team);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Details(int id)
        {
            return View(await _teamService.GetTeamById(id));
        }

        [HttpGet]
        [Route("Update/{id}")]
        public async Task<IActionResult> Update(int id)
        {
            var team = await _teamService.GetTeamById(id);
            var teamUpdate = new TeamUpdate
            {   
                Id=team.Id,
                Name=team.Name,
            };
            return View(teamUpdate);
        }

        [HttpGet]
        [Route("Update")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(TeamUpdate model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (await _teamService.UpdateTeam(model))
                return RedirectToAction(nameof(Index));
            else
                return View(model);
        }

        [HttpGet]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            var team = await _teamService.GetTeamById(id.Value);
            return View(team);
        }

        [HttpPost]
        [Route("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var IsSuccessful = await _teamService.DeleteTeam(id);
            if (IsSuccessful)
                return RedirectToAction(nameof(Index));
            else
                return UnprocessableEntity();
        }
    }
}