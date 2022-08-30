using kevin_ponseti_api.Models;
using kevin_ponseti_api.Models.DTOs;
using System.Collections.Generic;

namespace kevin_ponseti_api.Services
{
    public interface ITechService
    {
        List<TechDto> GetTechnologyStack();
    }
}
