using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DockerMicroservice.Entities
{
    public class ChildEntity
    {
        [Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ChildId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        [ForeignKey("ParentId")]
        public ParentEntity Parent { get; set; }
    }
}
