using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StreetOutlaws.Data.Context;
using StreetOutlaws.Data.Entities;
using StreetOutlaws.Models.TrackModels;

namespace StreetOutlaws.Services.TrackServices
{
    public class TrackService : ITrackService
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public TrackService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateTrack(TrackCreate model)
        {
            var track = _mapper.Map<Track>(model);
            await _context.Tracks.AddAsync(track);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> DeleteTrack(int id)
        {
            var track = await _context.Tracks.FindAsync(id);
            if (track is null) return false;
            else
            {
                _context.Tracks.Remove(track);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<TrackListItem>> GetAllTracks()
        {
            var tracks = await _context.Tracks.ToListAsync();
            return _mapper.Map<List<TrackListItem>>(tracks);
        }

        public async Task<TrackDetail> GetTrackById(int id)
        {
            var track = await _context.Tracks.FindAsync(id);
            if (track is null) return new TrackDetail();
            
            return _mapper.Map<TrackDetail>(track);
        }

        public async Task<bool> UpdateTrack(TrackUpdate model)
        {
            var track = await _context.Tracks.FindAsync(model.Id);
            if (track is null) return false;
            else
            {
                track.Id = model.Id;
                track.Name = model.Name;

            await _context.SaveChangesAsync();
            return true;
            }
        }
    }
}