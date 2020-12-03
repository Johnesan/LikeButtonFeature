using LikeButtonFeature.Helpers;
using LikeButtonFeature.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Data.Repositories
{
    public class LikeRepository : BaseRepository<Like, int>, ILikeRepository
    {

        public LikeRepository(AppDbContext context) : base(context)
        {
        }

        public async virtual Task InsertAndCatchUniqueConstraintError(Like like)
        {
            try
            {
                await Insert(like);
            }
            catch (DbUpdateException ex) when (ex?.InnerException is SqlException sqlEx && sqlEx.Number == 2601)
            {
                throw new ApplicationGeneratedException(ErrorCode.BadRequest, "You have already liked this article.");
            }
        }
    }
}
