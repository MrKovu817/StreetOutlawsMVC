using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StreetOutlaws.Data.Context;
using StreetOutlaws.Data.Entities;
using StreetOutlaws.Models.TeamModels;

namespace StreetOutlaws.Services.TeamServices
{
    public class TeamService : ITeamService
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public TeamService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateTeam(TeamCreate model)
        {
            var team = _mapper.Map<Team>(model);
            await _context.Teams.AddAsync(team);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> DeleteTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team is null) return false;
            else
            {
                _context.Teams.Remove(team);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<TeamListItem>> GetTeams()
        {
            var teams = await _context.Teams.ToListAsync();
            return _mapper.Map<List<TeamListItem>>(teams);
        }

        public async Task<TeamDetail> GetTeamById(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team is null) return new TeamDetail();
            
            return _mapper.Map<TeamDetail>(team);
        }

        public async Task<bool> UpdateTeam(TeamUpdate model)
        {
            var team = await _context.Teams.FindAsync(model.Id);
            if (team is null) return false;
            else
            {
                team.Id = model.Id;
                team.Name = model.Name;

            await _context.SaveChangesAsync();
            return true;
            }
        }
    }
}