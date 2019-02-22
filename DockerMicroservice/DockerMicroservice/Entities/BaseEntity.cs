using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerMicroservice.Entities
{
    public class BaseEntity
    {
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
