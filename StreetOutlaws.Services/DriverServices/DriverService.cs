using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StreetOutlaws.Data.Context;
using StreetOutlaws.Data.Entities;
using StreetOutlaws.Models.DriverModels;

namespace StreetOutlaws.Services.DriverServices
{
    public class DriverService : IDriverService
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public DriverService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateDriver(DriverCreate model)
        {
            var driver = _mapper.Map<Driver>(model);
            await _context.Drivers.AddAsync(driver);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> DeleteDriver(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver is null) return false;
            else
            {
                _context.Drivers.Remove(driver);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<DriverListItem>> GetAllDrivers()
        {
            var drivers = await _context.Drivers.ToListAsync();
            return _mapper.Map<List<DriverListItem>>(drivers);
        }

        public async Task<DriverDetail> GetDriverById(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver is null) return new DriverDetail();

            return _mapper.Map<DriverDetail>(driver);
        }

        public async Task<bool> UpdateDriver(DriverUpdate model)
        {
            var driver = await _context.Drivers.FindAsync(model.Id);
            if (driver is null) return false;
            else
            {
                driver.Id = model.Id;
                driver.Name = model.Name;

            await _context.SaveChangesAsync();
            return true;
            }
        }
    }
}