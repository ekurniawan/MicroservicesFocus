using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PlatformService.DTOs;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            CreateMap<Platform,PlatformReadDto>();
            CreateMap<PlatformCreateDto,Platform>();
            CreateMap<PlatformReadDto, PlatformPublishedDto>();
        }
    }
}