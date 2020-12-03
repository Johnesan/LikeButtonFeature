using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LikeButtonFeature.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LikeButtonFeature.Controllers
{
    [Route("Articles")]
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        //Sample: {baseUrl}/Articles/Get/1
        [HttpGet("Get/{Id}")]
        public async Task<IActionResult> Get(int Id)
        {
            try
            {
                var article = await _articleService.GetArticle(Id);
                if (article == null)
                    return NotFound("Article not found");

                return Ok(article);
            }
            catch (ApplicationGeneratedException ex)
            {
                return StatusCode((int)ex.Code, ex.Message);
            }
            catch (Exception ex)
            {
                //Implement logging here...
                throw ex;
            }
        }

    }
}
