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
        public Task AddLike(int ArticleId, int UserId);
        void OnLikeAdded(int ArticleId);
    }
}
