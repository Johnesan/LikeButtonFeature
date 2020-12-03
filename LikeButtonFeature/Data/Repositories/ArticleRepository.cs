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

        public void IncrementLikeCount(Article article)
        {
            bool updateFailed;
            do
            {
                updateFailed = false;

                try
                {
                    article.LikeCount++;
                    _context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    updateFailed = true;
                    ex.Entries.Single().Reload();
                }

            } while (updateFailed);
        }
    }
}
