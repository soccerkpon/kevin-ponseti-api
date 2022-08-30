using AutoMapper;
using kevin_ponseti_api.Models.DTOs;
using kevin_ponseti_api.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace kevin_ponseti_api.Services
{
    public class TechService : ITechService
    {
        private readonly ITechRepo _techRepo;
        public TechService(ITechRepo techRepo)
        {
            _techRepo = techRepo;
        }

        public List<TechDto> GetTechnologyStack()
        {
            var techDto = new List<TechDto>();
            var tech = _techRepo.Get()
                .Include(x => x.TechDomain).ToList();
            Mapper.Map(tech, techDto);

            return techDto;
        }
    }
}
