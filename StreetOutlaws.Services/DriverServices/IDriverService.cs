using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreetOutlaws.Models.DriverModels;

namespace StreetOutlaws.Services.DriverServices
{
    public interface IDriverService
    {
        
        Task<bool> CreateDriver(DriverCreate model);
        Task<List<DriverListItem>> GetAllDrivers();
        Task<DriverDetail> GetDriverById(int id);
        Task<bool> UpdateDriver(DriverUpdate model);
        Task<bool> DeleteDriver(int id);
    }
}