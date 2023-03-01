using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreetOutlaws.Models.TeamModels;

namespace StreetOutlaws.Services.TeamServices
{
    public interface ITeamService
    {
        Task<bool> CreateTeam(TeamCreate model);
        Task<List<TeamListItem>> GetAllTeams();
        Task<TeamDetail> GetTeamById(int id);
        Task<bool> UpdateTeam(TeamUpdate model);
        Task<bool> DeleteTeam(int id);
    }
}