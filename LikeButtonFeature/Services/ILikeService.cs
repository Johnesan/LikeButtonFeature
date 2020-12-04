using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Services
{
    public interface ILikeService
    {
        public event LikeAddedEventHandler LikeAdded;
        /// <summary>
        /// Adds a new Like for the specified article, by the specified
        /// user. Insert operation fails if user has already liked the article.
        /// </summary>
        /// <param name="ArticleId"></param>
        /// <param name="UserId"></param>
        /// <returns></returns>
        public Task AddLike(int ArticleId, int UserId);
        /// <summary>
        /// Event publisher that sends notification to subscribers when a
        /// new Like is added along with details of the just liked article.
        /// </summary>
        /// <param name="ArticleId"></param>
        void OnLikeAdded(int ArticleId);
        /// <summary>
        /// Get the like count for a specified article Id
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        public Task<long> GetCountLikeForArticle(int articleId);
    }
}
