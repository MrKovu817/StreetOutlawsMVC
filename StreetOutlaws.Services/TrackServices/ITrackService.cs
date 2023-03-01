using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreetOutlaws.Models.TrackModels;

namespace StreetOutlaws.Services.TrackServices
{
    public interface ITrackService
    {
        Task<bool> CreateTrack(TrackCreate model);
        Task<List<TrackListItem>> GetAllTracks();
        Task<TrackDetail> GetTrackById(int id);
        Task<bool> UpdateTrack(TrackUpdate model);
        Task<bool> DeleteTrack(int id);
    }
}