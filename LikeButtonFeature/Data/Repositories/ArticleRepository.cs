using LikeButtonFeature.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Data.Repositories
{
    public class ArticleRepository : BaseRepository<Article, int>, IArticleRepository
    {
        public readonly AppDbContext _context;
        public ArticleRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
