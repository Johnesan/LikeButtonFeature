using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Models
{
    public class BaseEntity<PK>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public PK Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
