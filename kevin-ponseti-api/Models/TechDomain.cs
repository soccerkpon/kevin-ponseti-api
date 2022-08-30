using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kevin_ponseti_api.Models
{
    public class TechDomain : Audit
    {
        [StringLength(256)]
        public string Location { get; set; }
    }
}
