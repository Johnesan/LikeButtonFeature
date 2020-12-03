using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Models.DTOs
{
    public class LikeRequestDTO
    {
        public int ArticleId { get; set; }
        public int UserId { get; set; }
    }
}
