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
        public Task<ArticleDTO> GetArticle(int Id);
        public Task<long> GetLikeCount(int Id);
        public void IncrementLikes(int ArticleId);
        public void OnLikeAdded(object sender, LikeEventArgs args);
    }
}
