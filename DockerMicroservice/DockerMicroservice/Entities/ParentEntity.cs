using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DockerMicroservice.Entities
{
    public partial class ParentEntity: BaseEntity
    {
        [Key]
       // [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        public virtual ICollection<ChildEntity> Children { get; set; }
           
    }
}
