using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Models
{
    public class Article : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public IEnumerable<Like> Likes { get; set; } 
       
        /*
         * 
         * And the other properties...
         * 
         */
    }
}
