using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Data.Repositories
{
    public interface ILikeRepository : IBaseRepository<Like, int>
    {
        Task InsertAndCatchUniqueConstraintError(Like like);
    }
}
