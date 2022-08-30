using kevin_ponseti_api.DataAccess;
using kevin_ponseti_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kevin_ponseti_api.Repositories
{
    public class TechRepo : ITechRepo
    {
        private readonly IKevinPonsetiContext _ctx;
        public TechRepo(IKevinPonsetiContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Tech> Get()
        {
            return _ctx.Tech.AsQueryable();
        }

        private bool Save()
        {
            return (_ctx.SaveChanges() >= 0);
        }
    }
}
