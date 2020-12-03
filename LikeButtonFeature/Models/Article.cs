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
        public long LikeCount { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; } //To handle concurrency conflicts

        /*
         * 
         * And the other properties...
         * 
         */
    }
}
