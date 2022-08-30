using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kevin_ponseti_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kevin_ponseti_api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TechController : Controller
    {
        private readonly ITechService _techService;
        public TechController(ITechService techService)
        {
            _techService = techService;
        }

        [HttpGet(Name = "Get Technology Stack")]
        public IActionResult GetTechnologyStack()
        {
            try
            {
                return Ok(_techService.GetTechnologyStack());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
