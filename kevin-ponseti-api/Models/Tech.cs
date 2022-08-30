using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kevin_ponseti_api.Models
{
    public class Tech : Audit
    {
        [StringLength(256)]
        public string Name { get; set; }
        [StringLength(256)]
        public string Version { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        public int TechDomainId { get; set; }
        public TechDomain TechDomain { get; set; }
    }
}
