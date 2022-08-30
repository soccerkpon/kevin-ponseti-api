using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kevin_ponseti_api.Models
{
    public class Audit
    {
        public int Id { get; set; }
        [Required]
        [StringLength(256)]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedTime { get; set; }
        [Required]
        [StringLength(256)]
        public string CreatedModule { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public string ModifiedModule { get; set; }
        public bool Status { get; set; }
    }
}
