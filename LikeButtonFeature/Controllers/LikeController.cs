using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LikeButtonFeature.Helpers;
using LikeButtonFeature.Models.DTOs;
using LikeButtonFeature.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LikeButtonFeature.Controllers
{
    [Route("Like")]
    public class LikeController : Controller
    {
        private readonly ILikeService _likeService;
        private readonly IArticleService _articleService;
        private readonly IUserService _userService;

        public LikeController(ILikeService likeService, IArticleService articleService, IUserService userService)
        {
            _likeService = likeService;
            _articleService = articleService;
            _userService = userService;
        }

        [HttpPost("New")]
        public async Task<IActionResult> New([FromBody] LikeRequestDTO request)
        {
            try
            {
                var user = await _userService.GetUser(request.UserId);
                if (user == null)
                    return BadRequest("User not found.");

                var article = await _articleService.GetArticle(request.ArticleId);
                if (article == null)
                    return BadRequest("Article not found.");

                _likeService.LikeAdded += _articleService.OnLikeAdded;
                await _likeService.AddLike(request.ArticleId, request.UserId);

                return Ok("You have liked this article.");
            }
            catch (ApplicationGeneratedException ex)
            {
                return StatusCode((int)ex.Code, ex.ResponseMessage);
            }
            catch (Exception ex)
            {
                //Implement logging here...
                throw ex;
            }
        }
    }
}
