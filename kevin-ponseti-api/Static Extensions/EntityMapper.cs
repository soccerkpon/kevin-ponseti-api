using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Extensions.Options;
using kevin_ponseti_api.Models;
using kevin_ponseti_api.Models.DTOs;

namespace kevin_ponseti_api.Static_Extensions
{
    public static class EntityMapper
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Tech, TechDto>()
                    .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.TechDomain.Location));
            });
        }
    }
}
