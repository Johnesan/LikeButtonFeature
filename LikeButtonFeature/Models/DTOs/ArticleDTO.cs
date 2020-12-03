using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Models.DTOs
{
    public class ArticleDTO
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public long LikeCount { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
