using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using StreetOutlaws.Data.Context;
using StreetOutlaws.Data.Entities;
using StreetOutlaws.Models.CarModel;

namespace StreetOutlaws.Services.CarServices
{
    public class CarService : ICarService
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public CarService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCar(CarCreate model)
        {
            var car = _mapper.Map<Car>(model);
            await _context.Cars.AddAsync(car);
            return await _context.SaveChangesAsync()>0;
        }

        public async Task<bool> DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car is null) return false;
            else
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<List<CarListItem>> GetCars()
        {
            var cars = await _context.Cars.ToListAsync();
            return _mapper.Map<List<CarListItem>>(cars);
        }

        public async Task<CarDetail> GetCarById(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car is null) return new CarDetail();
            
            return _mapper.Map<CarDetail>(car);
        }

        public async Task<bool> UpdateCar(CarUpdate model)
        {
            var car = await _context.Cars.FindAsync(model.Id);
            if (car is null) return false;
            else
            {
                car.Id = model.Id;
                car.Make = model.Make;
                car.Model = model.Model;
                car.Year = model.Year;

            await _context.SaveChangesAsync();
            return true;
            }
        }
    }
}