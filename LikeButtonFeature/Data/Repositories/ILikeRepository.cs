using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Data.Repositories
{
    public interface ILikeRepository : IBaseRepository<Like, int>
    {
        /// <summary>
        /// Inserts a Like entity to the db. Implementation should catch Unique constraint errror and 
        /// throw an ApplicationGeneratedException with a user friendly message.
        /// </summary>
        /// <param name="like"></param>
        /// <returns></returns>
        Task InsertAndCatchUniqueConstraintError(Like like);
    }
}
