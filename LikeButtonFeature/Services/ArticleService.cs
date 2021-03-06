﻿using LikeButtonFeature.Models;
using AutoMapper;
using LikeButtonFeature.Data.Repositories;
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
        private readonly ILikeService _likeService;

        public ArticleService(IArticleRepository repo, IMapper mapper, ILikeService likeService)
        {
            _repo = repo;
            _mapper = mapper;
            _likeService = likeService;
        }

        /// <summary>
        /// This approach fetches the like count directly from the Likes table.
        /// It leverages the index on the ArticleId column on Likes table to query 
        /// faster. The advantage of this mode is that performance overhead caused by
        /// incessant updates to the article record is taken out of the picture.
        /// It however takes a performance hit when a million users query for the same
        /// article's like count - That's a million count(*) from Likes table.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<ArticleDTO> GetArticle(int Id)
        {
            var articles = await _repo.Get(x => x.Id == Id, null, "Likes");
            var article = articles?.SingleOrDefault();
            if (article == null)
                throw new ApplicationException("Invalid article Id");

            var articleToReturn = _mapper.Map<ArticleDTO>(article);
            articleToReturn.LikeCount = article.Likes.Count();
            return articleToReturn;
        }


        public async Task<long> GetLikeCount(int Id)
        {
            throw new NotImplementedException();
        }

        public void OnLikeAdded(object sender, LikeEventArgs args)
        {
            return;
        }
    }

}
