using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Models
{
    public class Like : BaseEntity<int>
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
        public Article Article { get; set; }
        public User User { get; set; }
    }
}
