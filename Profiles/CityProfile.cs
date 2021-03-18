﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
            CreateMap<Entities.City, Models.CityDto>();
        }
    }
}
