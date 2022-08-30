using kevin_ponseti_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kevin_ponseti_api.DataAccess
{
    public interface IKevinPonsetiContext
    {
        DbSet<Tech> Tech { get; set; }
        int SaveChanges();
    }
}
