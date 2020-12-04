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
        /// <summary>
        /// This property makes fetching like count easier especially 
        /// when there are like a million requests to get this value.
        /// Instead of aggreating count from Likes table, we simply 
        /// return this value. Although arguably a bad schema design choice,
        /// it could be potentially be a good trade off in perculiar situations.
        /// </summary>
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
