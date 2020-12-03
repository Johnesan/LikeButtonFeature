using LikeButtonFeature.Data.Repositories;
using LikeButtonFeature.Helpers;
using LikeButtonFeature.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _repo;
        private readonly IArticleService _articleService;
        private readonly IUserService _userService;

        public event LikeAddedEventHandler LikeAdded;

        public LikeService(ILikeRepository repo, IArticleService articleService, IUserService userService)
        {
            _repo = repo;
            _articleService = articleService;
            _userService = userService;
        }

        public async Task AddLike(int ArticleId, int UserId)
        {
            await _repo.InsertAndCatchUniqueConstraintError(new Like
            {
                ArticleId = ArticleId,
                UserId = UserId
            });

            OnLikeAdded(ArticleId);
        }

        public virtual void OnLikeAdded(int ArticleId)
        {
            LikeAdded?.Invoke(this, new LikeEventArgs { ArticleId = ArticleId });
        }
    }
}
