using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using StreetOutlaws.Data.Entities;
using StreetOutlaws.Models.CarModel;
using StreetOutlaws.Models.DriverModels;
using StreetOutlaws.Models.TeamModels;
using StreetOutlaws.Models.TrackModels;

namespace StreetOutlaws.Services.Configurations
{
    public class MappingConfigurations : Profile
    {
        public MappingConfigurations()
        {
            CreateMap<Car,CarCreate>().ReverseMap();
            CreateMap<Car,CarDetail>().ReverseMap();
            CreateMap<Car,CarListItem>().ReverseMap();
            CreateMap<Car,CarUpdate>().ReverseMap();

            CreateMap<Driver,DriverCreate>().ReverseMap();
            CreateMap<Driver,DriverDetail>().ReverseMap();
            CreateMap<Driver,DriverListItem>().ReverseMap();
            CreateMap<Driver,DriverUpdate>().ReverseMap();

            CreateMap<Team,TeamCreate>().ReverseMap();
            CreateMap<Team,TeamDetail>().ReverseMap();
            CreateMap<Team,TeamListItem>().ReverseMap();
            CreateMap<Team,TeamUpdate>().ReverseMap();
            
            CreateMap<Track,TrackCreate>().ReverseMap();
            CreateMap<Track,TrackDetail>().ReverseMap();
            CreateMap<Track,TrackListItem>().ReverseMap();
            CreateMap<Track,TrackUpdate>().ReverseMap();
        }
    }
}