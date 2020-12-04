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

        public async Task<long> GetLikeCount(int Id)
        {
            var article = await _repo.Get(Id);
            if (article == null)
                throw new ApplicationException("Invalid article Id");

            return article.LikeCount;
        }

        public void OnLikeAdded(object sender, LikeEventArgs args)
        {
            var article = _repo.Get(args.ArticleId).Result;
            _repo.IncrementLikeCount(article);
        }
    }
}
