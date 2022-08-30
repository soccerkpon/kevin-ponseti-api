using kevin_ponseti_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kevin_ponseti_api.Repositories
{
    public interface ITechRepo
    {
        IQueryable<Tech> Get();
    }
}
