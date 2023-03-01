using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StreetOutlaws.Data.Context;
using StreetOutlaws.Models.CarModel;

namespace StreetOutlaws.Services.CarServices
{
    public interface ICarService
    {
        Task<bool> CreateCar(CarCreate model);
        Task<List<CarListItem>> GetAllCars();
        Task<CarDetail> GetCarById(int id);
        Task<bool> UpdateCar(CarUpdate model);
        Task<bool> DeleteCar(int id);
    }
}