using AutoMapper;
using LikeButtonFeature.Data.Repositories;
using LikeButtonFeature.Models;
using LikeButtonFeature.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeButtonFeature.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _repo;
        private readonly IMapper _mapper;

        public ArticleService(IArticleRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ArticleDTO> GetArticle(int Id)
        {
            var article = await _repo.Get(Id);
            return _mapper.Map<ArticleDTO>(article);
        }

        /// <summary>
        /// This approach fetches LikeCount from a costodian property on the 
        /// article table. This mode works best when this value is being queried
        /// with large traffic. LikeCount is quickly returned to the caller without
        /// doing a table aggregate on the Likes table. It however trades off with a
        /// performance hit when likes are being added at large scale, because this table
        /// will constantly be updated. 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<long> GetLikeCount(int Id)
        {
            var article = await _repo.Get(Id);
            if (article == null)
                throw new ApplicationException("Invalid article Id");

            return article.LikeCount;
        }

        /// <summary>
        /// This method updates the article's LikeCount property anytime a new like is
        /// added on the system.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnLikeAdded(object sender, LikeEventArgs args)
        {
            var article = _repo.Get(args.ArticleId).Result;
            _repo.IncrementLikeCount(article);
        }
    }
}
