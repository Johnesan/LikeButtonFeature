using LikeButtonFeature.Models;
using LikeButtonFeature.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature
{
    public interface IArticleService
    {
        /// <summary>
        /// Get details of an article with specified Id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<ArticleDTO> GetArticle(int Id);
        /// <summary>
        /// Get the number of likes an article has.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Task<long> GetLikeCount(int Id);
        /// <summary>
        /// Event handler that fires up when a new Like is added to the Likes Table 
        /// for this article. This method updates the LikeCount of the specified article with +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLikeAdded(object sender, LikeEventArgs args);
    }
}
