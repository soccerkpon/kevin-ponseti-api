using kevin_ponseti_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kevin_ponseti_api.DataAccess
{
    public class KevinPonsetiContext : DbContext, IKevinPonsetiContext
    {
        public KevinPonsetiContext(DbContextOptions<KevinPonsetiContext> options) : base(options) { }
        public DbSet<Tech> Tech { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tech>().HasQueryFilter(x => x.Status);
            modelBuilder.Entity<TechDomain>().HasQueryFilter(x => x.Status);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
