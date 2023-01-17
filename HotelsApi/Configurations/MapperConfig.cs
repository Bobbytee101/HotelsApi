using AutoMapper;
using HotelsApi.Data;
using HotelsApi.Models.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelsApi.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
            CreateMap<Country, CreateCountry>().ReverseMap();
            CreateMap<Country, GetCountry>().ReverseMap();
            CreateMap<Country, Country>().ReverseMap();
            CreateMap<Country, UpdateCountry>().ReverseMap();

            CreateMap<Hotel, Hotel>().ReverseMap();
        }
    }
}
