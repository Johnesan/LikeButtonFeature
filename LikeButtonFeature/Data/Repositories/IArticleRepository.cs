using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Data.Repositories
{
    public interface IArticleRepository : IBaseRepository<Article, int>
    {
        /// <summary>
        /// Increases an article's like count by one. Implemententation should cater for concurrency conflicts.
        /// </summary>
        /// <param name="article"></param>
        public void IncrementLikeCount(Article article);
    }
}
